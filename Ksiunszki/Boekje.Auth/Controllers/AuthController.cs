using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Boekje.Auth.Models;
using Boekje.Auth.Requests;
using Boekje.Auth.Responses;
using IdentityServer4.Services;
using IdentityServer4.Stores;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Boekje.Auth.Controllers
{
    [Route("auth")]
    public class AuthController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public AuthController(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _roleManager = roleManager ?? throw new ArgumentNullException(nameof(roleManager));
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest registerReq)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = new User { Email = registerReq.Email, UserName = registerReq.Username };
            var result = await _userManager.CreateAsync(user, registerReq.Password);

            if (result.Errors.Count() > 0)
            {
                return BadRequest(result.Errors);
            }
            if (await _roleManager.FindByNameAsync(Roles.User) == null)
            {
                await _roleManager.CreateAsync(new Role(Roles.User));
            }

            await _userManager.AddToRoleAsync(user, Roles.User);
            await _userManager.AddClaimAsync(user, new Claim("userName", user.UserName));
            await _userManager.AddClaimAsync(user, new Claim("email", user.Email));
            await _userManager.AddClaimAsync(user, new Claim("role", Roles.User)); 

            return Ok(new RegisterResponse { Id = user.Id, UserName = user.UserName, Email = user.Email });
        }

    }
}
