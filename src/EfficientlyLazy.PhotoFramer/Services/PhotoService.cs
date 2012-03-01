using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EfficientlyLazy.PhotoFramer.Entities;

namespace EfficientlyLazy.PhotoFramer.Services
{
    internal static class PhotoService
    {
        public static ProcessStatus SyncArchive()
        {
            var status = new ProcessStatus();

            var newRecords = new List<Photo>();

            foreach (var photo in Repository.Photos())
            {
                if (!File.Exists(photo.ArchiveFullName))
                {
                    photo.DateDeleted = DateTime.Now;
                    photo.Status = PhotoStatus.Deleted;
                    status.PhotoRemoved();
                }
                else
                {
                    status.PhotoExists();
                }
            }

            var archivePath = Configuration.ArchivePath.TrimEnd('\\');
            var archive = new DirectoryInfo(archivePath);

            var extensions = Configuration.Extensions;

            var fileList = new List<FileInfo>();

            foreach (var extension in extensions)
            {
                var mask = string.Format("*.{0}", extension);

                var files = archive.GetFiles(mask, SearchOption.AllDirectories)
                    .Where(x => x.DirectoryName != null)
                    .ToList();

                fileList.AddRange(files);
            }

            Parallel.ForEach(fileList, file =>
                                    {
                                        var shelf = file.Directory.FullName.Replace(archivePath, string.Empty).TrimStart('\\');
                                        var filename = file.Name;

                                        if (!Repository.Photos().Any(x => x.Shelf == shelf && x.Filename == filename))
                                        {
                                            newRecords.Add(Photo.New(file, shelf));
                                            status.PhotoAdded();
                                        }
                                    });

            newRecords.Save();

            var dups = DeDupe();

            status.PhotoRemoved(dups);

            return status;
        }

        private static int DeDupe()
        {
            var dupCount = 0;

            var dups = Repository.Photos().GroupBy(x => x.HashValue)
                .Select(x => new
                                 {
                                     Hash = x.Key,
                                     PhotoCount = x.Count()
                                 })
                .Where(x => x.PhotoCount > 1)
                .ToList();

            var dupSaves = new List<Photo>();

            var activeList = new List<PhotoStatus>
                                 {
                                     PhotoStatus.Excluded,
                                     PhotoStatus.Included,
                                     PhotoStatus.Pending
                                 };

            foreach (var dup in dups)
            {
                var ids = Repository.Photos().Where(x => x.HashValue == dup.Hash).Select(x => x.ID).ToList();

                var first = Repository.Photos()
                    .Where(x => ids.Contains(x.ID))
                    .Where(x => activeList.Contains(x.Status))
                    .OrderBy(x => x.DateAdded)
                    .ThenByDescending(x => x.Status)
                    .FirstOrDefault();

                if (first != null)
                {
                    ids.Remove(first.ID);
                    dupSaves.Add(first);
                }

                foreach (var photo in Repository.Photos().Where(x => ids.Contains(x.ID)))
                {
                    if (!activeList.Contains(photo.Status))
                    {
                        continue;
                    }

                    photo.Status = PhotoStatus.Duplicated;
                    photo.DateDeleted = DateTime.Now;

                    dupSaves.Add(photo);

                    dupCount++;
                }
            }

            dupSaves.Save();

            return dupCount;
        }

        public static void RotateImage(Photo record, bool counterClockwise = false)
        {
            var directory = Path.Combine(Configuration.ArchivePath, record.Shelf);
            var filename = Path.Combine(directory, record.Filename);

            var resizeName = Path.Combine(Path.GetTempPath(), record.Filename);

            if (File.Exists(resizeName))
            {
                File.Delete(resizeName);
            }

            File.Move(filename, resizeName);

            using (var image = Image.FromFile(resizeName))
            {
                var type = counterClockwise
                               ? RotateFlipType.Rotate270FlipNone
                               : RotateFlipType.Rotate90FlipNone;

                image.RotateFlip(type);

                image.Save(filename);
            }

            File.Delete(resizeName);
        }

        public static Image ResizeImage(Image imgToResize, Size size)
        {
            var sourceWidth = imgToResize.Width;
            var sourceHeight = imgToResize.Height;

            var nPercentW = ((float)size.Width / (float)sourceWidth);
            var nPercentH = ((float)size.Height / (float)sourceHeight);

            var nPercent = (nPercentH < nPercentW)
                               ? nPercentH
                               : nPercentW;


            var destWidth = (int)(sourceWidth * nPercent);
            var destHeight = (int)(sourceHeight * nPercent);

            var bitmap = new Bitmap(destWidth, destHeight);

            using (var g = Graphics.FromImage(bitmap))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            }

            return bitmap;
        }

        public static ProcessStatus UpdateFrame()
        {
            var status = new ProcessStatus();

            var size = new Size(Configuration.FrameWidth, Configuration.FrameHeight);

            var frame = new DirectoryInfo(Configuration.FramePath);

            var files = frame.GetFiles("*.*", SearchOption.AllDirectories)
                    .ToList();

            var filesToDelete = new List<FileInfo>();

            var photos = Repository.Photos()
                .Where(x => x.Status == PhotoStatus.Included)
                .ToList();

            foreach (var file in files)
            {
                if (photos.All(x => x.FrameFullName != file.FullName))
                {
                    filesToDelete.Add(file);
                    status.PhotoRemoved();
                }
            }

            filesToDelete.ForEach(x => File.Delete(x.FullName));

            var added = new List<Photo>();

            foreach (var photo in photos)
            {
                if (File.Exists(photo.FrameFullName))
                {
                    status.PhotoExists();
                    continue;
                }

                status.PhotoAdded();

                Image frameImage;

                using (var image = Image.FromFile(photo.ArchiveFullName))
                {
                    frameImage = ResizeImage(image, size);
                }

                frameImage.Save(photo.FrameFullName);
            }

            added.Save(false);

            var states = photos.Select(x => new PhotoFrameState
                                                {
                                                    PhotoID = x.ID,
                                                    DateAdded = DateTime.Now
                                                });

            states.Save();

            return status;
        }

        public static ProcessStatus ExtractFromCamera(bool cleanCamera = false)
        {
            var status = new ProcessStatus();

            var cameraPath = Configuration.CameraPath.TrimEnd('\\');
            var archive = new DirectoryInfo(cameraPath);

            var extensions = Configuration.Extensions;

            var fileList = new List<FileInfo>();

            foreach (var extension in extensions)
            {
                var mask = string.Format("*.{0}", extension);

                var files = archive.GetFiles(mask, SearchOption.AllDirectories)
                    .Where(x => x.DirectoryName != null)
                    .ToList();

                fileList.AddRange(files);
            }

            if (fileList.Count == 0)
            {
                return status;
            }

            var shelfDate = DateTime.Now;

            var shelf = string.Format("{0:yyyyMMdd_hhmmss}", shelfDate);

            var shelfPath = Path.Combine(Configuration.ArchivePath, shelf);

            var newPhotos = new List<Photo>();

            foreach (var file in fileList)
            {
                var photo = Photo.New(file, shelf);

                if (Repository.Photos().Any(x => x.HashValue == photo.HashValue))
                {
                    status.PhotoExists();
                    continue;
                }

                if (!Directory.Exists(shelfPath))
                {
                    Directory.CreateDirectory(shelfPath);
                }

                bool success;

                try
                {
                    File.Copy(file.FullName, photo.ArchiveFullName);
                    success = true;

                }
                catch (Exception)
                {
                    success = false;
                }

                if (success)
                {
                    newPhotos.Add(photo);
                    status.PhotoAdded();

                    if (cleanCamera)
                    {
                        try
                        {
                            File.Delete(file.FullName);
                            status.PhotoRemoved();
                        }
                        catch (Exception)
                        {
                            // swallow
                        }
                    }
                }
            }

            newPhotos.Save();

            return status;
        }

        public static ProcessStatus Cleanup()
        {
            var status = new ProcessStatus();

            var photos = Repository.Photos()
                .Where(x => x.Status == PhotoStatus.Deleted || x.Status == PhotoStatus.Duplicated)
                .ToList();

            foreach (var photo in photos)
            {
                try
                {
                    if (File.Exists(photo.ArchiveFullName))
                    {
                        File.Delete(photo.ArchiveFullName);
                        status.PhotoRemoved();
                    }
                }
                catch (Exception)
                {
                    // swallow
                }

                var dir = Path.GetDirectoryName(photo.ArchiveFullName);

                if (string.IsNullOrEmpty(dir))
                {
                    continue;
                }

                var di = new DirectoryInfo(dir);

                if (di.Exists && di.GetFiles("*.*", SearchOption.AllDirectories).Length == 0)
                {
                    di.Delete(true);
                }
            }

            photos.Delete();

            return status;
        }
    }
}
