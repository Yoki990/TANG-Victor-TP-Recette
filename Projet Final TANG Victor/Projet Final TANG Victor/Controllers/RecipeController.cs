using Microsoft.AspNetCore.Mvc;
using Projet_Final_TANG_Victor.Interfaces;
using Projet_Final_TANG_Victor.Models;
using Projet_Final_TANG_Victor.Services;

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
        public IActionResult TreatForm(Recipe recipe)
        {
            if (!ModelState.IsValid)
            {
                return View("RecipeForm", recipe);
            }
            _recipeService.AddRecipe(recipe);

            return RedirectToAction("DisplayRecipe");
        }

        public IActionResult RecipeForm()
        {
            return View(new Recipe());
        }              

        public IActionResult DetailRecipe(int id)
        {
            return View(_recipeService.GetRecipeDetail(id));
        }

        public IActionResult DisplayRecipe()
        {
            return View(_recipeService.GetAllRecipes());
        }

        public IActionResult DeleteRecipe(int id)
        {
            
            var recipe = _recipeService.GetAllRecipes()[id];
            _recipeService.DeleteRecipe(recipe);
            return RedirectToAction("DisplayRecipe");
        }

        /*[HttpPost]
        public IActionResult UpTreatForm(Recipe recipe)
        {
            if (!ModelState.IsValid)
            {
                return View("UpReForm", recipe);
            }
            _recipeService.AddRecipe(recipe);

            return RedirectToAction("DisplayRecipe");
        }
        public IActionResult UpReForm(int id)
        {
            return View(new Recipe());
        }*/

        /*        [HttpPost]
                public IActionResult UpdateRecipeTreatForm(Recipe recipe, int id)
                {
                    if (!ModelState.IsValid)
                    {
                        return View("RecipeForm", recipe);
                    }
                    recipe.Title = .Title;
                    recipe.Description = .Description;
                    recipe.Author = .Author;

                    return RedirectToAction("DisplayRecipe");
                }

                public IActionResult UpdateRecipeForm(int id)
                {
                    return View(new Recipe()); ///Autre chose à mettre
                }
        */





        /*[HttpPost]
        public IActionResult UpdateRecipe(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                return View("UpdateRecipe", recipe);
            }
            _recipeService.UpdateRecipe(recipe);
            return RedirectToAction("DisplayRecipe");
        }*/
    }
}
