using Boekje.Auth.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boekje.Auth.Database
{
    public class AuthContext : IdentityDbContext<User, Role, string>
    {
        public AuthContext(DbContextOptions<AuthContext> options) : base(options) { }

    }
}
