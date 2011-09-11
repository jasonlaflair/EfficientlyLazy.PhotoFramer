using System;
using EfficientlyLazy.PhotoFramer.Repositories;

namespace EfficientlyLazy.PhotoFramer.Entities
{
    public class AppSetting : IWriteable
    {
        public long ID { get; set; }

        public string Name { get; set; }
        public string Value { get; set; }

        public int Version { get; set; }
    }
}
