using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories.DapperRepositories.Interfaces
{
    public interface IRepository<T> where T:class
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task Add(T entity);
        Task Delete(int id);
        Task Update(T entity);
    }
}
