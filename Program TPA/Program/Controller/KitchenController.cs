using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Controller
{
    class KitchenController
    {
        DatabaseHotelEntities db = new DatabaseHotelEntities();

        public Ingredient CreateIngredient(String Name, int stock, int minimum)
        {
            Ingredient ingredient = new Ingredient()
            {
                IngredientName = Name,
                IngredientStock = stock,
                IngredientMinimumStock = minimum,
            };
            db.Ingredients.Add(ingredient);
            db.SaveChanges();

            return ingredient;
        }

        public object ViewAllIngredient()
        {
            var data = (from ingredient in db.Ingredients
                        where ingredient.DeleteIngredient == 0
                        select new
                        {
                            IngredientId = ingredient.IngredientId,
                            IngredientName = ingredient.IngredientName,
                            ingredientStock = ingredient.IngredientStock,
                            IngredientMinimumStock = ingredient.IngredientMinimumStock,


                        }).ToList();
            return data;
        }

        public Ingredient UpdateIngredient(int Id, String Name, int stock, int minimum)
        {
            Ingredient ingredient = db.Ingredients.Find(Id);
            ingredient.IngredientName = Name;
            ingredient.IngredientStock = stock;
            ingredient.IngredientMinimumStock = minimum;
            db.SaveChanges();

            return ingredient;
        }

        public Ingredient DeleteIngredient(int Id)
        {
            Ingredient ingredient = db.Ingredients.Find(Id);
            ingredient.DeleteIngredient = 1;

            db.SaveChanges();

            return ingredient;
        }
    }
}
