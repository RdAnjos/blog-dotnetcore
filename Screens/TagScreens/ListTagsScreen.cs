using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class ListTagsScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Lista de Tags");
            System.Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void List()
        {
            //var repository = new Repository<Tag>(Database.Connection);
            var repository = new Repository<Tag>();
            var tags = repository.Get();

            foreach (var tag in tags)
                System.Console.WriteLine($"{tag.Id} - {tag.Name} ({tag.Slug})");

        }
    }
}