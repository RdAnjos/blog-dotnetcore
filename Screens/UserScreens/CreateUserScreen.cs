using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;
using Microsoft.Identity.Client;

namespace Blog.Screens.UserScreens
{
    public class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.Write("Type the [NAME]: ");
            var name = Console.ReadLine();
            System.Console.Write("Type the [E-MAIL]: ");
            var email = Console.ReadLine();
            System.Console.Write("Type the [Password Hash]: ");
            var pwHash = Console.ReadLine();
            System.Console.Write("Type the [BIO]: ");
            var bio = Console.ReadLine();
            System.Console.Write("Type the [IMAGE]: ");
            var image = Console.ReadLine();
            System.Console.Write("Type the [SLUG]: ");
            var slug = Console.ReadLine();

            Create(new User
            {
                Name = name,
                Email = email,
                PasswordHash = pwHash,
                Bio = bio,
                Image = image,
                Slug = slug
            });

            Console.ReadKey();
            MenuUserScreen.Load();
        }
        private static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>();
                repository.Create(user);
                System.Console.WriteLine();
                System.Console.WriteLine($"User: [{user.Name}] created sucessfully!");
                System.Console.WriteLine();
                System.Console.WriteLine("Press any key to return to MENU.");
            }
            catch (System.Exception ex)
            {
                // TODO
                System.Console.WriteLine($"Failed to try create a new User.");
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}