using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace API.Infrastructure.Configurations
{
    public class WorkAuthorConfiguration : IEntityTypeConfiguration<WorkAuthor>
    {
        public void Configure(EntityTypeBuilder<WorkAuthor> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.HasKey(a => new { a.WorkId, a.AuthorId });

            builder.HasOne(b => b.Work)
                .WithMany(a => a.Authors)
                .HasForeignKey(b => b.WorkId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Author)
                .WithMany(b => b.Works)
                .HasForeignKey(a => a.WorkId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("WorkAuthors");
        }
    }
}