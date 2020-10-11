using DAL.Repositories.DapperRepositories.Interfaces;
using Dapper;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories.DapperRepositories.Concrete
{
    public class RaporRepository : GenericRepository<Rapor> , IRaporRepository
    {
        private readonly IConnectionFactory factory;
        protected string _tableName = "Rapors";
        public RaporRepository(IConnectionFactory _factory):base("Rapors" , _factory)
        {
            factory = _factory;
        }

        public async Task<List<Rapor>> GetAllWithIncludedElementsAsync()
        {
            using var connection = factory.GetConnection();
            IEnumerable<Rapor> rapors = null;
            
            var query = "select ra.*, go.* from Rapors as ra left join Gorevs as go ON ra.GorevId = go.Id";
            rapors = await connection.QueryAsync<Rapor, Gorev, Rapor>(query,
                (r, g) => { r.Gorev = g; return r; });

            query = "select * from Users";
            var users = connection.Query<User>(query);
            foreach (var rapor in rapors)
            {
                var user = users.Where(x => x.Id == rapor.Gorev.UserId).FirstOrDefault();
                rapor.Gorev.User = users.Where(x => x.Id == rapor.Gorev.UserId).FirstOrDefault();
                //rapor.CreatedName = user.Ad + " " + user.Soyad; 
            }
            
            return rapors.ToList();
        }

        public int RaporCountByUserId(int id)
        {
            using var connection = factory.GetConnection();
            var rapors = connection.Query<int>($"Select Count(*) from Rapors as ra inner join Gorevs as go ON ra.GorevId = go.Id Where go.UserId = @userid",new { userid=id});
            return Convert.ToInt32(rapors.First());
        }

        public async Task<List<Rapor>> RaporsByGorevId(int id)
        {
            using var connection = factory.GetConnection();
            var rapors = await connection.QueryAsync<Rapor>($"SELECT * FROM {_tableName} WHERE GorevId=@gId", new { gId = id });
            return rapors.ToList();
        }

        public async Task<List<Rapor>> RaporsByUserId(int id)
        {
            using var connection = factory.GetConnection();
            var rapors = await connection.QueryAsync<Rapor>($"SELECT ra.* FROM Users as us INNER JOIN Gorevs as go ON go.UserId = us.Id INNER JOIN Rapors as ra ON ra.GorevId = go.Id WHERE us.Id = @userid",new { userid = id});
            return rapors.ToList();
        }
    }
}
