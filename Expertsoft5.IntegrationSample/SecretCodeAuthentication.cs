using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text.Encodings.Web;

namespace Expertsoft5.IntegrationSample
{
    public class SecretCodeAuthentication : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        public SecretCodeAuthentication(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock
            ) : base(options, logger, encoder, clock)
        {
        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            var authHeader = Request.Headers["Authorization"].ToString();

            if (authHeader == "YOUR_SECRET_CODE")
            {
                var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity("SecretCodeAuthentication"));

                return Task.FromResult(AuthenticateResult.Success(new AuthenticationTicket(claimsPrincipal, Scheme.Name)));
            }
            else
            {
                Response.StatusCode = 401;

                return Task.FromResult(AuthenticateResult.Fail("Invalid Authorization Header"));
            }
        }
    }
}
