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
    public class GamePublisherConfiguration : IEntityTypeConfiguration<GamePublisherEntity>
    {
        public void Configure(EntityTypeBuilder<GamePublisherEntity> builder)
        {
            builder.HasKey(gd => new { gd.GameId, gd.PublisherId });

            builder.HasOne(g => g.GameEntity).
                WithMany(x => x.Publishers)
                .HasForeignKey(x => x.GameId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(g => g.PublisherEntity).
                WithMany(x => x.GamePublisher)
                .HasForeignKey(y => y.GameId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
