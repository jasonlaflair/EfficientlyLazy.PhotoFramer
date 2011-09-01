using System.Collections.Generic;

namespace EfficientlyLazy.PhotoFramer.Repositories
{
	public interface IWriteableRepository<T> : IReadableRepository<T> where T : IWriteable
	{
		void Save(T entity);
	    void SaveAndFlush(T entity);

		void Save(IEnumerable<T> entities);
        void SaveAndFlush(IEnumerable<T> entities);

		void Delete(T entity);
        void DeleteAndFlush(T entity);

		void Delete(IEnumerable<T> entities);
        void DeleteAndFlush(IEnumerable<T> entities);
        
        void Flush();
	}
}
