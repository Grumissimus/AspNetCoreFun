using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KsiunszkiAPI.Entities.Configurations
{
    public class BookSeriesConfiguration : IEntityTypeConfiguration<BookSeries>
    {
        public void Configure(EntityTypeBuilder<BookSeries> builder)
        {
            builder.HasKey(bs => new { bs.BookId, bs.SeriesId });

            builder.HasOne(bs => bs.Book)
                .WithMany(b => b.BookSeries)
                .HasForeignKey(bs => bs.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(bs => bs.Series)
                .WithMany(s => s.BookSeries)
                .HasForeignKey(bs => bs.SeriesId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(bs => bs.Order)
                .IsRequired();

            builder.ToTable("BookSeries");
        }
    }
}