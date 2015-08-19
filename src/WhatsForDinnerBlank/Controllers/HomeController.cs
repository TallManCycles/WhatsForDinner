using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WhatsForDinnerBlank.Model;

namespace WhatsForDinnerBlank.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Login";
            ViewData["Message"] = "Welcome, \n please use your first and last name to login to your household.";

            //var model2 = new List<Recipes>();
            //model2.Add(new Recipes { Description = "Dinner 1", Rating = 5, DinnerTime = DateTime.Parse("2015-08-17 06:30:00.000") });
            //model2.Add(new Recipes { Description = "Dinner 2", Rating = 6, DinnerTime = DateTime.Parse("2015-08-17 06:30:00.000") });

            //var result = model2.OrderBy(i => i.Rating).ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Submit()
        {
            var model = new List<User>();

            model.Add(new User { FirstName = "Aaron", LastName = "Day", Email = "Aaronday@live.com.au" });
            model.Add(new User { FirstName = "Adele", LastName = "Rose", Email = "adelerose31@hotmail.com" });

            // model.Where(item => item.Description == description.ToString()).First().Rating = + 1;

            return View(model);
        }
    }
}
