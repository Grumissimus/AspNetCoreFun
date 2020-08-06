using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boekje.Auth.Config
{
    public class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret(JwtConstants.Secret.Sha256())
                    },
                    AllowedScopes = { "BoekjeResource" }
                },
                new Client 
                {
                    ClientId = "angular_spa",
                    ClientName = "Angular SPA",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets =
                    {
                        new Secret(JwtConstants.Secret.Sha256())
                    },
                    AllowedScopes = { "BoekjeResource", "api.read", "api.write" },
                    //RedirectUris = { "http://localhost:4200/auth-callback" },
                    //PostLogoutRedirectUris = { "http://localhost:4200/" },
                    //AllowedCorsOrigins = { "http://localhost:4200" },
                    AccessTokenLifetime = 3600,
                }
            };
        }
    }
}
