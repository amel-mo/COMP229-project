using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.Recipes.Any())
            {
                context.Recipes.AddRange(
                    new Recipe
                    {
                        RecipeName = "Salmon Baked In Foil",
                        RecipeType = "Sea Food",
                        AddedBy = "Giada De Laurentiss",
                        PrepTime = 15,
                        CookTime = 25,
                        Ingredients = "* 4 (5 ounces each) salmon fillets" +
                         "* 2 teaspoons olive oil plus 2 tablespoons" +
                         "* Salt and freshly ground black pepper" +
                         "* 3 tomatoes, chopped, or 1(14 - ounce) can chopped tomatoes, drained" +
                         "* 2 chopped shallots" +
                         "* 2 tablespoons fresh lemon juice" +
                         "* 1 teaspoon dried oregano" +
                         "* 1 teaspoon dried thyme",
                        Directions = "* 1-Preheat the oven to 400 degrees F." +
                         "* 2-Sprinkle salmon with 2 teaspoons olive oil, salt, and pepper.Stir the tomatoes, shallots, 2 tablespoons of oil, " +
                         "lemon juice, oregano, thyme, salt and pepper in a medium bowl to blend." +
                         "* 3-Place a salmon fillet, oiled side down, atop a sheet of foil.Wrap the ends of the foil to form a spiral" +
                         "shape.Spoon the tomato mixture over the salmon.Fold the sides of the foil over the fish and tomato mixture, " +
                         "covering completely; seal the packets closed. Place the foil packet on a heavy large baking sheet. Repeat until " +
                         "all of the salmon have been individually wrapped in foil and placed on the baking sheet.Bake until the salmon is" +
                         " just cooked through, about 25 minutes.Using a large metal spatula, transfer the foil packets to plates and serve"
                    },
                    new Recipe
                    {
                        RecipeName = "Garden Vegetable Soup",
                        RecipeType = "Vegetable",
                        AddedBy = "Alton Brown",
                        PrepTime = 40,
                        CookTime = 45,
                        Ingredients = "* 4 tablespoons olive oil" +
                        "* 2 cups chopped leeks, white part only(from approximately 3 medium leeks)" +
                        "* 2 tablespoons finely minced garlic" +
                        "* Kosher salt" +
                        "* 2 cups carrots, peeled and chopped into rounds(approximately 2 medium)" +
                        "* 2 cups peeled and diced potatoes" +
                        "* 2 cups fresh green beans, broken or cut into 3 / 4 - inch pieces" +
                        "* 2 quarts chicken or vegetable broth" +
                        "* 4 cups peeled, seeded, and chopped tomatoes" +
                        "* 2 ears corn, kernels removed" +
                        "* 1 / 2 teaspoon freshly ground black pepper" +
                        "* 1 / 4 cup packed, chopped fresh parsley leaves" +
                        "* 1 to 2 teaspoons freshly squeezed lemon juice",
                        Directions = "* 1-Heat the olive oil in large, heavy - bottomed stockpot over medium - low heat.Once hot, add the leeks, garlic," +
                        "and a pinch of salt and sweat until they begin to soften, approximately 7 to 8 minutes.Add the carrots, potatoes," +
                        " and green beans and continue to cook for 4 to 5 more minutes, stirring occasionally." +
                        "* 2-Add the stock, increase the heat to high, and bring to a simmer.Once simmering, add the tomatoes, " +
                        "corn kernels, and pepper.Reduce the heat to low, cover, and cook until the vegetables are fork tender, " +
                        "approximately 25 to 30 minutes.Remove from heat and add the parsley and lemon juice.Season, to taste, with" +
                        "salt.Serve immediately."
                    },
                    new Recipe
                    {
                        RecipeName = "Chicken And Broccoli Stir-Fry",
                        RecipeType = "Chicken",
                        AddedBy = "Food Network Kitchen",
                        PrepTime = 5,
                        CookTime = 15,
                        Ingredients = "* 1 pound chicken breast " +
                         "(about 2 breasts), cubed" +
                         "* 3 scallions, whites only, thinly sliced on a bias" +
                         "* 2 tablespoons sugar" +
                         "* 1 tablespoon dark sesame oil" +
                         "* 1 tablespoon dry sherry" +
                         "* 1 tablespoon soy sauce" +
                         "* 2 cloves garlic, minced" +
                         "* 1 - inch piece peeled fresh ginger, minced" +
                         "* 1 tablespoon, plus 1 teaspoon cornstarch" +
                         "* Salt and freshly ground black pepper" +
                         "* About 1 / 3 cup water" +
                         "* 3 tablespoons vegetable oil" +
                         "* 5 to 6 cups broccoli florets and sliced stalks(keep the 2 cuts separate)" +
                         "* 3 / 4 to 1 teaspoon red chili flakes, optional" +
                         "* 1 tablespoon hoisin sauce" +
                         "* toasted sesame seeds, for serving, optional" +
                         "* Jasmine rice, for serving, optional",
                        Directions = "* 1-In a medium bowl, toss the chicken with the scallion whites, sugar, sesame oil, " +
                         "sherry, soy sauce, about half the garlic, half the ginger, 1 teaspoon of the cornstarch and 1 teaspoon salt.Marinate at" +
                         " room temperature for 15 minutes.Mix the remaining 1 tablespoon cornstarch with 1 / 3 cup water in a small bowl and " +
                         "reserve." +
                         "* 2-Heat a large nonstick skillet over high heat.Add 1 tablespoon of the vegetable oil and heat.Add the broccoli stems " +
                         "and stir - fry for 30 seconds.Add the florets and the remaining garlic and ginger, 2 tablespoons water, 1 / 4 teaspoon" +
                         " salt and some black pepper.Stir - fry until the broccoli is bright green but still crisp, about 2 minutes.Transfer to" +
                         " a plate." +
                         "* 3-Get the skillet good and hot again, and then heat the remaining 2 tablespoons vegetable oil.Add the chicken and red " +
                         "pepper flakes if using.Stir - fry until the chicken loses its raw color and gets a little brown, about 3 minutes.Add the" +
                         " hoisin sauce, return the broccoli to the pan and toss to heat through.Stir in the reserved cornstarch mixture and bring" +
                         " to a boil to thicken.Add more water if need to thin the sauce, if necessary.Taste and season with salt and pepper, " +
                         "if you like." +
                         "* 4-Mound the stir - fry on a serving platter or divide among 4 plates and garnish with sesame seeds; serve with rice."
                    },
                    new Recipe
                    {
                        RecipeName = "Quinoa Salad",
                        RecipeType = "Vegetable",
                        AddedBy = "Susan Feniger",
                        PrepTime = 20,
                        CookTime = 20,
                        Ingredients = "* 12 cups water" +
                         "* 1 1 / 2 cups quinoa, rinsed" +
                         "* 5 pickling cucumbers, peeled, ends trimmed, and cut into 1 / 4 - inch cubes" +
                         "* 1 small red onion, cut into 1 / 4 - inch cubes" +
                         "* 1 large tomato, cored, seeded, and diced" +
                         "* 1 bunch Italian parsley leaves, chopped" +
                         "* 2 bunches mint leaves, chopped" +
                         "* 1 / 2 cup extra - virgin olive oil" +
                         "* 1 / 4 cup red wine vinegar" +
                         "* 1 lemon, juiced" +
                         "* 1 1 / 2 teaspoons salt" +
                         "* 3 / 4 teaspoon freshly ground black pepper" +
                         "* 4 heads endive, trimmed and separated into individual spears" +
                         "* 1 avocado, peeled, seeded and diced, for garnish",
                        Directions = "* 1-Bring the water to a boil in a large saucepan.Add the quinoa, " +
                         "stir once, and return to a boil. Cook uncovered, over medium heat for 12 minutes.Strain and rinse well with cold " +
                         "water, shaking the sieve well to remove all moisture. When dry, transfer the quinoa to a large bowl.Add the cucumbers, " +
                         "onion, tomato, parsley, mint, olive oil, vinegar, lemon juice, salt, and pepper and toss well.Spoon onto endive spears," +
                         " top with avocado, and serve." 
                    },
                    new Recipe
                    {
                        RecipeName = "Breakfast Casserole",
                        RecipeType = "Vegetable",
                        AddedBy = "Food Network Kitchen",
                        PrepTime = 15,
                        CookTime = 55,
                        Ingredients = "* 8 oz spicy or sweet turkey sausage " +
                         "links, casings removed, meat crumbled" +
                         "* 2 scallions, sliced" +
                         "* 6 large eggs and 6 large egg whites" +
                         "* 1 ¾ cups 1 % milk" +
                         "* Kosher salt and freshly ground black pepper" +
                         "* 1 9 - oz package frozen chopped spinach, thawed and drained of excess liquid" +
                         "* ¾ cup shredded Cheddar" +
                         "* ½ cup grated Parmesan" +
                         "* ½ whole wheat baguette, cut into 3 / 4 cubes (about 4 cups) Cooking spray",
                        Directions = "* 1-Heat a large nonstick skillet over medium heat.Add the turkey and scallions and cook, stirring to break " +
                         "up any large chunks, until browned and cooked through, about 10 minutes.Remove from heat and let cool slightly." +
                         "* 2-Whisk the eggs, egg whites, milk and 1 / 2 teaspoon each salt and pepper in a large bowl until combined.Add " +
                         "the cooked sausage, spinach, cheeses and bread and toss to distribute ingredients evenly." +
                         "* 3-Spray a 3 - quart casserole dish with cooking spray.Spread the egg mixture evenly in the dish." +
                         " Cover and refrigerate for at least 6 hours or preferably overnight." +
                         "* 4-Preheat the oven to 350ºF.Bake the casserole, uncovered, until set and lightly browned on top, about 30 minutes." +
                         "* 5-Make - Ahead Tip: Freeze the baked casserole for up to 2 weeks.Cover with foil and reheat at 350ºF until hot, 35 to" +
                         " 45 minutes."
                    },
                    new Recipe
                    {
                        RecipeName = "Chia Seed Pudding",
                        RecipeType = "Desert",
                        AddedBy = "Giada De Laurentiss",
                        PrepTime = 5,
                        CookTime = 15,
                        Ingredients = "* 3 Tbsp chia seeds" +
                         "* 1 cup liquid water, juice, milk(plant of dairy)" +
                         "* 1 Tbsp sweetener optional(honey, maple syrup, sugar, etc.)",
                        Directions = "* 1-Add 3 Tablespoon to a sealable container," +
                         " add about 1 Tablespoon of sweetener of choice, top it with 1 cup of liquid of choice." + "Seal container " +
                         "and shake vigorously.Store in refrigerator for 6 - 8 hours until pudding - like consistency.Store for 2 - 7" +
                         " days in the refrigerator."
                    }
                );

                context.SaveChanges();

            }
        }
    }
}
