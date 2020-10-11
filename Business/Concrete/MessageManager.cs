using Business.Interfaces;
using DAL.Repositories.DapperRepositories.Interfaces;
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MessageManager : Manager<Message>, IMessageService
    {
        private readonly IMessageRepository repository;

        public MessageManager(IMessageRepository _repository):base(_repository)
        {
            repository = _repository;
        }

        public async Task<List<Message>> GetAllWithIncludedElementsAsync(int id)
        {
            return await repository.GetAllWithIncludedElementsAsync(id);
        }
    }
}
