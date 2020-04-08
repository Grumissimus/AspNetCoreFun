using API.Services;
using KsiunszkiAPI.Entities;
using System.Collections.Generic;

namespace KsiunszkiAPI.Services
{
    public interface IAuthorService : IService<Author>
    {
        List<Author> Read(string name);
    }
}
