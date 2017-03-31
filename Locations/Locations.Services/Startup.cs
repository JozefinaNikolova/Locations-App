namespace Locations.Services
{
    using IdentityServer3.AccessTokenValidation;
    using Owin;
    using System.Web.Http;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseIdentityServerBearerTokenAuthentication(new IdentityServerBearerTokenAuthenticationOptions
            {
                Authority = "https://localhost:44335/identity",
                RequiredScopes = new[] { "sampleApi" }
            });

            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();

            app.UseWebApi(config);
        }
    }
}