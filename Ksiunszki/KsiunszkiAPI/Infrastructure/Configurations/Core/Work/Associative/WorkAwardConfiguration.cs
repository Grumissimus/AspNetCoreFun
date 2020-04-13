using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Infrastructure.Configurations
{
    public class WorkAwardConfiguration : IEntityTypeConfiguration<WorkAward>
    {
        public void Configure(EntityTypeBuilder<WorkAward> builder)
        {
            builder.HasKey(a => new { a.WorkId, a.AwardId });

            builder.HasOne(b => b.Work)
                .WithMany(a => a.Awards)
                .HasForeignKey(b => b.WorkId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Award)
                .WithMany(b => b.Works)
                .HasForeignKey(a => a.AwardId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("WorkAwards");
        }
    }
}