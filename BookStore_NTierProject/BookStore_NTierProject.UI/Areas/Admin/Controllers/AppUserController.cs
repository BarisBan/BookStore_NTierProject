using BookStore_NTierProject.Model.Option;
using BookStore_NTierProject.Service.Option;
using BookStore_NTierProject.UI.Areas.Admin.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore_NTierProject.UI.Areas.Admin.Controllers
{
    public class AppUserController : Controller
    {
        // GET: Admin/AppUser
        AppUserService _appUserService;

        public AppUserController()
        {
            _appUserService = new AppUserService();
        }
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(AppUser data)
        {
            _appUserService.Add(data);

            return Redirect("/Admin/AppUser/List");
        }
        public ActionResult List()
        {
            List<AppUser> model = _appUserService.GetActive();
            return View(model);
        }

        public ActionResult Update(Guid id)
        {
            AppUser user = _appUserService.GetByID(id);
            AppUserDTO model = new AppUserDTO();

            model.ID = user.ID;
            model.FirstName = user.FirstName;
            model.LastName = user.LastName;
            model.UserName = user.UserName;
            model.Password = user.Password;
            model.Email = user.Email;
            model.Address = user.Address;
            model.Birthdate = user.Birthdate;
            model.Role = user.Role;
            model.Gender = user.Gender;
            model.PhoneNumber = user.PhoneNumber;

            return View(model);

        }

        [HttpPost]
        public ActionResult Update(AppUserDTO data)
        {
            AppUser user = _appUserService.GetByID(data.ID);
            user.UserName = data.UserName;
            user.FirstName = data.FirstName;
            user.LastName = data.LastName;
            user.Password = data.Password;
            user.PhoneNumber = data.PhoneNumber;
            user.Birthdate = data.Birthdate;
            user.Address = data.Address;
            user.Email = data.Email;
            user.Gender = data.Gender;
            user.Role = data.Role;
            _appUserService.Update(user);
            return Redirect("/Admin/AppUser/List");
        }

        public ActionResult Delete(Guid id)
        {
            _appUserService.Remove(id);
            return Redirect("/Admin/AppUser/List");

        }
    }
}