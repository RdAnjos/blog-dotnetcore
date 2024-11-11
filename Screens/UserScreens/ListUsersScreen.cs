using Blog.Models;
using Blog.Repositories;


namespace Blog.Screens.UserScreens
{
    public class ListUsersScreen
    {
        public static void Load()
        {
            List();
        }
        private static void List()
        {
            Console.Clear();
            System.Console.WriteLine("Listing all Users");
            System.Console.WriteLine("-----------------");
            var repository = new Repository<User>();
            var users = repository.Get();

            foreach (var user in users)
            {
                System.Console.WriteLine($"{user.Id} - {user.Name} - {user.Email}");
            }
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Press Any Key to return to the Menu...");
            Console.ReadKey();

            MenuUserScreen.Load();
        }
    }
}