using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace API.Infrastructure.Configurations
{
    public class SeriesConfiguration : IEntityTypeConfiguration<Series>
    {
        public void Configure(EntityTypeBuilder<Series> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).IsRequired();
            builder.ToTable("Series");
        }
    }
}