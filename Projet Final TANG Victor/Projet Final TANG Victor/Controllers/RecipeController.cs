using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projet_Final_TANG_Victor.Interfaces;
using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Controllers
{
    public class RecipeController : Controller
    {

        private readonly IRecipeService _recipeService;                

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpPost]
        public IActionResult TreatForm(Recipe recette)
        {
            if (!ModelState.IsValid)
            {
                return View("RecipeForm", recette);
            }
            _recipeService.AddRecipe(recette);

            return RedirectToAction("Yes");
        }

        public IActionResult RecipeForm()
        {
            return View(new Recipe());
        }

        public IActionResult GetAllRecipes()
        {
            return View(_recipeService.GetAllRecipes());
        }

        public IActionResult Yes()
        {
            return View();
        }

        /*public IActionResult UpdateRecipe(int id)
        {

        }

        public IActionResult DeleteRecipe(int id)
        {
        
        }*/
    }
}
