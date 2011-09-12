using System;
using System.IO;
using System.Linq;
using EfficientlyLazy.PhotoFramer.Entities;
using EfficientlyLazy.PhotoFramer.Repositories;

namespace EfficientlyLazy.PhotoFramer.Services
{
    public static class AppSettings
    {
        private static IWriteableRepository<AppSetting> _settingEntityRepository;

        static AppSettings()
        {
            AppRoot = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PhotoFramer");

            if (!Directory.Exists(AppRoot))
            {
                Directory.CreateDirectory(AppRoot);
            }

            ImageRoot = Path.Combine(AppRoot, "Images");
        }

        public static int FrameHeight
        {
            get { return Get("FrameHeight", 600); }
            set { Set("FrameHeight", value); }
        }

        public static int FrameWidth
        {
            get { return Get("FrameWidth", 800); }
            set { Set("FrameWidth", value); }
        }

        public static bool ResizeForFrame
        {
            get { return Get("ResizeForFrame", false); }
            set { Set("ResizeForFrame", value); }
        }

        public static string CameraRoot
        {
            get { return Get("CameraRoot", string.Empty); }
            set { Set("CameraRoot", value); }
        }

        public static string FrameRoot
        {
            get { return Get("FrameRoot", string.Empty); }
            set { Set("FrameRoot", value); }
        }

        public static string AppRoot { get; private set; }
        public static string ImageRoot { get; private set; }

        private static T Get<T>(string name, T defaultValue)
        {
            InstantiateRepository();

            var setting = _settingEntityRepository.Query().FirstOrDefault(x => x.Name == name);

            return setting == null ? defaultValue : (T)Convert.ChangeType(setting.Value, typeof (T));
        }

        private static void Set<T>(string name, T settingValue)
        {
            InstantiateRepository();

            var setting = _settingEntityRepository.Query().FirstOrDefault(x => x.Name == name) ?? new AppSetting
                                                                                                      {
                                                                                                          Name = name
                                                                                                      };

            setting.Value = settingValue.ToString();

            _settingEntityRepository.SaveAndFlush(setting);
        }

        private static void InstantiateRepository()
        {
            if (_settingEntityRepository != null)
            {
                return;
            }

            _settingEntityRepository = new WriteableRepository<AppSetting>();
        }
    }
}
