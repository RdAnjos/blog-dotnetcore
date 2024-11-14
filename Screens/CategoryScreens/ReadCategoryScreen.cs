using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public class ReadCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Searching a Category by ID...");
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine("Please, Enter a ID: ");
            var categoryId = int.Parse(Console.ReadLine());
            Read(categoryId);
            System.Console.WriteLine();
            System.Console.WriteLine("Press any key to return to the Category's Menu.");
            Console.ReadKey();
            MenuCategoryScreen.Load();
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

        private static void ListCategoriesWithPosts()
        {

        }
    }
}