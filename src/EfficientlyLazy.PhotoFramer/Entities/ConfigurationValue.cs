using System;

namespace EfficientlyLazy.PhotoFramer.Entities
{
    [Serializable]
    public class ConfigurationValue
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}