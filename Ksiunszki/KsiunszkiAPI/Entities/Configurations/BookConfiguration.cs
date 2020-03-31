using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KsiunszkiAPI.Entities.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(book => book.Id);

            builder.HasAlternateKey(book => book.ISBN);

            builder.Property(book => book.Title).IsRequired();

            builder.HasOne(book => book.Publisher)
                .WithMany(publisher => publisher.Books)
                .HasForeignKey(book => book.PublisherId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(book => book.Parent)
                .WithMany()
                .HasForeignKey(book => book.ParentId);

            builder.ToTable("Books");
        }
    }
}