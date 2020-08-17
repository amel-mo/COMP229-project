using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models
{
    public class EFRecipeRepository : IRecipeRepository
    {
        private ApplicationDbContext context;

        public EFRecipeRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Recipe> Recipes => context.Recipes.Include(recipe => recipe.Images);

        public void SaveRecipe(Recipe recipe)
        {
            if (recipe.RecipeId == 0)
            {
                context.Recipes.Add(recipe);
            }
            else
            {
                Recipe recipeEntry = context.Recipes
                    .FirstOrDefault(p => p.RecipeId == recipe.RecipeId);

                if (recipeEntry != null)
                {
                    recipeEntry.RecipeName = recipe.RecipeName;
                    recipeEntry.RecipeType = recipe.RecipeType;
                    recipeEntry.AddedBy = recipe.AddedBy;
                    recipeEntry.PrepTime = recipe.PrepTime;
                    recipeEntry.CookTime = recipe.CookTime;
                    recipeEntry.Ingredients = recipe.Ingredients;
                    recipeEntry.Directions = recipe.Directions;
                }
            }
            context.SaveChanges();
        }

        public Recipe DeleteRecipe(int id)
        {
            Recipe recipeEntry = context.Recipes
                .FirstOrDefault(r => r.RecipeId == id);

            if (recipeEntry != null)
            {
                context.Recipes.Remove(recipeEntry);
                context.SaveChanges();
            }

            return recipeEntry;
        }

        public void AddUploadedImage(UploadImages uploadImages)
        {
            context.UploadImages.Add(uploadImages);
            context.SaveChanges();
        }
    }
}
