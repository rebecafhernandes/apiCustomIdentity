using FSL.ApiCustomIdentity.Models;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;

namespace FSL.ApiCustomIdentity.Controllers
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResult> AuthenticateAsync(
            IUser user);
    }
}
