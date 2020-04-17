using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Persistence.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name).IsRequired().HasMaxLength(128);

            builder.Property(a => a.BirthPlace).HasMaxLength(128);

            builder.Property(a => a.DeathPlace).HasMaxLength(128);

            builder.Property(a => a.Nationality).HasMaxLength(128);

            builder.Property(a => a.Description).HasMaxLength(4000);

            builder.ToTable("Authors");
        }
    }
}