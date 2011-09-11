using System.IO;
using Autofac;
using EfficientlyLazy.PhotoFramer.Repositories;
using EfficientlyLazy.PhotoFramer.Services;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.ByteCode.Castle;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace EfficientlyLazy.PhotoFramer.Modules
{

    public class NHibernateComponentModule<T> : Module where T : IEntity
    {
        protected override void Load(ContainerBuilder builder)
        {
            var dbFile = Path.Combine(AppSettings.AppRoot, "PhotoFramer.db");

            var config = Fluently.Configure()
                .ProxyFactoryFactory<ProxyFactoryFactory>()
                .Database(SQLiteConfiguration.Standard.UsingFile(dbFile))
                //.ExposeConfiguration(SetProperties)
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<T>().Conventions.AddFromAssemblyOf<T>())
                .BuildConfiguration();

            var schemaUpdate = new SchemaUpdate(config);
            schemaUpdate.Execute(false, true);

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