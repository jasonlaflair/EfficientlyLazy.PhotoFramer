using Autofac;
using EfficientlyLazy.PhotoFramer.Repositories;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.ByteCode.Castle;
using NHibernate.Cfg;


namespace EfficientlyLazy.PhotoFramer.Modules
{

    public class NHibernateComponentModule<T> : Module where T : IEntity
    {
        protected override void Load(ContainerBuilder builder)
        {
            var config = Fluently.Configure()
                .ProxyFactoryFactory<ProxyFactoryFactory>()
                .Database(MsSqlConfiguration.MsSql2005.ConnectionString(x => x.Server(".\\SQL2005").TrustedConnection().Database("IocTesting")))
                //.ExposeConfiguration(SetProperties)
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<T>().Conventions.AddFromAssemblyOf<T>())
                .BuildConfiguration();

            var sessionFactory = config.BuildSessionFactory();

            builder.RegisterInstance(config)
                .As<Configuration>()
                .SingleInstance();

            builder.RegisterInstance(sessionFactory)
                .As<ISessionFactory>()
                .SingleInstance();

            builder.Register(x => x.Resolve<ISessionFactory>()
                .OpenSession())
                .As<ISession>()
                .InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof (ReadableRepository<>))
                .As(typeof(IReadableRepository<>));

            builder.RegisterGeneric(typeof(WriteableRepository<>))
                .As(typeof(IWriteableRepository<>));
        }
    }
}