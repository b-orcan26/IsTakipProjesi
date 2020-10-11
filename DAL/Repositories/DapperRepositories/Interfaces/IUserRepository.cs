using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories.DapperRepositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> Login(User entity);

        Task<List<Role>> GetRolesByUserId(int id);

        Task<List<Entities.UserListWithRoles>> GetUsersWithRoles();

        Task<User> GetUserByUsername(string username);

    }
}
