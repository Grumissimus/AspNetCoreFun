using KsiunszkiAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Services
{
    public class PublisherService : IPublisherService
    {
        private ApiContext Context { get; set; }

        public PublisherService(ApiContext context)
        {
            Context = context;
        }

        public Publisher GetById(int id)
        {
            var publisher = Context.Publishers.FirstOrDefault(a => a.Id == id);
            return publisher;
        }

        public List<Publisher> GetByName(string name)
        {
            var author = Context.Publishers.Where( a => a.Name == name );
            return author.ToList();
        }

        public void Insert(Publisher publisher)
        {
            Context.Publishers.Add(publisher);
            Context.SaveChanges();
        }

        public void Update(int id, Publisher publisher)
        {
            var oldPublisher = GetById(id);

            if (oldPublisher == null) 
                return;

            publisher.Id = id;

            Context.Entry(oldPublisher).CurrentValues.SetValues(publisher);
            Context.SaveChanges();
        }

        public void Delete(int id)
        {
            var publisher = GetById(id);

            Context.Publishers.Remove(publisher);
            Context.SaveChanges();
        }
    }
}
