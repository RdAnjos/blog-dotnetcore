using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public class CreateCategoryScreen
    {
        public static void Load()
        {
            //Console.Clear();

            Console.WriteLine("Creating a new Category.");
            Console.WriteLine("------------------------");
            Console.Write("Enter [Name]: ");
            var name = Console.ReadLine();
            Console.Write("Enter [Slug]: ");
            var slug = Console.ReadLine();

            Create(new Category
            {
                Name = name,
                Slug = slug,
            });
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        private static void Create(Category category)
        {
            try
            {
                System.Console.WriteLine();
                var repository = new Repository<Category>();
                repository.Create(category);

                System.Console.WriteLine("Category has been created.");
                System.Console.WriteLine("Press any key to return to the Menu.");

            }
            catch (System.Exception ex)
            {
                // TODO
                System.Console.WriteLine("Failed to try create a new Category.");
                System.Console.WriteLine(ex.Message);
            }


        }
    }
}