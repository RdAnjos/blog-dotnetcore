using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();

            System.Console.WriteLine("New Tag");
            System.Console.WriteLine("-------------");

            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Tag
            {
                Name = name,
                Slug = slug
            });


            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Create(Tag tag)
        {

            try
            {
                var repository = new Repository<Tag>();
                repository.Create(tag);
                System.Console.WriteLine();
                System.Console.WriteLine($"Tag ~{tag.Name}~ Cadastrada com Sucesso!");
                System.Console.WriteLine();
                System.Console.WriteLine("Press any key to return to MENU.");

            }
            catch (Exception ex)
            {
                // TODO
                System.Console.WriteLine($"Erro ao criar uma nova Tag: {ex}");
                System.Console.WriteLine($"{ex.Message}");
            }



        }
    }
}