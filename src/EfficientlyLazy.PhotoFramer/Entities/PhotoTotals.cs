using System.Collections.Generic;
using System.Linq;
using EfficientlyLazy.PhotoFramer.Services;

namespace EfficientlyLazy.PhotoFramer.Entities
{
    internal class PhotoTotals
    {
        public int Total { get; set; }
        public int Deleted { get; set; }
        public int Duplicated { get; set; }
        public int Included { get; set; }
        public int Excluded { get; set; }
        public int Pending { get; set; }

        public int FrameCurrent { get; set; }
        public int FrameProjected { get; set; }
        public int FramePendingAdd { get; set; }
        public int FramePendingRemove { get; set; }

        public PhotoTotals() : this(Repository.Photos(), Repository.PhotoFrameStates())
        {
            
        }

        public PhotoTotals(List<Photo> list) : this(list, Repository.PhotoFrameStates())
        {
        }

        private PhotoTotals(List<Photo> list, List<PhotoFrameState> states)
        {
            Refresh(list, states);
        }

        private void Refresh(List<Photo> photos, List<PhotoFrameState> states)
        {
            Total = photos.Count(x => x.Status != PhotoStatus.Deleted && x.Status != PhotoStatus.Duplicated);
            Duplicated = photos.Count(x => x.Status == PhotoStatus.Duplicated);
            Deleted = photos.Count(x => x.Status == PhotoStatus.Deleted);
            Included = photos.Count(x => x.Status == PhotoStatus.Included);
            Excluded = photos.Count(x => x.Status == PhotoStatus.Excluded);
            Pending = photos.Count(x => x.Status == PhotoStatus.Pending);

            var frameIds = states.Select(x => x.PhotoID).ToList();
            var includedIds = photos.Where(x => x.Status == PhotoStatus.Included).Select(x => x.ID).ToList();

            FrameCurrent = states.Count;
            FramePendingAdd = includedIds.Except(frameIds).Count();
            FramePendingRemove = frameIds.Except(includedIds).Count();
            FrameProjected = FrameCurrent + FramePendingAdd - FramePendingRemove;
        }
    }
}
