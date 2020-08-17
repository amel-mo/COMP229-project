using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipes.Models;

namespace Recipes.Controllers
{
    public class HomeController :Controller
    {
        private IRecipeRepository repository;

        public HomeController(IRecipeRepository repository)
        {
            this.repository = repository;
        }
        
        //default action method
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Welcome = hour < 12 ? "Good Morning" : "Good Afternoon";    
            return View();
        }
     
        

        public ViewResult RecipeList() => View(repository.Recipes);
        
        public ViewResult Contact()
        {
            return View();
        }

        public ViewResult ReviewRecipe(int id)
        {
            return View(repository.Recipes.Where(r=> r.RecipeId == id));
        }

        public ViewResult ViewRecipe(int id)
        {
            Recipe recipe = new Recipe
            {
                RecipeId = id
            };
            return View(repository.Recipes.Where(r => r.RecipeId == id));
        }
    }
}
