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
    public class ProductController : Controller
    {
        protected ProductService _productService;

        protected CategoryService _categoryService;
        // GET: Admin/Product

        public ProductController()
        {
            _categoryService = new CategoryService();
            _productService = new ProductService();
        }

        public ActionResult Add()
        {
            List<Category> model =  _categoryService.GetActive();

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Product data)
        {
            _productService.Add(data);

            return Redirect("/Admin/Product/List");
        }

        
       
    }
}