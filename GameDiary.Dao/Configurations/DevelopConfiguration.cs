using GameDiary.Core.Models;
using GameDiary.Dao.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameDiary.Dao.Configurations
{
    public class DevelopConfiguration : IEntityTypeConfiguration<DevelopEntity>
    {
        public void Configure(EntityTypeBuilder<DevelopEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(b => b.Name)
                .IsRequired();
        }
    }
}
