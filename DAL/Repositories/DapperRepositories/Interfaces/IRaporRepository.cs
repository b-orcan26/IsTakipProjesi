using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories.DapperRepositories.Interfaces
{
    public interface IRaporRepository : IRepository<Rapor>
    {
        Task<List<Rapor>> RaporsByGorevId(int id);

        Task<List<Rapor>> GetAllWithIncludedElementsAsync();

        int RaporCountByUserId(int id);

        Task<List<Rapor>> RaporsByUserId(int id);
    }
}
