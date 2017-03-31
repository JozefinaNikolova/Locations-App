namespace Locations.IdentityServer.IdentityServer
{
    using IdentityServer3.Core;
    using IdentityServer3.Core.Services.InMemory;
    using System.Collections.Generic;
    using System.Security.Claims;

    public static class Users
    {
        public static List<InMemoryUser> Get()
        {
            return new List<InMemoryUser>
            {
                new InMemoryUser
                {
                    Username = "jozi",
                    Password = "123456",
                    Subject = "1",

                    Claims = new []
                    {
                        new Claim(Constants.ClaimTypes.GivenName, "Jozefina"),
                        new Claim(Constants.ClaimTypes.FamilyName, "Nikolova")
                    }
                }
            };
        }
    }
}