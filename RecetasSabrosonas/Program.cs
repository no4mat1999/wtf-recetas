using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Services.Services;

namespace RecetasSabrosonas
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Hola");
            

            Service serv = new Service();
            List<User> users = serv.Get(null, "no4mat", null);
            User u = users.ElementAt(0);
            Profile p = u.Profile;
            Console.WriteLine(u.Username);
            Console.WriteLine(p.Name);
            //serv.Delete(u);

            Console.ReadLine();
           
        }

        public static void RegisterUser () {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Firts Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Birthday: ");
            string birthday = Console.ReadLine();

            Service serv = new Service();
            serv.Add(username, password, email, firstName, lastName, birthday);
        }
    }
}
