using KsiunszkiAPI.Entities;
using System.Collections.Generic;

namespace KsiunszkiAPI.Services
{
    public interface IAuthorService
    {
        Author GetById(int id);
        List<Author> GetByName(string name);
        void Insert(Author author);
        void Update(int id, Author author);
        void Delete(int id);

    }
}
