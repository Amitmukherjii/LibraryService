using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using LibraryService.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LibraryService.Controllers
{
    [Route("api/[controller]")]
  
    [ApiController]
    public class AccountController : ControllerBase
    {
        [EnableCors]
        [HttpPost]
        [AllowAnonymous]
        [Route("GetUserAuthentication")]
        public AccountModel GetUserAuthentication(string username, string password)
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