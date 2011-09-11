using System;

namespace EfficientlyLazy.PhotoFramer.Repositories
{
    public interface IEntity
    {
        long ID { get; set; }
        int Version { get; set; }
    }
}