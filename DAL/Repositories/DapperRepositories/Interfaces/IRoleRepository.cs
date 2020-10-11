using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories.DapperRepositories.Interfaces
{
    public interface IRoleRepository : IRepository<Role>
    {
        Task UserAssignRole(List<UsersRoleUpdate> liste);
    }
}
