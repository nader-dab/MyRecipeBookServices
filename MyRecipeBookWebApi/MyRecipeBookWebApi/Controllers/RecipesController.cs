using MyRecipeBookWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyRecipeBookWebApi.Controllers
{
    public class RecipesController : ApiController
    {
        private static ICollection<Recipe> recipes = new List<Recipe>()
        {
            new Recipe()
            {
                Category = "Soup",
                Name = "Miso Soup",
                Details = "Miso soup is a traditional Japanese soup consisting of a stock called dashi into which softened miso paste is mixed. Many ingredients are added depending on regional and seasonal recipes, and personal preference.",
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient() { Product= "Mushrooms", Measurement = "gram(s)", Quantity= 100 },
                    new Ingredient() { Product= "Potatoes", Measurement = "kilogram(s)", Quantity= 0.5 },
                    new Ingredient() { Product= "Seaweed", Measurement = "gram(s)", Quantity= 150 },
                    new Ingredient() { Product= "Onion", Measurement = "large", Quantity= 1 },
                    new Ingredient() { Product= "Shrimp", Measurement = "gram(s)", Quantity= 250 },
                    new Ingredient() { Product= "Water", Measurement = "mililiter(s)", Quantity= 600 },

                }
            },
            new Recipe()
            {
                Category = "Desert",
                Name = "Holiday Fudge Bites",
                Details = @"LINE 8-inch square pan with foil, with ends of foil extending over sides. Microwave first 4 ingredients in large microwaveable bowl on HIGH 2 min. or until butter is melted; stir until chocolate is completely melted.

                    ADD dry pudding mix; stir with whisk 2 min. Add powdered sugar, 1 cup at a time, stirring after each addition until blended; press onto bottom of prepared pan. Top with sprinkles; press into fudge to secure.

                    REFRIGERATE 2 hours or until firm. Use foil handles to lift fudge from pan before cutting into pieces.",
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient() { Product= "White Chocolate", Measurement = "gram(s)", Quantity= 250 },
                    new Ingredient() { Product= "Semi-Sweet Chocolate", Measurement = "gram(s)", Quantity= 250 },
                    new Ingredient() { Product= "Butter", Measurement = "tablespoon(s)", Quantity= 5 },
                    new Ingredient() { Product= "Water", Measurement = "cup(s)", Quantity= 1 },
                    new Ingredient() { Product= "Chocolate Instant Pudding", Measurement = "gram(s)", Quantity= 250 },

                }
            },
            new Recipe()
            {
                Category = "Dinner",
                Name = "Baked Garlic Parmesan Chicken",
                Details = "Serve with a salad and pasta or rice for a quick, scrumptious dinner.",
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient() { Product= "Olive oil", Measurement = "tablespoon(s)", Quantity= 2 },
                    new Ingredient() { Product= "Dry bread crumbs", Measurement = "cup(s)", Quantity= 1 },
                    new Ingredient() { Product= "Garlic", Measurement = "medium", Quantity= 1 },
                    new Ingredient() { Product= "Parmesan cheese", Measurement = "cup(s)", Quantity= 1 },
                    new Ingredient() { Product= "Dried basil", Measurement = "teaspoon(s)", Quantity= 1 },
                    new Ingredient() { Product= "Chicken breasts", Measurement = "gram(s)", Quantity= 400 },

                }
            }
        };

        public IQueryable<Recipe> Get()
        {
            return recipes.AsQueryable();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}