using KsiunszkiAPI.Controllers.v1.Requests;
using KsiunszkiAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly ApiDbContext _context;
        public AuthorService(ApiDbContext context)
        {
            _context = context;
        }

        public List<Author> GetAuthors(AuthorRequest authorGetRequest)
        {
            return null;
        }

        public Author GetAuthorById(int id)
        {
            return null;
        }
    }
}
