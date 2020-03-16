using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Entities.Configurations
{
    public class BookTagsConfiguration : IEntityTypeConfiguration<BookTags>
    {
        public void Configure(EntityTypeBuilder<BookTags> builder)
        {
            builder.HasKey(bs => new { bs.BookId, bs.TagId });

            builder.HasOne(bs => bs.Book)
                .WithMany(b => b.BookTags)
                .HasForeignKey(bs => bs.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(bs => bs.Tag)
                .WithMany(s => s.BookTags)
                .HasForeignKey(bs => bs.TagId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("BookTags");
        }
    }
}
