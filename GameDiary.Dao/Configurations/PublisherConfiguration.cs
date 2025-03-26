using GameDiary.Dao.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameDiary.Dao.Configurations
{
    public class PublisherConfiguration : IEntityTypeConfiguration<PublisherEntity>
    {
        public void Configure(EntityTypeBuilder<PublisherEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(b => b.Name)
                .IsRequired();
        }
    }
}
