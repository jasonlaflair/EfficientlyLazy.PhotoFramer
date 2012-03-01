using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace EfficientlyLazy.PhotoFramer.Entities
{
    [Serializable]
    public class PhotoData
    {
        private readonly static XmlSerializer _serializer = new XmlSerializer(typeof(PhotoData));
        private readonly static string _filenamePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PhotoFramer");
        private readonly static string _filename = Path.Combine(_filenamePath, "PhotoFramerData.xml");

        public List<ConfigurationValue> Configuration { get; set; }
        public List<Photo> Photos { get; set; }
        public List<PhotoFrameState> FrameState { get; set; }

        public PhotoData()
        {
            Configuration = new List<ConfigurationValue>();
            Photos = new List<Photo>();
            FrameState = new List<PhotoFrameState>();
        }

        internal static PhotoData Load()
        {
            var data = new PhotoData();

            if (File.Exists(_filename))
            {
                using (var sr = new StreamReader(_filename))
                {
                    data = (PhotoData)_serializer.Deserialize(sr);
                }
            }

            return data;
        }

        internal void Save()
        {
            if (!Directory.Exists(_filenamePath))
            {
                Directory.CreateDirectory(_filenamePath);
            }

            using (var sw = new StreamWriter(_filename, false))
            {
                _serializer.Serialize(sw, this);
            }
        }
    }
}