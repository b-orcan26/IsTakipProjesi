using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories.DapperRepositories.Interfaces
{
    public interface IGorevRepository : IRepository<Gorev>
    {
        Task<List<Gorev>> GetAllWithIncludedElementsAsync(int id=0);
        int CompletedGorevCountByUserId(int id);

        int UncompletedGorevCountByUserId(int id);

        Task<List<Gorev>> GetGorevsByUserId(int id);

        Task<Gorev> GetGorevByRaporId(int id); 
    }
}
