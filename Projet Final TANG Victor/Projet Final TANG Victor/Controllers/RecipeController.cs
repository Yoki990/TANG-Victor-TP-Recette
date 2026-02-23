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

        [HttpPost]
        public IActionResult UpdateTreatForm(Recipe recipe2, int id)
        {
            if (!ModelState.IsValid)
            {
                return View("UpdateRecipeForm", recipe2);
            }

            var recipe = _recipeService.GetAllRecipes()[id];

            recipe.Title = recipe2.Title;
            recipe.Description = recipe2.Description;
            recipe.Instruction = recipe2.Instruction;
            recipe.Author = recipe2.Author;

            _recipeService.UpdateRecipe(recipe, id);

            return RedirectToAction("DisplayRecipe");
        }
        public IActionResult UpdateRecipeForm(int id)
        {
            return View(_recipeService.GetAllRecipes()[id]);
        }



        public IActionResult DeleteRecipe(int id)
        {
            
            var recipe = _recipeService.GetAllRecipes()[id];
            _recipeService.DeleteRecipe(recipe);
            return RedirectToAction("DisplayRecipe");
        }
    }
}
