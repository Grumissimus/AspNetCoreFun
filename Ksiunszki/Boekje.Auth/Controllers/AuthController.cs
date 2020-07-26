using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Boekje.Auth.Models;
using Boekje.Auth.Requests;
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
        private readonly IIdentityServerInteractionService _interaction;
        private readonly IAuthenticationSchemeProvider _schemeProvider;
        private readonly IClientStore _clientStore;
        private readonly IEventService _events;
        private readonly IConfiguration _config;

        public AuthController(IConfiguration configuration,
            SignInManager<User> signInManager, 
            UserManager<User> userManager, 
            IIdentityServerInteractionService interaction, 
            IAuthenticationSchemeProvider schemeProvider, 
            IClientStore clientStore, 
            IEventService events)
        {
            _config = configuration;
            _signInManager = signInManager ?? throw new ArgumentNullException(nameof(signInManager));
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
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

            return validCredentials ? Ok( GenerateJwt(user) ) : null;
        }

    }
}
