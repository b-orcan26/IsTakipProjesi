using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IAuthService
    {
        Task<User> Login(User entity);
        Task<List<Role>> GetRolesByUserId(int id);
    }
}
