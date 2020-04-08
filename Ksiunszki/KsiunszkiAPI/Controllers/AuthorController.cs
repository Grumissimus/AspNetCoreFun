using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Controllers;
using KsiunszkiAPI.Entities;
using KsiunszkiAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace KsiunszkiAPI.Controllers
{
    public class AuthorController : Controller, IController<Author> {

        private IAuthorService authorService;
        
        public AuthorController(IAuthorService service)
        {
            authorService = service;
        }
        
        [HttpGet("api/authors/{id}")]
        public IActionResult Read([FromRoute] int id)
        {
            return Ok( authorService.Read(id) );
        }

        [HttpGet("api/authors/{name}")]
        public IActionResult Read([FromRoute] string name)
        {
            return Ok( authorService.Read(name) );
        }

        [HttpPost("api/authors/")]
        public IActionResult Create([FromBody] Author author)
        {
            authorService.Create(author);
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
