using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace API.Infrastructure.Configurations
{
    public class WorkUserListConfiguration : IEntityTypeConfiguration<WorkUserList>
    {
        public void Configure(EntityTypeBuilder<WorkUserList> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.HasKey(a => new { a.WorkId, a.UserListId });

            builder.HasOne(b => b.Work)
                .WithMany(a => a.UserLists)
                .HasForeignKey(b => b.WorkId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.UserList)
                .WithMany(b => b.Works)
                .HasForeignKey(a => a.UserListId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("WorkUserLists");
        }
    }
}