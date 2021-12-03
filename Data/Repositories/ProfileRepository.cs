using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Data.Repositories {
    public class ProfileRepository {
        private RSDBContext _context;

        public ProfileRepository(RSDBContext context) {
            this._context = context;
        }

        public ProfileRepository() { 
            this._context = new RSDBContext();
        }

        public List<Profile> Get(int? id) {
            return this._context.Profiles.Where(c => c.Id == id).ToList(); 
        }

        public void Delete (Profile profile) {
            this._context.Profiles.Remove(profile);
            this._context.SaveChanges();
        }

        public void Update(Profile profile) {
            Profile oldProfile = this._context.Profiles.Find(profile.Id);
            this._context.Entry(oldProfile).CurrentValues.SetValues(profile);
            this._context.SaveChanges();
        }
    }
}
