using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using LibraryService.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LibraryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        //[Route("api/User/Register")]
        //[HttpPost]
        //[AllowAnonymous]
        //public IdentityResult Register(AccountModel model)
        //{
        //    var userStore = new UserStore<ApplicationUser>(new ApplicationDbContext());
        //    var manager = new UserManager<ApplicationUser>(userStore);
        //    var user = new ApplicationUser() { UserName = model.UserName, Email = model.Email };
        //    user.FirstName = model.FirstName;
        //    user.LastName = model.LastName;
        //    manager.PasswordValidator = new PasswordValidator
        //    {
        //        RequiredLength = 3
        //    };
        //    IdentityResult result = manager.Create(user, model.Password);
        //    return result;
        //}

        [HttpGet]
        [Route("api/GetUserClaims")]
        public AccountModel GetUserClaims()
        {
            var identityClaims = (ClaimsIdentity)User.Identity;
            IEnumerable<Claim> claims = identityClaims.Claims;
            AccountModel model = new AccountModel()
            {
                UserName = identityClaims.FindFirst("Username").Value,
                Email = identityClaims.FindFirst("Email").Value,
                FirstName = identityClaims.FindFirst("FirstName").Value,
                LastName = identityClaims.FindFirst("LastName").Value,
                LoggedOn = identityClaims.FindFirst("LoggedOn").Value
            };
            return model;
        }

    }
}