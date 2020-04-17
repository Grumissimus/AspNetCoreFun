using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Persistence.Configurations
{
    public class AuthorTagConfiguration : IEntityTypeConfiguration<AuthorTag>
    {
        public void Configure(EntityTypeBuilder<AuthorTag> builder)
        {
            builder.HasKey(a => new { a.AuthorId, a.TagId });

            builder.HasOne(b => b.Author)
                .WithMany(a => a.Tags)
                .HasForeignKey(b => b.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Tag)
                .WithMany(b => b.Authors)
                .HasForeignKey(a => a.TagId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("AuthorTags");
        }
    }
}