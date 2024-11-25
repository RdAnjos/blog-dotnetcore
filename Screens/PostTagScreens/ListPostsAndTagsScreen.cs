using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog.Screens.PostTagScreens
{
    public class ListPostsAndTagsScreen
    {
        public static void Run()
        {
            Menu(Database.Connection);
        }

        private static void Menu(SqlConnection connection)
        {
            var postAndTags = new ListPostsTagsRepository(connection);
            var posts = postAndTags.ListPostsAndTags();

            foreach (var post in posts)
            {
                foreach (var tag in post.Tags)
                {
                    System.Console.WriteLine($"Post ID: {post.Id}, Post Title: {post.Title}, Post Slug: {post.Slug}, Tag Id: {tag.Id},Tag Name: {tag.Name}, Tag Slug: {tag.Slug}");
                    System.Console.WriteLine("------------------------------------------------------------------------------------");
                }
            }
        }
    }
}