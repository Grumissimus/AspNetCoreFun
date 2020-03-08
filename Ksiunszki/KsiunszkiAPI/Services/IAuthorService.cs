using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KsiunszkiAPI.Domains;
using KsiunszkiAPI.Controllers.v1.Requests;

namespace KsiunszkiAPI.Services
{
    interface IAuthorService
    {   
        public List<Author> GetAuthors(AuthorRequest authorGetRequest);
    }
}
