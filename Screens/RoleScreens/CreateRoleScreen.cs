using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public class CreateRoleScreen
    {
        public static void Run()
        {
            Console.Clear();
            System.Console.WriteLine("Creating a new Role...");
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("Enter Name: ");
            var nameRole = Console.ReadLine();
            System.Console.WriteLine("Enter Slug: ");
            var slugRole = Console.ReadLine();

            Create(new Role
            {
                Name = nameRole,
                Slug = slugRole
            });

            System.Console.WriteLine();
            System.Console.WriteLine("Press any key to return to the Menu Role");
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        private static void Create(Role role)
        {
            Console.Clear();
            try
            {
                var repository = new Repository<Role>();
                repository.Create(role);
                System.Console.WriteLine();
                System.Console.WriteLine($"Role [{role.Name}] has been created!");
            }
            catch (System.Exception ex)
            {
                // TODO
                System.Console.WriteLine($"Ocurred an error to try create a new role.");
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}