using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DynamicDropDownListInMVC.Models;

namespace DynamicDropDownListInMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Test()
        {
            //var List = new List<string>() { "India", "Australia", "USA", "Canada", "China", "Russia" };
            

            var countries = new List<Country>()

            {
                new Country() {id = 1 , text= "India" },
                new Country() {id = 2 , text= "Australia" },
                new Country() {id = 3 , text= "USA" },
                new Country() {id = 4 , text= "Canada" },
                new Country() {id = 5 , text= "China" },
                new Country() {id = 6 , text= "Russia" },
                    
            };
            ViewBag.List = countries;

            Employee e = new Employee()
            {
                Country = 1
            };
            return View(e);

        }
        [HttpPost]
        public ActionResult Test(Employee emp) 
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("test");
            }
            var countries = new List<Country>()

            {
                new Country() {id = 1 , text= "India" },
                new Country() {id = 2 , text= "Australia" },
                new Country() {id = 3 , text= "USA" },
                new Country() {id = 4 , text= "Canada" },
                new Country() {id = 5 , text= "China" },
                new Country() {id = 6 , text= "Russia" },

            };
            ViewBag.List = countries;
            return View();
        }

        class Country
        {
            public int id { get; set; }
            public string text { get; set; }  
        }
    }
}