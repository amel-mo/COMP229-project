using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models
{
    public class Recipe
    {
        [Required(ErrorMessage = "Please enter recipe id")]
        public int RecipeId { get; set; }

        [Required(ErrorMessage = "Please enter recipe name")]
        public string RecipeName { get; set; }

        [Required(ErrorMessage = "Please enter recipe type")]
        public string RecipeType { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string AddedBy { get; set; }
        
        [Required(ErrorMessage = "Please enter prep time")]
        public int PrepTime { get; set; }

        [Required(ErrorMessage = "Please enter cook time")]
        public int CookTime { get; set; }

        [Required(ErrorMessage = "Please enter Ingredients")]
        public string Ingredients { get; set; }

        [Required(ErrorMessage = "Please enter recipe directions")]
        public string Directions { get; set; }

        public IEnumerable<UploadImages> Images { get; set; }

        //[Required(ErrorMessage = "Please specify whether you'll attend")]
        //public bool? WillAttend { get; set; }   

    }
}
