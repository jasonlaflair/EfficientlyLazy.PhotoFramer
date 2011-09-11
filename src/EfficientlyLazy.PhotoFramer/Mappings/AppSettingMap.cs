using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EfficientlyLazy.PhotoFramer.Entities;
using FluentNHibernate.Mapping;

namespace EfficientlyLazy.PhotoFramer.Mappings
{
    public sealed class AppSettingMap : ClassMap<AppSetting>
    {
        public AppSettingMap()
        {
            Table("AppSettings");
            Not.LazyLoad();

            Id(x => x.ID).GeneratedBy.Increment();
            Version(x => x.Version);

            Map(x => x.Name);
            Map(x => x.Value);
        }
    }
}
