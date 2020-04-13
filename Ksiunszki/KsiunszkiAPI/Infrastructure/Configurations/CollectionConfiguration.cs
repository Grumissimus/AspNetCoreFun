using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Infrastructure.Configurations
{
    public class CollectionConfiguration : IEntityTypeConfiguration<UserList>
    {
        public void Configure(EntityTypeBuilder<UserList> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).IsRequired();
            builder.ToTable("Collections");
        }
    }
}