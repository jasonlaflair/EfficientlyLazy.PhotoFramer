using System.Collections.Generic;
using System.Linq;
using EfficientlyLazy.PhotoFramer.Entities;

namespace EfficientlyLazy.PhotoFramer.Services
{
    internal static class Repository
    {
        private static PhotoData _data; 

        static Repository()
        {
            Refresh();
        }

        private static void Refresh()
        {
            _data = PhotoData.Load();
        }

        public static List<Photo> Photos()
        {
            return _data.Photos;
        }

        public static List<ConfigurationValue> ConfigurationValues()
        {
            return _data.Configuration;
        }

        public static List<PhotoFrameState> PhotoFrameStates()
        {
            return _data.FrameState;
        }

        public static void Save(this ConfigurationValue config, bool doFlush = false)
        {
            var rec = _data.Configuration.FirstOrDefault(x => x.Key == config.Key);

            if (rec == null)
            {
                _data.Configuration.Add(config);
            }
            else
            {
                rec.Value = config.Value;
            }

            if (doFlush)
            {
                Flush();
            }
        }

        public static void Save(this Photo photo, bool doFlush = false)
        {
            var rec = _data.Photos.FirstOrDefault(x => x.ID == photo.ID);

            if (rec == null)
            {
                _data.Photos.Add(photo);
            }

            else
            {
                rec.DateAdded = photo.DateAdded;
                rec.Filename = photo.Filename;
                rec.Shelf = photo.Shelf;
                rec.Status = photo.Status;
                rec.DateDeleted = photo.DateDeleted;
                rec.HashValue = photo.HashValue;
            }

            if (doFlush)
            {
                Flush();
            }
        }

        public static void Save(this IEnumerable<Photo> records, bool doFlush = true)
        {
            foreach (var rec in records)
            {
                Save(rec);
            }

            if (doFlush)
            {
                Flush();
            }
        }

        public static void Save(this IEnumerable<PhotoFrameState> states, bool doFlush = true)
        {
            _data.FrameState.Clear();
            _data.FrameState.AddRange(states);

            if (doFlush)
            {
                Flush();
            }
        }

        public static void Delete(this Photo photo, bool doFlush = false)
        {
            var rec = _data.Photos.FirstOrDefault(x => x.ID == photo.ID);

            if (rec == null)
            {
                return;
            }

            _data.Photos.Remove(rec);

            if (doFlush)
            {
                Flush();
            }
        }

        public static void Delete(this IEnumerable<Photo> records, bool doFlush = true)
        {
            foreach (var rec in records)
            {
                Delete(rec);
            }

            if (doFlush)
            {
                Flush();
            }
        }

        public static void Flush()
        {
            _data.Save();
        }
    }
}
