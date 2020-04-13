using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace API.Infrastructure.Configurations
{
    public class AuthorAwardConfiguration : IEntityTypeConfiguration<AuthorAward>
    {
        public void Configure(EntityTypeBuilder<AuthorAward> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.HasKey(a => new { a.AuthorId, a.AwardId });

            builder.HasOne(b => b.Author)
                .WithMany(a => a.Awards)
                .HasForeignKey(b => b.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Award)
                .WithMany(b => b.Authors)
                .HasForeignKey(a => a.AwardId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("AuthorAwards");
        }
    }
}