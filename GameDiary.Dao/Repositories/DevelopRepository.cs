using GameDiary.Core;
using GameDiary.Core.Abstractions;
using GameDiary.Core.Models;
using GameDiary.Dao.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameDiary.Dao.Repositories
{
    public class DevelopRepository : IDevelopRepository
    {
        private readonly GameDiaryDbContext _context;

        public DevelopRepository(GameDiaryDbContext context)
        {
            _context = context; 
        }

        public async Task<List<Developer>> Get()
        { 
            var developEntities = await _context.Developers
                .AsNoTracking() 
                .ToListAsync();

            var developers = developEntities
                .Select(e => Developer.Create(e.Id, e.Name).Developer)
                .ToList();

            return developers;
        }

        public async Task<Guid> Create(Developer developer)
        {
            var developEntity = new DevelopEntity
            {
                Id = developer.Id,
                Name = developer.Name
            };

            await _context.Developers.AddAsync(developEntity);
            await _context.SaveChangesAsync();  

            return developEntity.Id;
        }

        public async Task<Guid> Update(Guid id, string name)
        {
            await _context.Developers
                .Where(x => x.Id == id)
                .ExecuteUpdateAsync(s => s
                    .SetProperty(x => x.Name, x => name));

            return id;
        }

        public async Task<Guid> Delete(Guid id)
        {
            await _context.Developers
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            return id;
        }
    }
}
