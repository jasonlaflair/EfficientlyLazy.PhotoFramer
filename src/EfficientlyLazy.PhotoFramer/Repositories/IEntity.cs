using System;

namespace EfficientlyLazy.PhotoFramer.Repositories
{
    public interface IEntity
    {
        Guid ID { get; set; }
        int Version { get; set; }
    }
}