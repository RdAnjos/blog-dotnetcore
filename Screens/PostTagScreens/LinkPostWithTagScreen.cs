using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.HomeScreens;

namespace Blog.Screens.PostTagScreens
{
    public class LinkPostWithTagScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Vinculando um Post a uma Tag.");
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine("Enter a Post ID: ");
            var postId = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter a Tag ID: ");
            var tagId = int.Parse(Console.ReadLine());

            ConectPostAndTag(new PostTag
            {
                PostId = postId,
                TagId = tagId
            });

            System.Console.WriteLine("Press any key to return to Main Menu.");
            Console.ReadKey();
            MenuHomeScreen.Load();
        }
        private static void ConectPostAndTag(PostTag postTag)
        {
            bool isValid = ValidPostAndTag(postTag);
            if (isValid)
            {
                try
                {
                    var repositoryPostTag = new Repository<PostTag>();
                    repositoryPostTag.Create(postTag);
                    System.Console.WriteLine("Link has been created.");
                }
                catch (System.Exception ex)
                {
                    // TODO
                    System.Console.WriteLine("Ocurred an error to try create a link with Post and Tag.");
                    System.Console.WriteLine(ex.Message);
                }
            }
            else
            {
                System.Console.WriteLine("Post ID or Tag ID does not exists!");
            }


        }

        private static bool ValidPostAndTag(PostTag postTag)
        {
            var repositoryPost = new Repository<Post>();
            var repositoryTag = new Repository<Tag>();

            var post = repositoryPost.GetById(postTag.PostId);
            var tag = repositoryTag.GetById(postTag.TagId);

            if (post != null && tag != null)
            {
                return true;
            }
            return false;
        }
    }
}