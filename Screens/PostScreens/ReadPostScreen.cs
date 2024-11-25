using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public class ReadPostScreen
    {
        public static void Load() => Read();

        private static void Read()
        {
            try
            {
                Console.Clear();

                var repository = new Repository<Post>();
                var posts = repository.Get();
                System.Console.WriteLine("Listing Posts...");
                System.Console.WriteLine("-----------------");
                foreach (var post in posts)
                {
                    System.Console.WriteLine($"Id: {post.Id}");
                    System.Console.WriteLine($"Title: {post.Title}");
                    System.Console.WriteLine($"Summary: {post.Summary}");
                    System.Console.WriteLine($"Body: {post.Body}");
                    System.Console.WriteLine($"Slug: {post.Slug}");
                    System.Console.WriteLine($"Create Date: {post.CreateDate}");
                    System.Console.WriteLine($"Last Update: {post.LastUpdateDate}");
                    System.Console.WriteLine($"Category Id: {post.CategoryId}");
                    System.Console.WriteLine($"Author Id: {post.AuthorId}");
                    System.Console.WriteLine("------------------------------------");
                }
            }
            catch (System.Exception ex)
            {
                // TODO
                System.Console.WriteLine(ex.Message);
            }


        }
    }
}