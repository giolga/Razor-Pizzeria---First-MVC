using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> PizzaDb = new List<PizzasModel>() {
            new PizzasModel(){ 
                PizzaName = "Margerita", 
                ImageTitle = "Margerita",
                BasePrice = 2, 
                TomatoSouce = true,
                Cheese = true,
                FinalPrice = 4 
            },
            new PizzasModel(){ 
                PizzaName = "Bolognese", 
                ImageTitle = "Bolognese",
                BasePrice = 1.3f, 
                TomatoSouce = true,
                Cheese = true,
                FinalPrice = 3.2f 
            },
            new PizzasModel(){ 
                PizzaName = "Carbonara", 
                ImageTitle = "Carbonara",
                BasePrice = 1.3f, 
                TomatoSouce = true,
                Cheese = true,
                FinalPrice = 3.2f 
            },
            new PizzasModel(){ 
                PizzaName = "Hawaiian", 
                ImageTitle = "Hawaiian",
                BasePrice = 1.3f, 
                TomatoSouce = true,
                Cheese = true,
                FinalPrice = 3.2f 
            },
            new PizzasModel(){ 
                PizzaName = "pepperoni", 
                ImageTitle = "pepperoni",
                BasePrice = 1.3f, 
                TomatoSouce = true,
                Cheese = true,
                FinalPrice = 3.2f 
            },

        };
        public void OnGet()
        {
        }
    }
}
