using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApi.Providers;

namespace WebApi
{
    public class Startup
    {
        public static OAuthAuthorizationServerOptions OAuthAuthorizationServerOptions
        {
            get; protected set;
        }

        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration config = GlobalConfiguration.Configuration;

            OAuthAuthorizationServerOptions = new OAuthAuthorizationServerOptions
            {

                TokenEndpointPath = new PathString("/Token"),
                Provider = new SimpleAuthorizationServerProvider(),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(14),
                AllowInsecureHttp = true
            };

            appBuilder.UseOAuthBearerTokens(OAuthAuthorizationServerOptions);
        }
    }
}