using Business.Interfaces;
using DAL.Repositories.DapperRepositories.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly IUserRepository _repository;
        public AuthManager(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<User> Login(User entity)
        {
            return await _repository.Login(entity);
        }

        public async Task<List<Role>> GetRolesByUserId(int id)
        {
            return await _repository.GetRolesByUserId(id);
        }
    }
}
