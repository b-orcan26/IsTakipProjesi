using Business.Interfaces;
using DAL.Repositories.DapperRepositories.Interfaces;
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : Manager<User> , IUserService
    {
        private readonly IUserRepository _repository;
        public UserManager(IUserRepository repository) : base(repository)
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

        public async Task<List<Entities.UserListWithRoles>> GetUsersWithRoles()
        {
            return await _repository.GetUsersWithRoles();
        }

        public async Task<User> GetUserByUsername(string username)
        {
            return await _repository.GetUserByUsername(username);
        }

    }
}
