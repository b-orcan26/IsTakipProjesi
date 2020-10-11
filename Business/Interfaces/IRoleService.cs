using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IRoleService : IService<Role>
    {
        Task UserAssignRole(List<UsersRoleUpdate> liste);
    }
}
