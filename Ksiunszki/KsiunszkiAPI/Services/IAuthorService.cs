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
        void Insert(Author author);
        void Update(int id, Author author);
        void Delete(int id);

    }
}
