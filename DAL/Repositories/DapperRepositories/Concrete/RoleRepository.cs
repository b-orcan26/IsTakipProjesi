using DAL.Repositories.DapperRepositories.Interfaces;
using Dapper;
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories.DapperRepositories.Concrete
{
    public class RoleRepository : GenericRepository<Role> , IRoleRepository
    {
        private readonly IConnectionFactory factory;
        public RoleRepository(IConnectionFactory _factory):base("Roles" , _factory)
        {
            factory = _factory;
        }

        public async Task UserAssignRole(List<UsersRoleUpdate> liste)
        {
            using var connection = factory.GetConnection();

            foreach(var item in liste)
            {
                if (item.Exists == true)
                {
                    //await connection.QueryAsync("INSERT INTO UsersRoles (UserId,RoleId) VALUES (@userid,@roleid) WHERE  (SELECT Count(*) FROM  UsersRoles WHERE  UserId = @userid AND RoleId = @roleid)<1 "
                    //    , new { userid = item.UserId, roleid = item.RoleId });
                    await connection.QueryAsync("IF NOT EXISTS(SELECT 1 FROM  UsersRoles WHERE  UserId = @userid AND RoleId = @roleid) INSERT INTO UsersRoles (UserId,RoleId) VALUES (@userid,@roleid) ", new { userid = item.UserId, roleid = item.RoleId });

                }
                else
                {
                    await connection.QueryAsync("DELETE FROM UsersRoles WHERE UserId=@userid AND RoleId=@roleid"
                        , new { userid = item.UserId, roleid = item.RoleId });
                }
            }            
        }
    }
}
