using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boekje.Auth.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Boekje.Auth.Controllers
{
    [Route("role")]
    public class RoleController : Controller
    {
        private readonly RoleManager<Role> _roleManager;

        public RoleController(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager ?? throw new ArgumentNullException(nameof(roleManager));
        }

        [HttpPost("create/{name}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(string name)
        {
            if( await _roleManager.FindByNameAsync(name) != null)
            {
                return NoContent();
            }

            var newRole = await _roleManager.CreateAsync(new Role(name));

            return Created(name, newRole);
        }
    }
}
