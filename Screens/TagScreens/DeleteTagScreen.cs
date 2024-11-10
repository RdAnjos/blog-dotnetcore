using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("EXCLUIR uma Tag por ID");
            System.Console.WriteLine("----------------------");

            Console.Write("Qual [Id] da tag você deseja excluir? : ");
            var id = int.Parse(Console.ReadLine());

            Delete(id);

            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>();
                repository.DeleteById(id);
                System.Console.WriteLine();
                System.Console.WriteLine($"ID ~{id}~ DELETADA com Sucesso!");
                System.Console.WriteLine();
                System.Console.WriteLine("Press any key to return to MENU.");
            }
            catch (System.Exception ex)
            {
                // TODO
                System.Console.WriteLine($"Erro ao tentar DELETAR a tag com ID: ~{id}~");
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}