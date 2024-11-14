using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public class DeleteCagegoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Deleting a Category...");
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine();
            System.Console.WriteLine("Please, Enter ID: ");
            var categoryId = int.Parse(Console.ReadLine());
            Delete(categoryId);

            System.Console.WriteLine();
            System.Console.WriteLine("Press any key to return to the Category's Menu.");
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Category>();
                var category = repository.GetById(id);
                repository.DeleteById(id);

                System.Console.WriteLine();
                System.Console.WriteLine($"The Category: {category.Name} has been deleted.");
            }
            catch (System.Exception ex)
            {
                // TODO
                System.Console.WriteLine($"Ocurred an error to try delete the Id's Category: {id}");
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}