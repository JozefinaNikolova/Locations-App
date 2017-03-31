namespace Locations.IdentityServer.IdentityServer
{
    using IdentityServer3.Core.Models;
    using System.Collections.Generic;

    public static class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    Enabled = true,
                    ClientName = "Locations Client",
                    ClientId = "locations",
                    Flow = Flows.Implicit,
                    RedirectUris = new List<string>
                    {
                        "http://localhost:63342/"
                    },
                    AllowAccessToAllScopes = true
                },
                new Client
                {
                    ClientName = "Web Api Client",
                    ClientId = "webapi_service",
                    Flow = Flows.ClientCredentials,

                    ClientSecrets = new List<Secret>
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = new List<string>
                    {
                        "sampleApi"
                    }
                }
            };
        }
    }
}