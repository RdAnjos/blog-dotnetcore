using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Screens.HomeScreens;

namespace Blog.Screens.RoleUserScreen
{
    public class MenuRoleUserScreen
    {
        public static void Run()
        {
            Menu();
        }

        private static void Menu()
        {
            System.Console.WriteLine("Setting a Role to a User.");
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("1 - Create");
            System.Console.WriteLine("2 - Back to Main Menu");
            System.Console.WriteLine();
            System.Console.WriteLine();
            var option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    SetRoleToUserScreen.Load();
                    break;
                case 2:
                    MenuHomeScreen.Load();
                    break;
                default:
                    Run();
                    break;
            }

        }

    }
}