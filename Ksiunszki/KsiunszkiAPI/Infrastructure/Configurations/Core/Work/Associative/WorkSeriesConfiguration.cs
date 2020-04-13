using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace API.Infrastructure.Configurations
{
    public class WorkSeriesConfiguration : IEntityTypeConfiguration<WorkSeries>
    {
        public void Configure(EntityTypeBuilder<WorkSeries> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.HasKey(a => new { a.WorkId, a.SeriesId });

            builder.HasOne(b => b.Work)
                .WithMany(a => a.Series)
                .HasForeignKey(b => b.WorkId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Series)
                .WithMany(b => b.Works)
                .HasForeignKey(a => a.SeriesId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("WorkSeries");
        }
    }
}