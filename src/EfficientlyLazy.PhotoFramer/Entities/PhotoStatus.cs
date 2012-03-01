using System;

namespace EfficientlyLazy.PhotoFramer.Entities
{
    [Serializable]
    public enum PhotoStatus
    {
        Deleted = -5,
        Duplicated = -2,
        Excluded = -1,
        Pending = 0,
        Included = 1
    }
}