using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Boekje.ResourceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Secret()
        {
            return Ok("Hello from Secret");
        }
    }
}
