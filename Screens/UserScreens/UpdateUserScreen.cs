using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public class UpdateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.Write("Enter [Id]: ");
            var idUser = int.Parse(Console.ReadLine());
            System.Console.Write("Enter [Name]: ");
            var name = Console.ReadLine();
            System.Console.Write("Enter [E-mail]: ");
            var email = Console.ReadLine();
            System.Console.Write("Enter [Password]: ");
            var pwHash = Console.ReadLine();
            System.Console.Write("Enter [Bio]: ");
            var bio = Console.ReadLine();
            System.Console.Write("Enter [Image URL]: ");
            var image = Console.ReadLine();
            System.Console.Write("Enter [Slug]: ");
            var slug = Console.ReadLine();

            Update(new User
            {
                Id = idUser,
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
        private static void Update(User user)
        {

            try
            {
                var repository = new Repository<User>();
                repository.Update(user);
                System.Console.WriteLine($"User [{user.Name}] has been sucessfully updated.");
                System.Console.WriteLine();
                System.Console.WriteLine("Press ANY KEY to return to the MENU.");
            }
            catch (System.Exception ex)
            {
                // TODO
                System.Console.WriteLine($"Failed to Update the user [{user.Name}].");
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}