using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Domains
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Work> Works { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorGenre>()
                .HasKey(bc => new { bc.AuthorId, bc.GenreId });
            modelBuilder.Entity<AuthorGenre>()
                .HasOne(bc => bc.Author)
                .WithMany(b => b.AuthorGenres)
                .HasForeignKey(bc => bc.AuthorId);
            modelBuilder.Entity<AuthorGenre>()
                .HasOne(bc => bc.Genre)
                .WithMany(c => c.AuthorGenres)
                .HasForeignKey(bc => bc.GenreId);

            modelBuilder.Entity<AuthorWork>()
                .HasKey(bc => new { bc.AuthorId, bc.WorkId });
            modelBuilder.Entity<AuthorWork>()
                .HasOne(bc => bc.Author)
                .WithMany(b => b.AuthorWorks)
                .HasForeignKey(bc => bc.AuthorId);
            modelBuilder.Entity<AuthorWork>()
                .HasOne(bc => bc.Work)
                .WithMany(c => c.AuthorWorks)
                .HasForeignKey(bc => bc.WorkId);

            modelBuilder.Entity<WorkGenre>()
                .HasKey(bc => new { bc.WorkId, bc.GenreId });
            modelBuilder.Entity<WorkGenre>()
                .HasOne(bc => bc.Work)
                .WithMany(b => b.WorkGenres)
                .HasForeignKey(bc => bc.WorkId);
            modelBuilder.Entity<WorkGenre>()
                .HasOne(bc => bc.Genre)
                .WithMany(c => c.WorkGenres)
                .HasForeignKey(bc => bc.GenreId);

            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    AuthorId = 1,
                    Name = "William",
                    Surname = "Shakespeare",
                    BirthYear = 1564,
                    BirthMonth = 4,
                    BirthDay = 23,
                    BirthPlace = "Stratford-upon-Avon",
                    DeathYear = 1616,
                    DeathPlace = "Stratford-upon-Avon"
                }
            );

            modelBuilder.Entity<Work>().HasData(
                new Work
                {
                    WorkId = 1,
                    Title = "Sen nocy letniej"
                }
            );

            modelBuilder.Entity<AuthorWork>().HasData(
                new AuthorWork
                {
                    AuthorId = 1,
                    WorkId = 1
                }
            );
        }
    }
}
