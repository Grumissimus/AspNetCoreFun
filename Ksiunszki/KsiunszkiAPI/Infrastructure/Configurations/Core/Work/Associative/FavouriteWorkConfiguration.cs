using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace API.Infrastructure.Configurations
{
    public class FavouriteWorkConfiguration : IEntityTypeConfiguration<FavoriteWork>
    {
        public void Configure(EntityTypeBuilder<FavoriteWork> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.HasKey(a => new { a.WorkId, a.UserId });

            builder.HasOne(b => b.Work)
                .WithMany(a => a.UserFavorites)
                .HasForeignKey(b => b.WorkId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.User)
                .WithMany(b => b.FavoriteWorks)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("FavoriteWorks");
        }
    }
}