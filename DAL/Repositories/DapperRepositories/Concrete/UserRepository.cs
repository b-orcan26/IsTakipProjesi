using DAL.Repositories.DapperRepositories.Interfaces;
using Dapper;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories.DapperRepositories.Concrete
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly IConnectionFactory factory;
        protected const string _tableName= "Users";
        public UserRepository(IConnectionFactory _factory):base(tableName:_tableName , _factory)
        {
            factory = _factory;
        }

        public async Task<User> Login(User entity)
        {
            using var connection = factory.GetConnection();
            var user = await connection.QuerySingleOrDefaultAsync<User>($"SELECT * FROM {_tableName} WHERE KullaniciAdi=@KullaniciAdi AND Parola=@Parola",new {KullaniciAdi=entity.KullaniciAdi,Parola=entity.Parola });
            return user;
        }

        public async Task<List<Role>> GetRolesByUserId(int id)
        {
            using var connection = factory.GetConnection();
            var role = await connection.QueryAsync<Role>($"Select ro.* From UsersRoles AS ur  INNER JOIN  Users AS us ON ur.UserId = us.Id  INNER JOIN Roles AS ro ON ur.RoleId = ro.Id WHERE us.Id=@id",new { id = id });          
            return role.ToList();            
        }

        public async Task<List<UserListWithRoles>> GetUsersWithRoles()
        {
            using var connection = factory.GetConnection();
            IEnumerable<User> users = null;

            var query = "select* from Users";
            users = await connection.QueryAsync<User>($"Select* From Users");

            List<UserListWithRoles> dtos = new List<UserListWithRoles>();
            foreach(var item in users)
            {
                UserListWithRoles dto = new UserListWithRoles()
                {
                    Ad = item.Ad,
                    Id = item.Id,
                    KullaniciAdi = item.KullaniciAdi,
                    Soyad = item.Soyad
                };
                dtos.Add(dto);
            }

            foreach(var item in dtos)
            {
                item.Roles = await GetRolesByUserId(item.Id);
            }

            return dtos;          
        }

        public async Task<User> GetUserByUsername(string username)
        {
            using var connection = factory.GetConnection();
            var user = await connection.QuerySingleOrDefaultAsync<User>($"Select * FROM Users Where KullaniciAdi = @username",new { username = username });
            return user;
        }
    }
}
