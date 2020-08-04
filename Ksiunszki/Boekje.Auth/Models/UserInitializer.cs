using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekje.Auth.Models
{
    public static class UserInitializer
    {
        public static async Task SeedUsersAsync(UserManager<User> userManager)
        {
            if( await userManager.FindByNameAsync("root") == null )
            {
                var root = new User();
                root.UserName = "root";
                root.Email = "root@localhost";

                var result = await userManager.CreateAsync(root, "r00t@tiON");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(root, Roles.Admin);
                }
            }
        }
    }
}
