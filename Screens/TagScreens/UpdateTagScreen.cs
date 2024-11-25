using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("Update a Tag");
            System.Console.WriteLine("-------------");

            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Tag
            {
                Id = id,
                Name = name,
                Slug = slug
            });


            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>();
                repository.Update(tag);
                System.Console.WriteLine();
                System.Console.WriteLine($"Tag ~{tag.Name}~ Atualizada com Sucesso!");
                System.Console.WriteLine();
                System.Console.WriteLine("Press any key to return to MENU.");
            }
            catch (Exception ex)
            {
                // TODO
                System.Console.WriteLine($"Erro ao tentar atualizar a TAG ~{tag.Name}~");
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}