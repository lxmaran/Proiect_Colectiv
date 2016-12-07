using Microsoft.Owin.Security.OAuth;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace WebApi.Providers
{
    internal class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var userService = new UserService();

            var user = userService.FindUser(context.UserName, context.Password);
            if (user == null)
            {
                context.SetError("Invalid Login", "The username or password is incorrect.");
                return;
            }

            var userRoleIds = userService.GetUserRoles(user.Id);
            var userRoleIdsString = string.Join(", ", userRoleIds);

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim("userRoleIds", userRoleIdsString));
            identity.AddClaim(new Claim("userId", user.Id.ToString()));
            identity.AddClaim(new Claim("userName", user.UserName));
            identity.AddClaim(new Claim("createdDate", DateTime.Now.ToString()));
            context.Validated(identity);
        }
    }
}