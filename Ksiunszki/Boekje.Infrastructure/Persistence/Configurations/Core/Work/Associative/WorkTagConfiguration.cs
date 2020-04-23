using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace API.Persistence.Configurations
{
    public class WorkTagConfiguration : IEntityTypeConfiguration<WorkTag>
    {
        public void Configure(EntityTypeBuilder<WorkTag> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.HasKey(a => new { a.WorkId, a.TagId });

            builder.HasOne(b => b.Work)
                .WithMany(a => a.Tags)
                .HasForeignKey(b => b.WorkId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Tag)
                .WithMany(b => b.Works)
                .HasForeignKey(a => a.TagId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("WorkTags");
        }
    }
}