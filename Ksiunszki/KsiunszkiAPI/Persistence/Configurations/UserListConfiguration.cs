using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Entities.Configurations
{
    public class UserListConfiguration : IEntityTypeConfiguration<UserList>
    {
        public void Configure(EntityTypeBuilder<UserList> builder)
        {
            builder.HasKey(list => list.Id);

            builder.Property(list => list.Name).IsRequired();

            builder.ToTable("Lists");
        }
    }
}