using API.Services;
using API.Models;
using System.Collections.Generic;

namespace API.Services
{
    public interface IAuthorService : IService<Author>
    {
        List<Author> Read(string name);
    }
}
