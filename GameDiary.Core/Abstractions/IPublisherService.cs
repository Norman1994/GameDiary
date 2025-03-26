using GameDiary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Core.Abstractions
{
    public interface IPublisherService
    {
        Task<List<Publisher>> GetAllPublishers();

        Task<Guid> AddPublisher(Publisher publisher);

        Task<Guid> UpdatePublisher(Guid id, string name);

        Task<Guid> DeletePublisher(Guid id);
    }
}
