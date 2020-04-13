using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Infrastructure.Configurations
{
    public class AwardConfiguration : IEntityTypeConfiguration<Award>
    {
        public void Configure(EntityTypeBuilder<Award> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).IsRequired();
            builder.ToTable("Awards");
        }
    }
}