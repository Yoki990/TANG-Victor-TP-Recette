using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projet_Final_TANG_Victor.Interfaces;
using Projet_Final_TANG_Victor.Models;

namespace Projet_Final_TANG_Victor.Controllers
{
    public class RecetteController : Controller
    {

        private readonly IRecetteService _recetteService;                

        public RecetteController(IRecetteService recetteService)
        {
            _recetteService = recetteService;
        }

        [HttpPost]
        public IActionResult TreatForm(Recette recette)
        {
            if (!ModelState.IsValid)
            {
                return View("", recette);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RecipeForm()
        {
            return View(new Recette());
        }
    }
}
