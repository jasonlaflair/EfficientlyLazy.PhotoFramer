using System.Collections.Generic;
using System.Linq;
using NHibernate;

namespace EfficientlyLazy.PhotoFramer.Repositories
{
	public interface IReadableRepository<T> where T : IReadable
	{
        T Get(long id);

		IQueryable<T> Query();

        IQueryOver<T, T> QueryOver();

		void Refresh(T entity);

		void Refresh(IEnumerable<T> entities);
	}
}
