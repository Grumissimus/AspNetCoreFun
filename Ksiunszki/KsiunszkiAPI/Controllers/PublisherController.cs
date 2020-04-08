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
    public class PublisherController : Controller, IController<Publisher> {

        private IPublisherService publisherService;
        
        public PublisherController(IPublisherService service)
        {
            publisherService = service;
        }
        
        [HttpGet("api/publishers/{id}")]
        public IActionResult Read([FromRoute] int id)
        {
            return Ok( publisherService.Read(id) );
        }

        [HttpGet("api/publishers/")]
        public IActionResult Read([FromQuery] string name)
        {
            return Ok( publisherService.Read(name) );
        }

        [HttpPost("api/publishers/")]
        public IActionResult Create([FromBody] Publisher publisher)
        {
            publisherService.Create(publisher);
            return Ok(publisher);
        }

        [HttpPut("api/publishers/{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] Publisher publisher)
        {
            publisherService.Update(id, publisher);
            return Ok(publisher);
        }

        [HttpDelete("api/publishers/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            publisherService.Delete(id);
            return Ok(true);
        }
    }
}
