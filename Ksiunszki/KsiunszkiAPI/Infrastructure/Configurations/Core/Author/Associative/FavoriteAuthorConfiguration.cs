using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Infrastructure.Configurations
{
    public class FavoriteAuthorConfiguration : IEntityTypeConfiguration<FavoriteAuthor>
    {
        public void Configure(EntityTypeBuilder<FavoriteAuthor> builder)
        {
            builder.HasKey(a => new { a.AuthorId, a.UserId });

            builder.HasOne(b => b.Author)
                .WithMany(a => a.UserFavorites)
                .HasForeignKey(b => b.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.User)
                .WithMany(b => b.FavoriteAuthors)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("FavoriteAuthors");
        }
    }
}