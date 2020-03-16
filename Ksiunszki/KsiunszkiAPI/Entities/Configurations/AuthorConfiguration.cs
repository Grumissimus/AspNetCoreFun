using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Entities.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name).IsRequired();

            builder.Property(a => a.BirthDay).HasColumnType("DATE").HasDefaultValue(null);

            builder.Property(a => a.DeathDay).HasColumnType("DATE").HasDefaultValue(null);

            builder.ToTable("Authors");
        }
    }
}
