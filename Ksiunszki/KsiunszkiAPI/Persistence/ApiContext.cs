using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace API.Persistence
{
    public class ApiContext : DbContext
    {
        protected ApiContext()
        {
        }

        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly(),
                t => t.Namespace == "API.Persistence.Configurations"
            );
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Franchise> Franchises { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<UserList> UserLists { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}