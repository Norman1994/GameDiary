using GameDiary.Dao.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Dao
{
    public class GameDiaryDbContext : DbContext
    {
        public GameDiaryDbContext(DbContextOptions<GameDiaryDbContext> options)
            :base(options)
        {
        }

        public GameDiaryDbContext() { } 

        public DbSet<DevelopEntity> Developers { get; set; }   
        
        public DbSet<PublisherEntity> Publishers { get; set; }
    }
}
