using Microsoft.AspNetCore.Mvc;
using PPWebApp.Models;

namespace PPWebApp.Controllers
{
    public class PizzaController : Controller
    {
        static List<Pizza> pizzas = new List<Pizza>
        {
            new Pizza() { Id = 1, Name = "Margherita",Price = 10999 },
            new Pizza() { Id = 2, Name = "Pepperoni", Price = 12999 },
            new Pizza() { Id = 3, Name = "Vegetarian", Price = 11999 }
        };
        public IActionResult Index()
        {
            return View(pizzas);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Pizza());
        }
        [HttpPost]
        public IActionResult Create(Pizza model)
        {
            if (ModelState.IsValid)
            {
                pizzas.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
