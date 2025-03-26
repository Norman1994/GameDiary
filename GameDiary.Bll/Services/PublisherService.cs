using GameDiary.Core.Abstractions;
using GameDiary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Bll.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly IPublisherRepository _publisherRepository;

        public PublisherService(IPublisherRepository publisherRepository)
        { 
            _publisherRepository = publisherRepository;
        }

        public async Task<Guid> AddPublisher(Publisher publisher)
        {
            return await _publisherRepository.Create(publisher);
        }

        public async Task<Guid> DeletePublisher(Guid id)
        {
            return await _publisherRepository.Delete(id);
        }

        public async Task<List<Publisher>> GetAllPublishers()
        {
            return await _publisherRepository.Get();
        }

        public async Task<Guid> UpdatePublisher(Guid id, string name)
        {
            return await _publisherRepository.Update(id, name); 
        }
    }
}
