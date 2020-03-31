using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KsiunszkiAPI.Entities.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name).IsRequired();

            builder.Property(a => a.BirthDay).HasColumnType("Date").HasDefaultValue(null);

            builder.Property(a => a.DeathDay).HasColumnType("Date").HasDefaultValue(null);

            builder.ToTable("Authors");
        }
    }
}