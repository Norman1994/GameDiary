using GameDiary.Core.Models;
using GameDiary.Dao.Configurations;
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

        public DbSet<GameEntity> Games { get; set; }

        public DbSet<GameDeveloperEntity> GameDeveloperEntities { get; set; }

        public DbSet<GamePublisherEntity> GamePublisherEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GameDeveloperConfiguration());
            modelBuilder.ApplyConfiguration(new GamePublisherConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
