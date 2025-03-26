using GameDiary.Core.Abstractions;
using GameDiary.Core.Models;
using GameDiary.Dao.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Dao.Repositories
{
    public class PublisherRepository : IPublisherRepository
    {
        private readonly GameDiaryDbContext _context;

        public PublisherRepository(GameDiaryDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Create(Publisher publisher)
        {
            var publisherEntity = new PublisherEntity
            {
                Id = publisher.Id,
                Name = publisher.Name
            };

            await _context.Publishers.AddAsync(publisherEntity);
            await _context.SaveChangesAsync();

            return publisherEntity.Id;
        }

        public async Task<Guid> Delete(Guid id)
        {
            await _context.Publishers
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            return id;
        }

        public async Task<List<Publisher>> Get()
        {
            var publisherEntities = await _context.Publishers
                .AsNoTracking()
                .ToListAsync();

            var publishers = publisherEntities
                .Select(e => Publisher.Create(e.Id, e.Name).Publisher)
                .ToList();

            return publishers;
        }

        public async Task<Guid> Update(Guid id, string name)
        {
            await _context.Publishers
                .Where(x => x.Id == id)
                .ExecuteUpdateAsync(s => s
                    .SetProperty(x => x.Name, x => name));

            return id;
        }
    }
}
