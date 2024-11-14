using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Screens.HomeScreens;

namespace Blog.Screens.CategoryScreens
{
    public class MenuCategoryScreen
    {
        public static void Load()
        {
            Menu();
        }

        private static void Menu()
        {
            //Console.Clear();

            System.Console.WriteLine("Category Management.");
            System.Console.WriteLine("----------------");

            System.Console.WriteLine("1 - List Category(s)");
            System.Console.WriteLine("2 - Create a new Category");
            System.Console.WriteLine("3 - Update a Category.");
            System.Console.WriteLine("4 - Delete a Category.");
            System.Console.WriteLine("5 - Return to Main Menu");
            System.Console.WriteLine("");
            var option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ReadCategoryScreen.Load();
                    break;
                case 2:
                    CreateCategoryScreen.Load();
                    break;
                case 3:
                    UpdateCategoryScreen.Load();
                    break;
                case 4:
                    DeleteCagegoryScreen.Load();
                    break;
                case 5:
                    MenuHomeScreen.LoadMe();
                    break;
                default:
                    Load();
                    break;
            }

        }
    }
}