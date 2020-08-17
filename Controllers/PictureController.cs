
using Recipes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Controllers
{
    public class PictureController : Controller
    {
        private IRecipeRepository repository;
        public PictureController(IRecipeRepository repo)
        {
            repository = repo;
        }
        [HttpGet]
        public IActionResult Picture(int id)
        {
            return View("Image", new UploadImages
            {
                RecipeId = id
            });
        }

        [HttpPost]
        public IActionResult Picture(UploadImages upimage, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                using (var ms = new MemoryStream())
                {
                    image.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    upimage.Image = fileBytes;
                }

                repository.AddUploadedImage(upimage);
                TempData["message"] = $"The image has been uploaded!";
                return RedirectToAction("Index", "Admin");
            }
            ModelState.AddModelError("", "Invalid file Extension");
            return View("Image", image);
        }
    }
}