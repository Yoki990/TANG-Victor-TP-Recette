using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projet_Final_TANG_Victor.Interfaces;
using Projet_Final_TANG_Victor.Models;
using Projet_Final_TANG_Victor.Services;

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
            _ingredientService.AddIngredient(ingredient);

            return RedirectToAction("DisplayIngredient");
        }
        
        public IActionResult IngredientForm()
        {
            return View(new Ingredient());
        }

        public IActionResult DisplayIngredient()
        {
            return View(_ingredientService.GetAllIngredients());
        }

        [HttpPost]
        public IActionResult UpdateTreatForm(Ingredient ingredient2, int id)
        {
            if (!ModelState.IsValid)
            {
                return View("UpdateIngredientForm", ingredient2);
            }

            var ingredient = _ingredientService.GetAllIngredients()[id];

            ingredient.Name = ingredient2.Name;
            ingredient.Category = ingredient2.Category;

            _ingredientService.UpdateIngredient(ingredient, id);

            return RedirectToAction("DisplayIngredient");
        }

        public IActionResult UpdateIngredientForm(int id)
        {
            return View(_ingredientService.GetAllIngredients()[id]);
        }

        public IActionResult DeleteIngredient(int id)
        {

            var ingredient = _ingredientService.GetAllIngredients()[id];
            _ingredientService.DeleteIngredient(ingredient);
            return RedirectToAction("DisplayIngredient");
        }
    }
}
