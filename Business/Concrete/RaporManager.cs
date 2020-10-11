using Business.Interfaces;
using DAL.Repositories.DapperRepositories.Interfaces;
using DTO;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RaporManager : Manager<Rapor> , IRaporService
    {
        private readonly IRaporRepository repository;
        public RaporManager(IRaporRepository _repository):base(_repository)
        {
            repository = _repository;
        }

        public async Task<List<Rapor>> GetAllWithIncludedElementsAsync()
        {
            return await repository.GetAllWithIncludedElementsAsync();
        }

        public int RaporCountByUserId(int id)
        {
            return repository.RaporCountByUserId(id);
        }

        public async Task<List<Rapor>> RaporsByGorevId(int id)
        {
            return await repository.RaporsByGorevId(id);
        }

        public async Task<List<Rapor>> RaporsByUserId(int id)
        {
            return await repository.RaporsByUserId(id);
        }
    }
}
