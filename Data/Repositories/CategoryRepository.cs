using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Data.Repositories {
    public class CategoryRepository {
        private RSDBContext _context;

        public CategoryRepository(RSDBContext context) { 
            this._context = context;
        }

        public CategoryRepository() {
            this._context = new RSDBContext();
        }

        public List<Category> Get(int? id, string name) {
            return this._context.Categories.Where(c => (
                (id == null || c.Id == id) && 
                (string.IsNullOrEmpty(name) || c.Name.Equals(name))
              )).ToList();
        }

        public void Add(Category category) { 
            this._context.Categories.Add(category);
            this._context.SaveChanges();
        }

        public void Delete(Category category) {
            this._context.Categories.Remove(category);
            this._context.SaveChanges();
        }

        public void Update(Category category) {
            Category oldCategory = this._context.Categories.Find(category.Id);
            this._context.Entry(oldCategory).CurrentValues.SetValues(category);
            this._context.SaveChanges();
        }
    }
}
