using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KsiunszkiAPI.Entities.Configurations
{
    public class ListConfiguration : IEntityTypeConfiguration<List>
    {
        public void Configure(EntityTypeBuilder<List> builder)
        {
            builder.HasKey(list => list.Id);

            builder.Property(list => list.Name).IsRequired();

            builder.ToTable("Lists");
        }
    }
}