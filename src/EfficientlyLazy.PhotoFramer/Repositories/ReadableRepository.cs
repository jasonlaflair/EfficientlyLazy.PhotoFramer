using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Linq;

namespace EfficientlyLazy.PhotoFramer.Repositories
{
    internal class ReadableRepository<T> : IReadableRepository<T> where T : class, IReadable
    {
        protected ReadableRepository()
            : this(ServiceFactory.Resolve<ISession>())
        {
        }

        protected ReadableRepository(ISession session)
        {
            Session = session;
        }

        protected ISession Session { get; private set; }
        
        public virtual T Get(long id)
        {
            return Session.Get<T>(id);
        }

        public virtual IQueryable<T> Query()
        {
            return Session.Query<T>();
        }

        public virtual IQueryOver<T, T> QueryOver()
        {
            return Session.QueryOver<T>();
        }

        public virtual void Refresh(T entity)
        {
            Session.Refresh(entity);
        }

        public virtual void Refresh(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                var session = Session;
                session.Refresh(entity);
            }
        }
    }
}