using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KsiunszkiAPI.Entities.Configurations
{
    public class SeriesConfiguration : IEntityTypeConfiguration<Series>
    {
        public void Configure(EntityTypeBuilder<Series> builder)
        {
            builder.HasKey(ser => ser.Id);

            builder.Property(ser => ser.Name).IsRequired();

            builder.ToTable("Series");
        }
    }
}