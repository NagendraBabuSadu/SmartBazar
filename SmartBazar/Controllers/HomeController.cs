using SmartBazar.Models.Repository;
using SmartBazar.Models.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartBazar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CategoryRepository cr = new CategoryRepository();
            List<Category> li = cr.ViewCategory();

            ViewBag.CategoryList = li;

            return View();
        }

        public ActionResult Product(int? id) //
        {
            ProductRepository pr = new ProductRepository();
            List<Product> li = pr.ViewProduct().Where(x => x.pro_fk_cat_id == id).ToList();
            ViewBag.ProductList = li;
            return View();
        }
        public ActionResult ProductDetails(int? id) //
        {
            ProductRepository pr = new ProductRepository();
            if (id == null)
            {
                ViewData["Message"] = "No product found..!";
            }
            else
            {

                ViewData["Data"] = pr.GetProductById((int)id);

            }
            return View();
        }
    }
}