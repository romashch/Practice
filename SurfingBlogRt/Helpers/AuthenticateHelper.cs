using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SurfClub.Helpers
{
    public class AuthenticateHelper
    {
        public static async Task Authenticate(int userId,string userName, bool rememberMe, HttpContext httpContext)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
                new Claim(ClaimTypes.Name, userName)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie",
                ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            var props = new AuthenticationProperties();
            if (rememberMe)
            {
                props.IsPersistent = rememberMe;
                props.ExpiresUtc = DateTime.Now.AddHours(2);
            }
            else
            {

                props.ExpiresUtc = DateTime.Now.AddMinutes(30);
            }
            // установка аутентификационных куки
            await httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id), props);
        }
    }
}
