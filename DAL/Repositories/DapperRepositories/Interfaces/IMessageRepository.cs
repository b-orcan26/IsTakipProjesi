using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories.DapperRepositories.Interfaces
{
    public interface IMessageRepository : IRepository<Message>
    {
        Task<List<Message>> GetAllWithIncludedElementsAsync(int id);
    }
}
