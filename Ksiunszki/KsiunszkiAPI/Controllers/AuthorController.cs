using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Requests;
using KsiunszkiAPI.Entities;
using KsiunszkiAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace KsiunszkiAPI.Controllers
{
    public class AuthorController : Controller {

        private IAuthorService authorService;
        
        public AuthorController(IAuthorService service)
        {
            authorService = service;
        }
        
        [HttpGet("api/authors/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok( authorService.GetById(id) );
        }

        [HttpGet("api/authors/")]
        public IActionResult Get([FromQuery] AuthorGetRequest author)
        {
            return Ok( authorService.GetByName(author) );
        }

        [HttpPost("api/authors/")]
        public IActionResult Add([FromBody] Author author)
        {
            authorService.Insert(author);
            return Ok(author);
        }

        [HttpPut("api/authors/{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] Author author)
        {
            authorService.Update(id, author);
            return Ok(author);
        }

        [HttpDelete("api/authors/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            authorService.Delete(id);
            return Ok(true);
        }
    }
}
