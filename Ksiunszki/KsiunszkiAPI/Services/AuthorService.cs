using KsiunszkiAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Services
{
    public class AuthorService : IAuthorService
    {
        private ApiContext Context { get; set; }

        public AuthorService(ApiContext context)
        {
            Context = context;
        }

        public Author Read(int id)
        {
            var author = Context.Authors.FirstOrDefault(a => a.Id == id);
            return author;
        }

        public List<Author> Read(string name)
        {
            var author = Context.Authors.Where( a => a.Name.Contains(name) );
            return author.ToList();
        }

        public void Create(Author entity)
        {
            Context.Authors.Add(entity);
            Context.SaveChanges();
        }

        public void Update(int id, Author entity)
        {
            var authorToBeUpdated = Read(id);

            if (authorToBeUpdated == null) 
                return;

            entity.Id = id;

            Context.Entry(authorToBeUpdated).CurrentValues.SetValues(entity);
            Context.SaveChanges();
        }

        public void Delete(int id)
        {
            var author = Read(id);

            Context.Authors.Remove(author);
            Context.SaveChanges();
        }
    }
}
