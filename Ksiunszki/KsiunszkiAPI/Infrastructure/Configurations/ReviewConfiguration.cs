using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace API.Infrastructure.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            if(builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Content).IsRequired();
            builder.ToTable("Reviews");
        }
    }
}