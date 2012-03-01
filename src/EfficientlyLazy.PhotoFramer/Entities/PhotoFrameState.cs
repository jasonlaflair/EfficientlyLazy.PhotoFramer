using System;

namespace EfficientlyLazy.PhotoFramer.Entities
{
    [Serializable]
    public class PhotoFrameState
    {
        public Guid PhotoID { get; set; }
        public DateTime DateAdded { get; set; }
    }
}