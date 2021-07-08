using FSL.ApiCustomIdentity.Controllers;
using FSL.ApiCustomIdentity.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSL.ApiCustomIdentity
{
    public class FakeAuthotizationService : IAuthorizationService
    {
        public async Task<BaseResult<IUser>> AuthorizeAsync(LoginUser loginUser)
        {
            var loginOrEmail = loginUser?.LoginOrEmail ?? "";
            var password = loginUser?.Password ?? "";

            var result = new BaseResult<IUser>();

            if (loginOrEmail == "fsl" && password == "12345")
            {
                result.Success = true;
                result.Message = "User authorized!";
            } 
            else
            {
                result.Success = false;
                result.Message = "User unauthorized!";
            }

            return await Task.FromResult(result);
        }
    }
}
