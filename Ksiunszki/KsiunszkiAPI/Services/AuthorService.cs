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

        public Author GetById(int id)
        {
            var author = Context.Authors.FirstOrDefault(a => a.Id == id);
            return author;
        }

        public List<Author> GetByName(string name)
        {
            var author = Context.Authors.Where( a => a.Name.Contains(name) );
            return author.ToList();
        }

        public void Insert(Author author)
        {
            Context.Authors.Add(author);
            Context.SaveChanges();
        }

        public void Update(int id, Author author)
        {
            var authorToBeUpdated = this.GetById(id);

            if (authorToBeUpdated == null) 
                return;

            author.Id = id;

            Context.Entry(authorToBeUpdated).CurrentValues.SetValues(author);
            Context.SaveChanges();
        }

        public void Delete(int id)
        {
            var author = GetById(id);

            Context.Authors.Remove(author);
            Context.SaveChanges();
        }
    }
}
