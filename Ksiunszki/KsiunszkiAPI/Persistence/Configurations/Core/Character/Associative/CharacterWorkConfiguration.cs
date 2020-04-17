using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Persistence.Configurations
{
    public class CharacterWorkConfiguration : IEntityTypeConfiguration<CharacterWork>
    {
        public void Configure(EntityTypeBuilder<CharacterWork> builder)
        {
            builder.HasKey(a => new { a.CharacterId, a.WorkId });

            builder.HasOne(b => b.Character)
                .WithMany(a => a.Works)
                .HasForeignKey(b => b.CharacterId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Work)
                .WithMany(b => b.Characters)
                .HasForeignKey(a => a.WorkId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("CharacterWorks");
        }
    }
}