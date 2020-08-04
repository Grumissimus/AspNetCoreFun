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
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IIdentityServerInteractionService _interaction;
        private readonly IAuthenticationSchemeProvider _schemeProvider;
        private readonly IClientStore _clientStore;
        private readonly IEventService _events;
        private readonly IConfiguration _config;

        public AuthController(IConfiguration configuration,
            SignInManager<User> signInManager, 
            UserManager<User> userManager, 
            RoleManager<Role> roleManager,
            IIdentityServerInteractionService interaction, 
            IAuthenticationSchemeProvider schemeProvider, 
            IClientStore clientStore, 
            IEventService events)
        {
            _config = configuration;
            _signInManager = signInManager ?? throw new ArgumentNullException(nameof(signInManager));
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _roleManager = roleManager ?? throw new ArgumentNullException(nameof(roleManager));
            _interaction = interaction ?? throw new ArgumentNullException(nameof(interaction));
            _schemeProvider = schemeProvider ?? throw new ArgumentNullException(nameof(schemeProvider));
            _clientStore = clientStore ?? throw new ArgumentNullException(nameof(clientStore));
            _events = events ?? throw new ArgumentNullException(nameof(events));
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody]LoginRequest loginReq)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            User user = await _userManager.FindByEmailAsync(loginReq.Email);
            var validCredentials = await _userManager.CheckPasswordAsync(user, loginReq.Password);

            return Ok(validCredentials ? user : null);
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
