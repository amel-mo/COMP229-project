using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Recipes.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Recipes.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IRecipeRepository repository;

        public AdminController(IRecipeRepository repository)
        {
            this.repository = repository;
        }
        
        public ViewResult Index()
        {
            return View(repository.Recipes);
        }
       
        [HttpGet]
        public ViewResult AddRecipe()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRecipe(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                repository.SaveRecipe(recipe);
                TempData["message"] = $"The recipe of {recipe.RecipeName} has been added!";
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }

        public ViewResult Edit(int id) =>
           View(repository.Recipes
               .FirstOrDefault(r => r.RecipeId == id));

        [HttpPost]
        public IActionResult Edit(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                repository.SaveRecipe(recipe);
                TempData["message"] = $"The recipe of {recipe.RecipeName} has been saved!";
                return RedirectToAction("Index");
            }
            else
            {
                return View(recipe);
            }
        }

        public ViewResult Create() => View("Edit", new Recipe());

        [HttpPost]
        public IActionResult Delete(int recipeId)
        {
            Recipe deleteRecipe = repository.DeleteRecipe(recipeId);

            if (deleteRecipe != null)
            {
                TempData["message"] = $"The recipe of {deleteRecipe.RecipeName} was deleted!";
            }

            return RedirectToAction("Index");
        }

        public ViewResult AdminViewRecipe(int id)
        {
            Recipe recipe = new Recipe
            {
                RecipeId = id
            };
            return View(repository.Recipes.Where(r => r.RecipeId == id));
        }
    }
}
