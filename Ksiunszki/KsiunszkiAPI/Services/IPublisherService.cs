using KsiunszkiAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Services
{
    public interface IPublisherService
    {
        Publisher GetById(int id);
        List<Publisher> GetByName(string name);
        void Insert(Publisher publisher);
        void Update(int id, Publisher publisher);
        void Delete(int id);
    }
}
