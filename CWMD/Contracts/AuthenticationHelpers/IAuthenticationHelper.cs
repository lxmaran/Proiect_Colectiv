using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.AuthenticationHelpers
{
    public interface IAuthenticationHelper
    {
        Task<string> GetAuthorizationToken(string baseUrl, string userName, string password);
    }
}
