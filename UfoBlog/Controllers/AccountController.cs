using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using UfoBlog.Domain.Model;

namespace UfoBlog.Controllers
{
    [Route("api/[Controller]")]
    public class AccountController :ControllerBase
    {
        private readonly IDbContextFactory<BlogContext> _dbFactory;
        private readonly IDataProtectionProvider _dataProtectionProvider;

        public AccountController(IDataProtectionProvider dataProtectionProvider, IDbContextFactory<BlogContext> dbFactory)
        {
            _dbFactory = dbFactory;
            _dataProtectionProvider = dataProtectionProvider;
        }

        /// <summary>
        /// 后端登录
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Login")]
        public async Task<IActionResult> Login(string token)
        {
            var dataProtect = _dataProtectionProvider.CreateProtector("Login");
            var data = dataProtect.Unprotect(token);
            var parts = data.Split('|');

            using var context = _dbFactory.CreateDbContext();
            var user = await context.Admin.FirstOrDefaultAsync(x => !x.IsDelete && x.Uno.Equals(parts[0]) && x.PassWord.Equals(parts[1]));

            if (user != null)
            {
                #region 用户信息凭证
                AuthenticationProperties props = null;

                var claims = new List<Claim>() {
                    new Claim(ClaimTypes.Sid, user.Uno),
                    new Claim(ClaimTypes.Name,user.UserName),
                    new Claim(ClaimTypes.Uri, user.ImageUrl),
                    new Claim(ClaimTypes.Role, "Administrator")
                    };

                props = new AuthenticationProperties
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTimeOffset.UtcNow.Add(TimeSpan.FromDays(1))
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme)),
                props);
                #endregion

                return Redirect("/Admin/index");
            }
            else 
            {
                return Redirect($"/Login/{true}");
            }
        }
    }
}
