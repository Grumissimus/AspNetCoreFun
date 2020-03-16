using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Entities
{
    public class KsiunszkiContext : DbContext
    {
        protected KsiunszkiContext()
        {

        }

        public KsiunszkiContext(DbContextOptions options) : base(options)
        {
         
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly(), 
                t => t.Namespace == "KsiunszkiAPI.Entities.Configurations"
            );
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<List> Lists { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
