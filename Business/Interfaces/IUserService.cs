using DTO;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IUserService : IService<User>
    {
        Task<User> Login(User entity);
        Task<List<Role>> GetRolesByUserId(int id);

        Task<List<Entities.UserListWithRoles>> GetUsersWithRoles();

        Task<User> GetUserByUsername(string username);
    }
}
