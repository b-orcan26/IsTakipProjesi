using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IService<T> where T:class
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task Add(T entity);
        Task Delete(int id);
        Task Update(T entity);
    }
}
