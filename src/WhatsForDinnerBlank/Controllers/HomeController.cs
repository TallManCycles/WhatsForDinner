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
            var model = new List<Recipes>();
            model.Add(new Recipes { Description = "Dinner 1", Rating = 5, DinnerTime = DateTime.Parse("2015-08-17 06:30:00.000") });
            model.Add(new Recipes { Description = "Dinner 2", Rating = 6, DinnerTime = DateTime.Parse("2015-08-17 06:30:00.000") });

            var result = model.OrderBy(i => i.Rating).ToList();

            return View(result);
        }

        public IActionResult Vote(object description)
        { 
            var model = new List<Recipes>();
            model.Add(new Recipes { Description = "Dinner 1", Rating = 5, DinnerTime = DateTime.Parse("2015-08-17 06:30:00.000") });
            model.Add(new Recipes { Description = "Dinner 2", Rating = 6, DinnerTime = DateTime.Parse("2015-08-17 06:30:00.000") });

            model.Where(item => item.Description == description.ToString()).First().Rating = + 1;

            return View(model);
        }
    }
}
