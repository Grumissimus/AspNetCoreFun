using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KsiunszkiAPI.Entities.Configurations
{
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasKey(pub => pub.Id);

            builder.Property(pub => pub.Name).IsRequired();

            builder.ToTable("Publishers");
        }
    }
}