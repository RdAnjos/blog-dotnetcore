using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public class ReadRoleScreen
    {
        public static void Run()
        {
            Console.Clear();
            MenuReadRole();
        }

        private static void MenuReadRole()
        {
            System.Console.WriteLine("Searching for Role(s)...");
            System.Console.WriteLine("------------------------");
            System.Console.WriteLine("1 - Find All");
            System.Console.WriteLine("2 - Find by Id");
            System.Console.WriteLine("3 - Return to the Main Role");
            System.Console.WriteLine();
            System.Console.WriteLine();
            var option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ReadAll();
                    break;
                case 2:
                    ReadById();
                    break;
                case 3:
                    MenuRoleScreen.Load();
                    break;
                default:
                    Run();
                    break;
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Press any key to return to the Role Menu");
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        private static void ReadById()
        {
            Console.Clear();
            System.Console.WriteLine("Looking for a Role...");
            System.Console.WriteLine("---------------------");
            System.Console.WriteLine("Enter a Role ID: ");
            var roleId = int.Parse(Console.ReadLine());

            try
            {
                var repository = new Repository<Role>();
                var role = repository.GetById(roleId);

                System.Console.WriteLine("Role Found it!");
                System.Console.WriteLine("-----------");
                System.Console.WriteLine($"Id: {role.Id} \n Name: {role.Name} \n Slug: {role.Slug}");
            }
            catch (System.Exception ex)
            {
                // TODO
                System.Console.WriteLine($"Unfortunately, we did not find this role id: [{roleId}]");
                System.Console.WriteLine(ex.Message);
            }


        }

        private static void ReadAll()
        {
            Console.Clear();
            System.Console.WriteLine("Looking for all Roles...");
            System.Console.WriteLine("------------------------");

            try
            {
                var repository = new Repository<Role>();
                var roles = repository.Get();

                foreach (var role in roles)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine($" Id: {role.Id} \n Name: {role.Name} \n Slug: {role.Slug} ");
                    System.Console.WriteLine("-----------------------");
                }
            }
            catch (System.Exception ex)
            {
                // TODO
                System.Console.WriteLine("Unfortunately, we did find any role.");
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}