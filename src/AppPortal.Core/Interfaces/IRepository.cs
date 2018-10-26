using System.Collections.Generic;
using System.Linq;

namespace AppPortal.Core.Interfaces
{
    public interface IRepository<T, Tkey> where T : IEntity<Tkey>
    {
        T GetById(Tkey Id);
        IEnumerable<T> ListAll();
        //IEnumerable<T> List(ISpecification<T> spec);
        T Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> Table { get; }
    }
}
