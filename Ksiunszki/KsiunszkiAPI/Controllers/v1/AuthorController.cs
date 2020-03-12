using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KsiunszkiAPI.Domains;
using KsiunszkiAPI.Contracts;
using KsiunszkiAPI.Controllers.v1.Requests;
using KsiunszkiAPI.Controllers.v1.Responses;
using Newtonsoft.Json;

namespace KsiunszkiAPI.Controllers
{
    public class AuthorController : Controller {

        private readonly ApiDbContext _context;

        public AuthorController(ApiDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return Ok();
        }

        [HttpGet(ApiRoutes.Author.GetById)]
        public IActionResult GetById([FromRoute] int id)
        {
            var query = from author in _context.Authors where author.AuthorId == id select author;

            var authorObj = new AuthorResponse(query.SingleOrDefault<Author>());

            var json = JsonConvert.SerializeObject(authorObj,
                Formatting.Indented,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }
            );

            return Ok(authorObj);
        }

        [HttpGet(ApiRoutes.Author.Get)]
        public IActionResult GetAuthors([FromQuery] AuthorRequest req)
        {
            return Ok(req);
        }
    }
}
