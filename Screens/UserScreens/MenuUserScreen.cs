using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Blog.Screens.HomeScreens;

namespace Blog.Screens.UserScreens
{
    public class MenuUserScreen
    {
        public static void Load()
        {
            Menu();
        }

        private static void Menu()
        {
            //Console.Clear();

            System.Console.WriteLine("Menu USER");
            System.Console.WriteLine("---------");
            System.Console.WriteLine("What do you wanna do?");
            System.Console.WriteLine();
            System.Console.WriteLine("1 - List all Users");
            System.Console.WriteLine("2 - Create a new User");
            System.Console.WriteLine("3 - Update a User");
            System.Console.WriteLine("4 - Delete a User");
            System.Console.WriteLine("5 - Return to Main Menu");

            System.Console.WriteLine();
            System.Console.WriteLine();
            var option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListUsersScreen.Load();
                    break;
                case 2:
                    CreateUserScreen.Load();
                    break;
                case 3:
                    UpdateUserScreen.Load();
                    break;
                case 4:
                    DeleteUserScreen.Load();
                    break;
                case 5:
                    MenuHomeScreen.Load();
                    break;
                default:
                    Load();
                    break;
            }


        }
    }
}