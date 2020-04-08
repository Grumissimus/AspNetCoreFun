using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpGet("api/authors/{name}")]
        public IActionResult Get([FromRoute] string name)
        {
            return Ok( authorService.GetByName(name) );
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
