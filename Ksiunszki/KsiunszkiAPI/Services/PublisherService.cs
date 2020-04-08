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

        public Publisher Read(int id)
        {
            var publisher = Context.Publishers.FirstOrDefault(a => a.Id == id);
            return publisher;
        }

        public List<Publisher> Read(string name)
        {
            var author = Context.Publishers.Where( a => a.Name == name );
            return author.ToList();
        }

        public void Create(Publisher entity)
        {
            Context.Publishers.Add(entity);
            Context.SaveChanges();
        }

        public void Update(int id, Publisher publisher)
        {
            var oldPublisher = Read(id);

            if (oldPublisher == null) 
                return;

            publisher.Id = id;

            Context.Entry(oldPublisher).CurrentValues.SetValues(publisher);
            Context.SaveChanges();
        }

        public void Delete(int id)
        {
            var publisher = Read(id);

            Context.Publishers.Remove(publisher);
            Context.SaveChanges();
        }
    }
}
