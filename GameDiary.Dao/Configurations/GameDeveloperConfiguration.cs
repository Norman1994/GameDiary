using GameDiary.Dao.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Dao.Configurations
{
    public class GameDeveloperConfiguration : IEntityTypeConfiguration<GameDeveloperEntity>
    {
        public void Configure(EntityTypeBuilder<GameDeveloperEntity> builder)
        {
            builder.HasKey(gd => new { gd.GameId, gd.DeveloperId });

            builder.HasOne(gd => gd.GameEntity).
                WithMany(x => x.Developers).
                HasForeignKey(gd => gd.GameId).
                OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(gd => gd.DevelopEntity).
                WithMany(f => f.GameDeveloper).
                HasForeignKey(gd => gd.DeveloperId).
                OnDelete(DeleteBehavior.Cascade);
        }
    }
}
