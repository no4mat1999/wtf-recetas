using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using Domain.Entities;

namespace Services.Services
{
    public class Service
    {
        private readonly UserRepository _userRepository;
        private readonly ProfileRepository _profileRepository;

        public Service()
        {
            this._userRepository = new UserRepository();
            this._profileRepository = new ProfileRepository();
        }

        public Service(UserRepository userRepository, ProfileRepository profileRepository)
        {
            this._userRepository = userRepository;
            this._profileRepository = profileRepository;
        }

        public List<User> Get(int? id, string username, string email)
        {
            return this._userRepository.Get(id, username, email, null);
        }

        public Profile Login (string username, string password) {
            return this._userRepository.Get(null, username, null, password).FirstOrDefault().Profile;
        }

        public void Add(string username, string password, string email, string fName, string lName, string birthday) {
            User user = new User();
            user.Username = username;
            user.Password = password;
            user.Email = email;
            user.Profile = new Profile();
            user.Profile.Name = fName;
            user.Profile.LastName = lName;
            user.Profile.Birthday = DateTime.Parse(birthday);
            this._userRepository.Add(user);
        }

        public void Delete(User user) {
            this._userRepository.Delete(user);
        }
       
        
    }
}
