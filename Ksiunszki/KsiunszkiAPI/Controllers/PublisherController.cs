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
    public class PublisherController : Controller {

        private IPublisherService publisherService;
        
        public PublisherController(IPublisherService service)
        {
            publisherService = service;
        }
        
        [HttpGet("api/publishers/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok( publisherService.GetById(id) );
        }

        [HttpGet("api/publishers/")]
        public IActionResult Get([FromQuery] string name)
        {
            return Ok( publisherService.GetByName(name) );
        }

        [HttpPost("api/publishers/")]
        public IActionResult Add([FromBody] Publisher publisher)
        {
            publisherService.Insert(publisher);
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
