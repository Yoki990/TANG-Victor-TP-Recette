using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projet_Final_TANG_Victor.Interfaces;
using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Controllers
{
    public class IngredientController : Controller
    {
        private readonly IIngredientService _ingredientService;

        public IngredientController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        [HttpPost]
        public IActionResult TreatForm(Ingredient ingredient)
        {
            if (!ModelState.IsValid)
            {
                return View("IngredientForm", ingredient);
            }
            return RedirectToAction("Yes");
        }

        public IActionResult IngredientForm()
        {
            return View(new Ingredient());
        }

        public IActionResult Yes()
        {
            return View();
        }
    }
}
