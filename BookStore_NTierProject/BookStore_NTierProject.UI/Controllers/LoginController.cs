using BookStore_NTierProject.Model.Option;
using BookStore_NTierProject.Service.Option;
using BookStore_NTierProject.UI.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BookStore_NTierProject.UI.Controllers
{
    public class LoginController : Controller
    {
        AppUserService _appUserService;

        public LoginController()
        {
            _appUserService = new AppUserService();
        }

        // GET: Login
        public ActionResult Login()
        {
            if(HttpContext.User.Identity.IsAuthenticated)
            {
                AppUser user = _appUserService.FindByUserName(User.Identity.Name);
                if(user.Role == Core.Enum.Role.Admin)
                {
                    return RedirectToAction("AdminHomeIndex", "Home");
                }
                else if(user.Role==Core.Enum.Role.Member)
                {
                    return RedirectToAction("MemberHomeIndex", "Home");
                }
            }
            return View();
        }
        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Login(LoginVM credentials)
        {
            if(_appUserService.CheckCredentials(credentials.UserName,credentials.Password))
            {
                AppUser user = _appUserService.FindByUserName(credentials.UserName);

                string cookie = user.UserName;
                FormsAuthentication.SetAuthCookie(cookie, true);

                if(user.Role==Core.Enum.Role.Admin)
                {
                    return Redirect("/Admin/Home/AdminHomeIndex");
                }
                else if(user.Role==Core.Enum.Role.Member)
                {
                    return Redirect("/Member/Home/MemberHomeIndex");
                }
            }
            else
            {
                ViewData["error"] = "Wrong User Name and Password!!..";
            }

            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return Redirect("/Login/Login");
        }

    }
}