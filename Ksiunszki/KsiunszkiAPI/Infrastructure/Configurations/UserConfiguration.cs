using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace API.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Username).IsRequired();
            builder.Property(a => a.Salt).IsRequired();
            builder.Property(a => a.PassHash).IsRequired();
            builder.Property(a => a.Email).IsRequired();
            builder.Property(a => a.RegistrationDate).IsRequired();
            builder.Property(a => a.LoginDate).IsRequired();

            builder.ToTable("Users");
        }
    }
}