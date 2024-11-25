using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog.Screens.CategoryScreens
{
    public class ListPostsFromCategoryScreen
    {
        public static void Init()
        {
            Menu(Database.Connection);
        }

        private static void Menu(SqlConnection connection)
        {
            var postsFromCategory = new ListPostsCategoryRepository(connection);
            var categories = postsFromCategory.ListPostsCategory();

            foreach (var category in categories)
            {
                System.Console.WriteLine($"Category ID: {category.Id}, Category Name: {category.Name}");
                System.Console.WriteLine("-----------------------------------------------------------");
                foreach (var post in category.Posts)
                {
                    System.Console.WriteLine($"Post Id: {post.Id}, Post Title: {post.Title}, Post Slug: {post.Slug}");
                }
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
        }
    }
}