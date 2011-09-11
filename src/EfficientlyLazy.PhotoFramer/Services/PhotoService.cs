using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;
using EfficientlyLazy.PhotoFramer.Entities;
using EfficientlyLazy.PhotoFramer.Repositories;
using NLog;

namespace EfficientlyLazy.PhotoFramer.Services
{
    [ServiceFactoryVisibleAttribute]
    internal class PhotoService : IPhotoService
    {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private readonly IWriteableRepository<Photo> _photoRepository = ServiceFactory.Resolve<IWriteableRepository<Photo>>();

        public PhotoService(IWriteableRepository<Photo> photoRepository)
        {
            _photoRepository = photoRepository;
        }

        public virtual Photo AddPhoto(string filename, bool deleteOriginal)
        {
            Photo photo;

            try
            {
                var fileDate = DateTime.Now;

                try
                {
                    var metaDateFound = false;

                    using (var image = Image.FromFile(filename))
                    {
                        if (image.PropertyIdList.Contains(306))
                        {
                            var raw = Encoding.UTF8.GetString(image.GetPropertyItem(306).Value);

                            var bits = raw.Replace(" ", ":").Split(':');

                            fileDate = DateTime.Parse(String.Format("{0}/{1}/{2} {3}:{4}:{5}", bits[1], bits[2], bits[0], bits[3], bits[4], bits[5]));

                            metaDateFound = true;
                        }
                    }

                    if (!metaDateFound)
                    {
                        var fi = new FileInfo(filename);

                        fileDate = fi.CreationTime > fi.LastWriteTime ? fi.LastWriteTime : fi.CreationTime;
                    }
                }
                catch (Exception ex)
                {
                    _logger.FatalException("Failed to get file date/time", ex);
                }

                photo = new Photo
                            {
                                DateAdded = DateTime.Now,
                                FileDate = fileDate,
                                Description = string.Empty,
                                OriginalFileName = filename,
                                Filename = Path.GetFileName(filename),
                                IncludeOnFrame = false,
                                ShelfPath = string.Format("{0:0000}\\{1:00}", fileDate.Year, fileDate.Month)
                            };

                VerifyFileNotShelved(photo);

                CopyPhoto(photo, deleteOriginal);

                _photoRepository.SaveAndFlush(photo);
            }
            catch (Exception ex)
            {
                _logger.FatalException(string.Format("Error loading image: {0}", filename), ex);
                photo = null;
            }

            return photo;
        }

        internal virtual void VerifyFileNotShelved(Photo photo)
        {
            var originalFilename = photo.Filename;
            var increment = 0;

            while (File.Exists(photo.FullFilename))
            {
                increment++;

                photo.Filename = IncrementFilename(originalFilename, increment);
            }
        }

        internal virtual string IncrementFilename(string filename, int increment)
        {
            var path = Path.GetDirectoryName(filename);
            var rawName = Path.GetFileNameWithoutExtension(filename);
            var extension = Path.GetExtension(filename);

            return Path.Combine(path, string.Format("{0}_{1}{2}", rawName, increment, extension));
        }

        internal virtual bool CopyPhoto(Photo photo, bool deleteOriginal)
        {
            bool success;

            try
            {
                var destPath = Path.GetDirectoryName(photo.FullFilename);

                if (!Directory.Exists(destPath))
                {
                    Directory.CreateDirectory(destPath);
                }

                if (deleteOriginal)
                {
                    File.Move(photo.OriginalFileName, photo.FullFilename);
                }
                else
                {
                    File.Copy(photo.OriginalFileName, photo.FullFilename);
                }

                success = true;
            }
            catch (Exception ex)
            {
                _logger.FatalException(string.Format("Copy Failure: Source: {0} - Dest: {1}", photo.OriginalFileName, photo.FullFilename), ex);
                success = false;
            }

            return success;
        }

        public virtual int AddPhotos(string directory, bool deleteOriginals)
        {
            var photos = new List<Photo>();

            var dir = new DirectoryInfo(directory);

            var files = dir.GetFiles("*.jpg");

            foreach (var file in files)
            {
                var photo = AddPhoto(file.FullName, deleteOriginals);

                if (photo != null)
                {
                    photos.Add(photo);
                }
            }

            return photos.Count;
        }

        public virtual void Cleanup()
        {
            CleanupDatabase();
            CleanupFileSystem();
        }

        internal virtual int CleanupDatabase()
        {
            var deleteList = new List<Photo>();

            foreach (var photo in _photoRepository.Query())
            {
                if (File.Exists(photo.FullFilename))
                {
                    continue;
                }

                deleteList.Add(photo);
            }

            _photoRepository.DeleteAndFlush(deleteList);

            return deleteList.Count;
        }

        internal virtual int CleanupFileSystem()
        {
            var root = new DirectoryInfo(AppSettings.ImageRoot);

            var missingRecords = new List<Photo>();

            FindMissingRecords(root, missingRecords);

            _photoRepository.SaveAndFlush(missingRecords);

            return missingRecords.Count;
        }

        internal virtual void FindMissingRecords(DirectoryInfo directory, List<Photo> missing)
        {
            var directoryList = directory.GetDirectories();

            foreach (var dir in directoryList)
            {
                FindMissingRecords(dir, missing);
            }

            var fileList = directory.GetFiles("*.jpg");

            foreach (var file in fileList)
            {
                var filename = file.Name;
                var shelf = file.DirectoryName.Replace(AppSettings.ImageRoot, string.Empty).TrimStart('\\');

                var photo = _photoRepository.Query().FirstOrDefault(x => x.Filename == filename && x.ShelfPath == shelf);

                if (photo != null)
                {
                    continue;
                }

                missing.Add(new Photo
                                {
                                    DateAdded = DateTime.Now,
                                    Description = string.Empty,
                                    Filename = filename,
                                    IncludeOnFrame = false,
                                    OriginalFileName = string.Empty,
                                    ShelfPath = shelf
                                });
            }
        }
    }
}
