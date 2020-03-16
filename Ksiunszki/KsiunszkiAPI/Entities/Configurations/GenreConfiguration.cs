﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Entities.Configurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(genre => genre.Id);

            builder.Property(genre => genre.Name).IsRequired();

            builder.HasOne(genre => genre.Parent)
                .WithMany()
                .HasForeignKey(genre => genre.ParentId);

            builder.ToTable("Genres");
        }
    }
}
