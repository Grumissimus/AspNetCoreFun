using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BookController : Controller, IController<Book> {

        private IBookService bookService;

        public BookController(IBookService service)
        {
            bookService = service;
        }

        [HttpGet("api/books/{id}")]
        [HttpGet("api/books/id/{id}")]
        public IActionResult Read([FromRoute] int id)
        {
            return Ok(bookService.Read(id));
        }

        [HttpGet("api/books/isbn/{isbn}")]
        public IActionResult ReadByISBN([FromRoute] string isbn)
        {
            return Ok(bookService.ReadByISBN(isbn));
        }

        [HttpGet("api/books/name/{name}")]
        public IActionResult ReadByName([FromRoute] string name)
        {
            return Ok(bookService.Read(name) );
        }

        [HttpPost("api/books/")]
        public IActionResult Create([FromBody] Book book)
        {
            bookService.Create(book);
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
