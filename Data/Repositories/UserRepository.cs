using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Data.Repositories {
    public class UserRepository {
        private RSDBContext _context;

        public UserRepository() { 
            this._context = new RSDBContext();
        }

        public UserRepository(RSDBContext context) {
            this._context = context;
        }

        public List<User> Get(int? id, string username, string email, string password) {
            return this._context.Users.Where(c =>
                (
                    id == null || c.Id == id
                ) && 
                (
                    string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(username) || c.Username.Contains(username)
                ) && 
                (
                    string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email) || c.Email.Contains(email)
                ) &&
                (
                    string.IsNullOrEmpty(password) || c.Password.Contains(password)
                )
            ).ToList();
        }

        public void Add(User user) { 
            this._context.Users.Add(user);
            this._context.SaveChanges();
        }

        public void Delete(User user) {
            this._context.Users.Remove(user);
            this._context.SaveChanges();
        }

        public void Update(User user) {
            User oldUser = this._context.Users.Find(user.Id);
            this._context.Entry(oldUser).CurrentValues.SetValues(user);
            this._context.SaveChanges();
        }
    }
}
