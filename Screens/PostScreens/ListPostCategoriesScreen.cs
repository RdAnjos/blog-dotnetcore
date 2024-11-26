using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog.Screens.PostScreens
{
    public class ListPostCategoriesScreen
    {
        public static void Load()
        {
            ListPostCategories(Database.Connection);
        }

        private static void ListPostCategories(SqlConnection connection)
        {
            try
            {
                var postCategories = new PostCategoryRepository(connection);
                var posts = postCategories.ListPostsAndCategories();

                foreach (var post in posts)
                {
                    foreach (var category in post.Categories)
                    {
                        System.Console.WriteLine($"Id: {post.Id}, \nTitle: {post.Title}, \nSummary: {post.Summary}, \nCreate Date: {post.CreateDate}, \nCategory Id: {category.Id}, \nCategory Name: {category.Name}, \nCategory Slug: {category.Slug}");
                        System.Console.WriteLine();
                        System.Console.WriteLine("-------------------------------------------------------");
                    }
                }
            }
            catch (System.Exception ex)
            {
                // TODO
                System.Console.WriteLine("Ocurred an error to try listing Posts and its Categories.");
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}