using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog.Screens.PostTagScreens
{
    public class ListTagWithPostsQuantityScreen
    {
        public static void Init()
        {
            ListTagWithPostsQuantity(Database.Connection);
        }
        private static void ListTagWithPostsQuantity(SqlConnection connection)
        {
            var tagsAndPosts = new TagPostsRepository(connection);
            var tags = tagsAndPosts.ListTagAndPostsQuantity();

            foreach (var tag in tags)
            {
                System.Console.WriteLine();
                System.Console.WriteLine($"Tag ID: {tag.Id}, Tag Name: {tag.Name}, Posts: {tag.Posts.Count}");
                System.Console.WriteLine("-------------------------------------------------------");

            }
        }
    }
}