using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Entities.Configurations
{
    public class BookListsConfiguration : IEntityTypeConfiguration<BookLists>
    {
        public void Configure(EntityTypeBuilder<BookLists> builder)
        {
            builder.HasKey(bl => new { bl.BookId, bl.ListId });

            builder.HasOne(bl => bl.Book)
                .WithMany(b => b.BookLists)
                .HasForeignKey(bl => bl.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(bl => bl.List)
                .WithMany(l => l.BookLists)
                .HasForeignKey(bl => bl.ListId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("BookLists");
        }
    }
}
