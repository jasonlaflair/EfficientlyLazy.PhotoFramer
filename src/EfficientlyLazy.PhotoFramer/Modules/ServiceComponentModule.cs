using Autofac;

namespace EfficientlyLazy.PhotoFramer.Modules
{
    public class ServiceComponentModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterAssemblyTypes(typeof(BootStrapper).Assembly)
            //    .Where(t => t.GetCustomAttributes(typeof(ServiceFactoryVisibleAttribute), false).Any())
            //    .AsSelf()
            //    .AsImplementedInterfaces();
        }
    }
}
