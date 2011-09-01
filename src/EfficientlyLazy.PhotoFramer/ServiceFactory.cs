using Autofac;

namespace EfficientlyLazy.PhotoFramer
{
    public static class ServiceFactory
    {
        private static IContainer _container;

        public static void Clear()
        {
            if (_container == null)
            {
                return;
            }

            _container.Dispose();
            _container = null;
        }

        public static void Initialize(params Module[] modules)
        {
            var builder = new ContainerBuilder();

            foreach (var module in modules)
            {
                builder.RegisterModule(module);
            }

            _container = builder.Build();
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public static IContainer GetContainer()
        {
            return _container;
        }
    }
}