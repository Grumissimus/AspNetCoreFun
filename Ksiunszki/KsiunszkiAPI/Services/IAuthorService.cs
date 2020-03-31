using API.Requests;
using KsiunszkiAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Services
{
    public interface IAuthorService
    {
        Author GetById(int id);
        List<Author> GetByName(AuthorGetRequest authorReq);
        void Insert(Author author);
        void Update(int id, Author author);
        void Delete(int id);

    }
}
