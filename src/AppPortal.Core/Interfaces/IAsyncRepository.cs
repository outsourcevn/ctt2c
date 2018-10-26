using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPortal.Core.Interfaces
{
    public interface IAsyncRepository<T, Tkey> where T : IEntity<Tkey>
    {
        Task<T> GetByIdAsync(Tkey Id);
        Task<IEnumerable<T>> ListAllAsync();
        //Task<List<T>> ListAsync(ISpecification<T> spec);
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
