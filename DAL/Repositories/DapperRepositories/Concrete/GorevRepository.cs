using DAL.Repositories.DapperRepositories.Interfaces;
using Dapper;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories.DapperRepositories.Concrete
{
    public class GorevRepository : GenericRepository<Gorev> , IGorevRepository
    {
        private readonly IConnectionFactory factory;
        public GorevRepository(IConnectionFactory _factory):base("Gorevs" ,  _factory)
        {
            factory = _factory;
        }

        public int CompletedGorevCountByUserId(int id)
        {
            using var connection = factory.GetConnection();
            var count = connection.Query<int>($"SELECT COUNT(Id) FROM Gorevs Where Durum = 1 AND UserId = @userid ",new { userid=id });
            
            return Convert.ToInt32(count.First());
        }

        public async Task<List<Gorev>> GetAllWithIncludedElementsAsync(int id=0)
        {
            using var connection = factory.GetConnection();          
            IEnumerable<Gorev> gorevs = null;
            var query = "select go.*, us.* from Gorevs as go left join Users as us ON go.UserId = us.Id";
            gorevs = await connection.QueryAsync<Gorev, User, Gorev>(query,
                (g, u) => { g.User = u; return g; });

            query = "select * from Rapors where GorevId IN @gorevIds";
            var gorevIds = gorevs.Select(x => x.Id);
            var rapors = connection.Query<Rapor>(query, new { gorevIds });
            foreach (var gorev in gorevs)
            {
                gorev.Rapors = rapors.Where(x => x.GorevId == gorev.Id).ToList();
            }

            if (id == 0)
            {
                return gorevs.ToList();
            }
            else
            {
                return gorevs.Where(i => i.UserId == id).ToList();
            }

        }

        public async Task<Gorev> GetGorevByRaporId(int id)
        {
            using var connection = factory.GetConnection();
            var rapor = await connection.QueryFirstOrDefaultAsync<Rapor>($"Select* FROM Rapors Where Rapors.Id = @raporid",new { raporid = id});
            var gorev = await connection.QueryFirstOrDefaultAsync<Gorev>($"Select* FROM Gorevs Where Gorevs.Id = @gorevid", new { gorevid = rapor.GorevId });
            return gorev;
        }

        public async Task<List<Gorev>> GetGorevsByUserId(int id)
        {
            using var connection = factory.GetConnection();
            var gorevs = await connection.QueryAsync<Gorev>($"SELECT* FROM Gorevs Where UserId = @userid", new { userid = id });
            return gorevs.ToList();
        }

        public int UncompletedGorevCountByUserId(int id)
        {
            using var connection = factory.GetConnection();
            var count = connection.Query<int>($"SELECT COUNT(Id) FROM Gorevs Where Durum = 0 AND UserId = @userid ", new { userid = id });

            return Convert.ToInt32(count.First());
        }



    }
}
