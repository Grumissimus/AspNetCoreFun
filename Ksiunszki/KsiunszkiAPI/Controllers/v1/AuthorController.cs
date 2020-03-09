using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KsiunszkiAPI.Domains;
using KsiunszkiAPI.Contracts;

namespace KsiunszkiAPI.Controllers
{
    public class AuthorController : Controller
    {
        public AuthorController()
        {

        }

        public IActionResult Index()
        {
            return Ok();
        }

        [HttpGet(ApiRoutes.Author.ReadAll)]
        public IActionResult ReadAll()
        {
            return Ok(new{ key = "value" });
        }
    }
}
