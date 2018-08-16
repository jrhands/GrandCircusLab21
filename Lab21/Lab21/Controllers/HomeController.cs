using Lab21.Content;
using Lab21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab21.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            var coffeeOptions = new List<SelectListItem>
            {
                new SelectListItem { Text = "Select an option", Value = null, Selected = true }
            };
            foreach (MenuItems menuItem in Enum.GetValues(typeof(MenuItems)))
            {
                coffeeOptions.Add(new SelectListItem { Text = menuItem.ToString().Replace("_", " "), Value = menuItem.ToString().Replace("_", " ") });
            }
            ViewBag.CoffeeOptionsEnum = coffeeOptions;
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(AddUserViewModel model)
        {
            return View(model);
        }
    }
}