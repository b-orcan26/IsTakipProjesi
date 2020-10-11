using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IGorevService : IService<Gorev>
    {
        Task<List<Gorev>> GetAllWithIncludedElementsAsync(int id=0);
        int CompletedGorevCountByUserId(int id);
        int UncompletedGorevCountByUserId(int id);

        Task<List<Gorev>> GetGorevsByUserId(int id);

        Task<Gorev> GetGorevByRaporId(int id);
    }
}
