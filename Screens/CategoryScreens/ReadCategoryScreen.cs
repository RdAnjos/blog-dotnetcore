using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog.Screens.CategoryScreens
{
    public class ReadCategoryScreen
    {
        public static void Load()
        {
            //Console.Clear();
            Menu();
            System.Console.WriteLine("Press any key to return to the Main Menu.");
            //Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        private static void Menu()
        {
            //Console.Clear();

            var categoryId = 0;
            System.Console.WriteLine("Searching a Category...");
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine("1 - Read a Category by ID");
            System.Console.WriteLine("2 - List all Categories with Posts Count.");
            System.Console.WriteLine("3 - Return to the Main Menu.");
            System.Console.WriteLine();
            System.Console.WriteLine("Please, Enter a Number: ");
            var option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                //Console.Clear();
                System.Console.WriteLine("Enter a ID to Search: ");
                categoryId = int.Parse(Console.ReadLine());
            }

            switch (option)
            {
                case 1:
                    Read(categoryId);
                    break;
                case 2:
                    ListCategoriesWithPosts(Database.Connection);
                    break;
                case 3:
                    MenuCategoryScreen.Load();
                    break;
                default:
                    Load();
                    break;
            }

        }

        private static void Read(int id)
        {
            try
            {
                var repository = new Repository<Category>();
                var category = repository.GetById(id);
                System.Console.WriteLine("------------------------------------------");
                System.Console.WriteLine($"ID: {category.Id} - Name: {category.Name}");
                System.Console.WriteLine();
            }
            catch (System.Exception ex)
            {
                // TODO
                System.Console.WriteLine($"Id: {id} not found!");
                System.Console.WriteLine(ex.Message);
            }

        }

        private static void ListCategoriesWithPosts(SqlConnection connection)
        {
            var repository = new CategoryRepository(connection);
            var categories = repository.GetWithPosts();

            foreach (var category in categories)
            {
                System.Console.WriteLine($"Category ID: {category.Id}, Category Name: {category.Name}, Posts: {category.Posts.Count}");

            }
        }
    }
}