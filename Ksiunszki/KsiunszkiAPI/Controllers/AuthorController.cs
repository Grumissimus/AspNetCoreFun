using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KsiunszkiAPI.Contracts;

namespace KsiunszkiAPI.Controllers
{
    public class AuthorController : Controller {

        [HttpGet(ApiRoutes.Author.GetById)]
        public IActionResult GetById()
        {
            return Ok();
        }
    }
}
