using System.Collections.Generic;
using System.Linq;
using EfficientlyLazy.PhotoFramer.Services;

namespace EfficientlyLazy.PhotoFramer.Entities
{
    internal class Configuration
    {
        public static string FramePath
        {
            get
            {
                return GetString("FramePath");
            }
            set
            {
                SetValue("FramePath", value);
            }
        }

        public static string ArchivePath
        {
            get
            {
                return GetString("ArchivePath");
            }
            set
            {
                SetValue("ArchivePath", value);
            }
        }

        public static string CameraPath
        {
            get
            {
                return GetString("CameraPath");
            }
            set
            {
                SetValue("CameraPath", value);
            }
        }

        public static int FrameWidth
        {
            get
            {
                return GetInt("FrameWidth");
            }
            set
            {
                SetValue("FrameWidth", value);
            }
        }

        public static int FrameHeight
        {
            get
            {
                return GetInt("FrameHeight");
            }
            set
            {
                SetValue("FrameHeight", value);
            }
        }

        public static string ExtensionsCSV
        {
            get
            {
                return GetString("ExtensionsCSV");
            }
            set
            {
                SetValue("ExtensionsCSV", value);
            }
        }

        public static List<string> Extensions
        {
            get
            {
                return ExtensionsCSV.Split(',').ToList();
            }
        }

        public static void Save()
        {
            Repository.Flush();
        }

        private static string GetString(string key)
        {
            var config = Repository.ConfigurationValues().FirstOrDefault(x => x.Key == key);

            return config == null
                       ? string.Empty
                       : config.Value;
        }

        private static int GetInt(string key)
        {
            var config = Repository.ConfigurationValues().FirstOrDefault(x => x.Key == key);

            int value;

            if (config == null || !int.TryParse(config.Value, out value))
            {
                return 0;
            }
             
            return value;
        }

        private static void SetValue<T>(string key, T value)
        {
            var config = Repository.ConfigurationValues().FirstOrDefault(x => x.Key == key) ?? new ConfigurationValue
                                                                                                   {
                                                                                                       Key = key
                                                                                                   };

            config.Value = value.ToString();

            config.Save();
        }
    }
}
