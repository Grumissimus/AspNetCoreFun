using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boekje.Auth.Models
{
    public static class RoleInitializer
    {
        public static async Task SeedRoleAsync(RoleManager<Role> roleManager)
        {
            string[] rolesToBeAdd =
            {
                Roles.User, Roles.Moderator, Roles.Admin
            };

            foreach (var role in rolesToBeAdd)
            {
                if(roleManager.FindByNameAsync(role).Result == null)
                {
                    await roleManager.CreateAsync(new Role(role));
                }
            }
        }
    }
}
