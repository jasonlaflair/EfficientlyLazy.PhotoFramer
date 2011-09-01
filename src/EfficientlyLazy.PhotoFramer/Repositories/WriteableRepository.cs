using System;
using System.Collections.Generic;

namespace EfficientlyLazy.PhotoFramer.Repositories
{
    internal class WriteableRepository<T> : ReadableRepository<T>, IWriteableRepository<T> where T : class, IWriteable
    {
        public virtual void Save(T entity)
        {
            Transact(() => Session.SaveOrUpdate(entity));
        }

        public virtual void SaveAndFlush(T entity)
        {
            Save(entity);
            Flush();
        }

		public virtual void Save(IEnumerable<T> entities)
		{
		    Transact(() =>
		                 {
		                     foreach (var entity in entities)
		                     {
		                         Session.SaveOrUpdate(entity);
		                     }
		                 });
		}

        public virtual void SaveAndFlush(IEnumerable<T> entities)
        {
            Save(entities);
            Flush();
        }

        public virtual void Delete(T entity)
        {
            Transact(() => Session.Delete(entity));
        }

        public virtual void DeleteAndFlush(T entity)
        {
            Delete(entity);
            Flush();
        }

		public virtual void Delete(IEnumerable<T> entities)
		{
		    Transact(() =>
		                 {
		                     foreach (var entity in entities)
		                     {
		                         Session.Delete(entity);
		                     }
		                 });
		}

        public virtual void DeleteAndFlush(IEnumerable<T> entities)
        {
            Delete(entities);
            Flush();
        }

        public virtual void Flush()
        {
            Session.Flush();
        }

        internal virtual TResult Transact<TResult>(Func<TResult> func)
        {
            if (!Session.Transaction.IsActive)
            {
                // Wrap in a transaction
                TResult result;

                using (var tx = Session.BeginTransaction())
                {
                    result = func.Invoke();
                    tx.Commit();
                }

                return result;
            }

            // Don't wrap
            return func.Invoke();
        }

        internal virtual void Transact(Action action)
        {
            Transact(() =>
                         {
                             action.Invoke();
                             return false;
                         });
        }
    }
}