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
    public class CategoryController : Controller
    {
        // GET: Admin/Category
        protected CategoryService _CategoryService;

        public CategoryController()
        {
            _CategoryService = new CategoryService();
        }
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Category data)
        {
            _CategoryService.Add(data);

            return Redirect("/Admin/Category/List");
        }

        public ActionResult List()
        {
            List<Category> model = _CategoryService.GetActive();

            return View(model);
        }
        public ActionResult Update(Guid id)
        {
            Category category = _CategoryService.GetByID(id);
            CategoryDTO model = new CategoryDTO();
            model.ID = category.ID;
            model.Name = category.Name;
            model.Description = category.Description;
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(CategoryDTO model)
        {
            Category category = _CategoryService.GetByID(model.ID);
            category.Name = model.Name;
            category.Description = model.Description;
            _CategoryService.Update(category);
            return Redirect("/Admin/Category/List");
        }

        public ActionResult Delete(Guid id)
        {
            _CategoryService.Remove(id);

            return Redirect("/Admin/Category/List");
        }
    }
}