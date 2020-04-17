using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace API.Persistence.Configurations
{
    public class WorkScoreConfiguration : IEntityTypeConfiguration<WorkScore>
    {
        public void Configure(EntityTypeBuilder<WorkScore> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.HasKey(a => new { a.WorkId, a.UserId });

            builder.HasOne(b => b.Work)
                .WithMany(a => a.UserScores)
                .HasForeignKey(b => b.WorkId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.User)
                .WithMany(b => b.WorkScores)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("WorkScores");
        }
    }
}