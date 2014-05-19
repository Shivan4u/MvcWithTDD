using MvcWithTDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWithTDD.Controllers
{
    public class HomeController : Controller
    {
        private IRepositry _repositry;

        public HomeController(IRepositry repositry)
        {
            _repositry = repositry;
        }


        public HomeController()
        {
            _repositry = new ProductRepositry();
        }


        public ViewResult Index()
        {
            var products = _repositry.GetProducts();
            return View(products);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}