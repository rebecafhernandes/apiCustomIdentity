using FSL.ApiCustomIdentity.Models;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;

namespace FSL.ApiCustomIdentity.Controllers
{
    public interface IAuthorizationService
    {
        Task<BaseResult<IUser>> AuthorizeAsync(
            LoginUser loginUser);
    }
}
