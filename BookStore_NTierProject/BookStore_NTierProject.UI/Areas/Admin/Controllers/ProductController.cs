using BookStore_NTierProject.Model.Option;
using BookStore_NTierProject.Service.Option;
using BookStore_NTierProject.UI.Areas.Admin.Models.DTO;
using BookStore_NTierProject.UI.Areas.Admin.Models.VM;
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
            AddProductVM model = new AddProductVM();
            model.Categories=_categoryService.GetActive();
            

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Product data)
        {
            _productService.Add(data);

            return Redirect("/Admin/Product/List");
        }

        public ActionResult List()
        {
            List<Product> model = _productService.GetActive();

            return View(model);
        }

        public ActionResult Update(Guid id)
        {
            Product product = _productService.GetByID(id);
            AddProductVM model = new AddProductVM();
            model.Products.ID = product.ID;
            model.Products.Name = product.Name;
            model.Products.Author = product.Author;
            model.Products.CategoryID = product.CategoryID;
            model.Products.Price = product.Price;
            model.Products.Quantity = product.Quantity;
            model.Products.UnitInStock = product.UnitInStock;
            model.Categories = _categoryService.GetActive();

            return View(model);
        }

        [HttpPost]
        public ActionResult Update(ProductDTO data)
        {
            Product product = _productService.GetByID(data.ID);
            product.Name = data.Name;
            product.Author = data.Author;
            product.Price = data.Price;
            product.Quantity = data.Quantity;
            product.UnitInStock = data.UnitInStock;
            product.CategoryID = data.CategoryID;

            _productService.Update(product);

            return Redirect("/Admin/Product/List");

        }

        public ActionResult Delete(Guid id)
        {
            _productService.Remove(id);
            return Redirect("/Admin/Product/List");
        }

    }
}