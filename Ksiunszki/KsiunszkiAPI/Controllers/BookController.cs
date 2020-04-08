using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KsiunszkiAPI.Entities;
using KsiunszkiAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace KsiunszkiAPI.Controllers
{
    public class BookController : Controller {

        private IBookService bookService;

        public BookController(IBookService service)
        {
            bookService = service;
        }

        [HttpGet("api/books/{id}")]
        [HttpGet("api/books/id/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok(bookService.GetById(id));
        }

        [HttpGet("api/books/isbn/{isbn}")]
        public IActionResult GetByISBN([FromRoute] string isbn)
        {
            return Ok(bookService.GetByISBN(isbn));
        }

        [HttpGet("api/books/name/{name}")]
        public IActionResult GetByName([FromRoute] string name)
        {
            return Ok(bookService.GetByTitle(name) );
        }

        [HttpPost("api/books/")]
        public IActionResult Add([FromBody] Book book)
        {
            bookService.Insert(book);
            return Ok(book);
        }

        [HttpPut("api/books/{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] Book book)
        {
            bookService.Update(id, book);
            return Ok(book);
        }

        [HttpDelete("api/books/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            bookService.Delete(id);
            return Ok(true);
        }
    }
}
