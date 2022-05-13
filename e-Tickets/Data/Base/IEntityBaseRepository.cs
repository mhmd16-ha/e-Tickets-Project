
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e_Tickets.Data.Base
{
    public interface IEntityBaseRepository<T>where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task Add(T entity);
        Task Update(int id, T entity);
        Task Delete(int id);
    }
}
