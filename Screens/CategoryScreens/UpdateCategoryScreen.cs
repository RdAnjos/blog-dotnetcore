using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public class UpdateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Updating a Category...");
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("Enter with [Id], [Name] and [Slug]:");
            var id = int.Parse(Console.ReadLine());
            var name = Console.ReadLine();
            var slug = Console.ReadLine();

            Update(new Category
            {
                Id = id,
                Name = name,
                Slug = slug
            });
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine();
            System.Console.WriteLine("Press any key to return to the Category's Menu.");
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }
        private static void Update(Category category)
        {
            try
            {
                var respository = new Repository<Category>();
                respository.Update(category);
                System.Console.WriteLine();
                System.Console.WriteLine($"The Category [{category.Name} has been updated.]");
            }
            catch (System.Exception ex)
            {
                // TODO
                System.Console.WriteLine($"Ocurred an error to try Update this Category. [{category.Name}]");
                System.Console.WriteLine(ex.Message);
            }


        }

    }
}