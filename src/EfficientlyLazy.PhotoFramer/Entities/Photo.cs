using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace EfficientlyLazy.PhotoFramer.Entities
{
    [Serializable]
    public class Photo
    {
        public Guid ID { get; set; }
        public string Shelf { get; set; }
        public string Filename { get; set; }
        public PhotoStatus Status { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string HashValue { get; set; }

        private Photo()
        {
        }

        public static Photo New(FileInfo info, string shelf)
        {
            return new Photo
                       {
                           ID = Guid.NewGuid(),
                           Shelf = shelf,
                           Filename = info.Name,
                           Status = PhotoStatus.Pending,
                           DateAdded = DateTime.Now,
                           DateDeleted = null,
                           HashValue = GetHashValue(info.FullName)
                       };
        }

        [XmlIgnore]
        public string ArchiveFullName
        {
            get
            {
                var directory = Path.Combine(Configuration.ArchivePath, Shelf);
                return Path.Combine(directory, Filename);
            }
        }

        [XmlIgnore]
        public string FrameFullName
        {
            get
            {
                return Path.Combine(Configuration.FramePath, ID + ".jpg");
            }
        }

        private static string GetHashValue(string filename)
        {
            byte[] hashBytes;

            using (var file = new FileStream(filename, FileMode.Open))
            {
                var md5 = new MD5CryptoServiceProvider();
                hashBytes = md5.ComputeHash(file);
                file.Close();
            }

            var sb = new StringBuilder();

            for (var i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
            }

            return sb.ToString();
        }
    }
}