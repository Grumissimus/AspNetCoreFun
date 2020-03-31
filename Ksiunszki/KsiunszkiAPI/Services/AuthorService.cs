using KsiunszkiAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Services
{
    public class AuthorService : IAuthorService
    {
        private KsiunszkiContext Context { get; set; }

        public AuthorService(KsiunszkiContext context)
        {
            Context = context;
        }

        public AuthorService()
        {
        }

        public Author GetById(int id)
        {
            var author = Context.Authors.FirstOrDefault(a => a.Id == id);
            return author;
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
