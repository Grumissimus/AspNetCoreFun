using API.Services;
using KsiunszkiAPI.Entities;
using System.Collections.Generic;

namespace KsiunszkiAPI.Services
{
    public interface IPublisherService : IService<Publisher>
    {
        List<Publisher> Read(string name);
    }
}
