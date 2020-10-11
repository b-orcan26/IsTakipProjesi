using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IMessageService : IService<Message>
    {
        Task<List<Message>> GetAllWithIncludedElementsAsync(int id);

    }
}
