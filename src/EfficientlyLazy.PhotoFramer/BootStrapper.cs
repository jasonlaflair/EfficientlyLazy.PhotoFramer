using EfficientlyLazy.PhotoFramer.Entities;
using EfficientlyLazy.PhotoFramer.Modules;

namespace EfficientlyLazy.PhotoFramer
{
    public static class BootStrapper
    {
        public static void Start()
        {
            ServiceFactory.Initialize(
                new NHibernateComponentModule<Photo>(),
                new ServiceComponentModule());
        }
    }
}
