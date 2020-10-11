using DTO;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IRaporService : IService<Rapor>
    {
        Task<List<Rapor>> RaporsByGorevId(int id);
        Task<List<Rapor>> GetAllWithIncludedElementsAsync();
        int RaporCountByUserId(int id);
        Task<List<Rapor>> RaporsByUserId(int id);

    }
}
