using DAL.Repositories.DapperRepositories.Interfaces;
using Dapper;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories.DapperRepositories.Concrete
{
    public class MessageRepository : GenericRepository<Message>, IMessageRepository
    {

        private readonly IConnectionFactory factory;
        public MessageRepository(IConnectionFactory _factory) : base("Messages", _factory)
        {
            factory = _factory;
        }

        public async Task<List<Message>> GetAllWithIncludedElementsAsync(int id)
        {
            using var connection = factory.GetConnection();
            var messages = await connection.QueryAsync<Message>($"SELECT* FROM Messages WHERE GonderenUserId=@gonderen OR AlanUserId=@alan",new { gonderen=id,alan=id});

            foreach(var item in messages)
            {
                var gonderenUser = await connection.QueryFirstAsync<User>($"SELECT* FROM Users WHERE Id=@gonderen", new { gonderen = item.GonderenUserId });
                var alanUser = await connection.QueryFirstAsync<User>($"SELECT* FROM Users WHERE Id=@alan", new { alan = item.AlanUserId });
                item.GonderenUser = gonderenUser;
                item.AlanUser = alanUser;
            }            
            return messages.ToList();
        }



    }
}
