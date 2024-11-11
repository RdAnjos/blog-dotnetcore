using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;


namespace Blog.Screens.UserScreens
{
    public class ListUsersScreen
    {
        public static void Load()
        {
            Menu();
        }

        private static void Menu()
        {
            Console.Clear();

            System.Console.WriteLine("Listing all options about User MENU.");
            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine("1 - List All Only Users");
            System.Console.WriteLine("2 - List All Users and Roles");
            System.Console.WriteLine("3 - Return to Main Menu");
            System.Console.WriteLine();
            var option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListAllUsers();
                    break;
                case 2:
                    ListUserAndRole(Database.Connection);
                    break;
                case 3:
                    MenuUserScreen.Load();
                    break;
                default:
                    Load();
                    break;
            }

        }
        private static void ListAllUsers()
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

        private static void ListUserAndRole(SqlConnection connection)
        {
            var userRepository = new UserRepository(connection);
            var users = userRepository.GetWithRoles();
            foreach (var user in users)
            {
                foreach (var role in user.Roles)
                {
                    System.Console.WriteLine($"Name: {user.Name}, Email: {user.Email}, Role ID: {role.Id}, Role Name: {role.Name}");
                }
            }

        }
    }
}