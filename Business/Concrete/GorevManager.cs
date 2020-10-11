using Business.Interfaces;
using DAL.Repositories.DapperRepositories.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class GorevManager : Manager<Gorev> , IGorevService
    {
        private readonly IGorevRepository repository;
        public GorevManager(IGorevRepository _repository):base(_repository)
        {
            repository = _repository;
        }

        public int CompletedGorevCountByUserId(int id)
        {
            return repository.CompletedGorevCountByUserId(id);
        }

        public Task<List<Gorev>> GetAllWithIncludedElementsAsync(int id=0)
        {
            return repository.GetAllWithIncludedElementsAsync(id);
        }

        public async Task<Gorev> GetGorevByRaporId(int id)
        {
            return await repository.GetGorevByRaporId(id);
        }

        public async Task<List<Gorev>> GetGorevsByUserId(int id)
        {
            return await repository.GetGorevsByUserId(id);
        }

        public int UncompletedGorevCountByUserId(int id)
        {
            return repository.UncompletedGorevCountByUserId(id);
        }
    }
}
