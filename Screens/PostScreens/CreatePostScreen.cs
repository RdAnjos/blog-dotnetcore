using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public class CreatePostScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Creating a new Post.");
            System.Console.WriteLine("--------------------");
            System.Console.Write("Enter a Title: ");
            var title = Console.ReadLine();
            System.Console.Write("Enter a Summary: ");
            var summary = Console.ReadLine();
            System.Console.Write("Enter a Body: ");
            var body = Console.ReadLine();
            System.Console.Write("Enter a Slug: ");
            var slug = Console.ReadLine();
            System.Console.Write("Enter a Category ID: ");
            var categoryId = int.Parse(Console.ReadLine());
            System.Console.Write("Enter a Author ID: ");
            var authorId = int.Parse(Console.ReadLine());

            Create(new Post
            {
                Title = title,
                Summary = summary,
                Body = body,
                Slug = slug,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                CategoryId = categoryId,
                AuthorId = authorId
            });

            System.Console.WriteLine("Press any key to return to Menu Post.");
            Console.ReadKey();
            MenuPostScreen.Load();
        }

        private static void Create(Post post)
        {
            try
            {
                var repository = new Repository<Post>();
                repository.Create(post);
                System.Console.WriteLine();
                System.Console.WriteLine($"The post: [{post.Title}] has been successfully created!");
            }
            catch (System.Exception ex)
            {
                // TODO
                System.Console.WriteLine("Ocurred an error to try create a new Post.");
                System.Console.WriteLine(ex.Message);
            }

        }

    }
}