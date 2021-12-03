using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Data.Repositories {
    public class RecipeRepository {
        private RSDBContext _context;

        public RecipeRepository (RSDBContext context) {
            this._context = context;
        }

        public RecipeRepository() { 
            this._context = new RSDBContext();
        }

        public List<Recipe> Get (int? id, Category category, string name, bool isPublic, int score, DateTime start, DateTime end) {
            return new List<Recipe>();
        }

        public void Insert(Recipe recipe) {
            this._context.Recipes.Add(recipe);
            this._context.SaveChanges();
        }

        public void Delete (Recipe recipe) {
            this._context.Recipes.Remove(recipe);
            this._context.SaveChanges();
        }

        public void Update(Recipe recipe) {
            Recipe oldRecipe = this._context.Recipes.Find(recipe.Id);
            this._context.Entry(oldRecipe).CurrentValues.SetValues(recipe);
            this._context.SaveChanges();
        }

    }
}
