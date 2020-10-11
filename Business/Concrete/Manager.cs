using Business.Interfaces;
using DAL.Repositories.DapperRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class Manager<T> : IService<T> where T : class
    {
        private readonly IRepository<T> repository;
        public Manager(IRepository<T> _repository)
        {
            repository = _repository;
        }
        public async Task Add(T entity)
        {
            await repository.Add(entity);
        }

        public async Task Delete(int id)
        {
            await repository.Delete(id);
        }

        public async Task<T> Get(int id)
        {
            return await repository.Get(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task Update(T entity)
        {
            await repository.Update(entity);
        }
    }
}
