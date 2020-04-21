using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using API.Models.Core.Authors;

namespace API.Persistence.Configurations
{
    public class AuthorScoreConfiguration : IEntityTypeConfiguration<AuthorScore>
    {
        public void Configure(EntityTypeBuilder<AuthorScore> builder)
        {
            builder.HasKey(a => new { a.AuthorId, a.UserId });

            builder.Property(a => a.Score).IsRequired();

            builder.HasOne(b => b.Author)
                .WithMany(a => a.UserScores)
                .HasForeignKey(b => b.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.User)
                .WithMany(b => b.AuthorScores)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("AuthorScores");
        }
    }
}