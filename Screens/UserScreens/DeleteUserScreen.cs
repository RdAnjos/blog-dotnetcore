using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public class DeleteUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Removing a User...");
            System.Console.WriteLine("------------------");
            System.Console.WriteLine("Enter the [ID]: ");
            var idToDelete = int.Parse(Console.ReadLine());
            DeleteById(idToDelete);

            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void DeleteById(int id)
        {
            try
            {
                var repository = new Repository<User>();
                repository.DeleteById(id);
                System.Console.WriteLine($"The User ID [{id}] has been deleted.");
                System.Console.WriteLine();
                System.Console.WriteLine("Press Any Key to return to the MENU.");
            }
            catch (System.Exception ex)
            {
                // TODO
                System.Console.WriteLine($"Error to try delete this user [{id}]");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}