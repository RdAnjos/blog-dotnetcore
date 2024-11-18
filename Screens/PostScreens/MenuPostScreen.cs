using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Screens.PostScreens
{
    public class MenuPostScreen
    {
        public static void Load()
        {
            Menu();
        }
        private static void Menu()
        {
            Console.Clear();

            System.Console.WriteLine("Post Management.");
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("1 - Create a Post");
            System.Console.WriteLine("2 - Read a Post");
            System.Console.WriteLine("3 - Update a Post");
            System.Console.WriteLine("4 - Delete a Post");

            var option = int.Parse(Console.ReadLine());

        }
    }
}