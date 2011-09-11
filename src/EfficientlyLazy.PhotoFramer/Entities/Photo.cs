using System;
using System.IO;
using EfficientlyLazy.PhotoFramer.Repositories;
using EfficientlyLazy.PhotoFramer.Services;

namespace EfficientlyLazy.PhotoFramer.Entities
{
    public class Photo : IWriteable
    {
        public long ID { get; set; }

        public DateTime DateAdded { get; set; }
        public DateTime FileDate { get; set; }
        public string OriginalFileName { get; set; }
        public string Filename { get; set; }
        public string ShelfPath { get; set; }
        public string Description { get; set; }
        public bool IncludeOnFrame { get; set; }
        public string FrameFilename { get; set; }
        public bool MarkedAsDeleted { get; set; }

        public int Version { get; set; }

        public string FullFilename
        {
            get
            {
                var directory = Path.Combine(AppSettings.ImageRoot, ShelfPath);
                
                return Path.Combine(directory, Filename);
            }
        }

        public Photo()
        {
            ID = 0;
            DateAdded = DateTime.Now;
            FileDate = DateTime.Now;
            Filename = string.Empty;
            ShelfPath = string.Empty;
            Description = string.Empty;
            IncludeOnFrame = true;
            FrameFilename = string.Empty;
            MarkedAsDeleted = false;
        }
    }
}
