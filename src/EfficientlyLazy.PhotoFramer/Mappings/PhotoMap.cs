using EfficientlyLazy.PhotoFramer.Entities;
using FluentNHibernate.Mapping;

namespace EfficientlyLazy.PhotoFramer.Mappings
{
    public sealed class PhotoMap : ClassMap<Photo>
    {
        public PhotoMap()
        {
            Table("Photos");
            Not.LazyLoad();

            Id(x => x.ID).GeneratedBy.Increment();
            Version(x => x.Version);

            Map(x => x.DateAdded);
            Map(x => x.FileDate);
            Map(x => x.OriginalFileName);
            Map(x => x.ShelfPath); 
            Map(x => x.Filename);
            Map(x => x.Description);
            Map(x => x.IncludeOnFrame);
            Map(x => x.FrameFilename);
            Map(x => x.MarkedAsDeleted);
        }
    }
}
