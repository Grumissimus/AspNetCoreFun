using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boekje.Auth.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Boekje.Auth.Controllers
{
    [Route("auth")]
    public class AuthController : Controller
    {
        [HttpPost("login")]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginRequest login)
        {
            return null;
        }


    }
}
