using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Screens.HomeScreens;

namespace Blog.Screens.TagScreens
{
    //Serão todas STATIC pois sera apenas telas.
    public static class MenuTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Gestão de Tags");
            System.Console.WriteLine("---------------");
            System.Console.WriteLine("O que você deseja fazer?");
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Listar Tags");
            System.Console.WriteLine("2 - Cadastrar Tags");
            System.Console.WriteLine("3 - Atualizar Tag");
            System.Console.WriteLine("4 - Remover Tag");
            System.Console.WriteLine("5 - Retornar ao Menu Inicial");
            System.Console.WriteLine();
            System.Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            //Inserir um Switch
            switch (option)
            {
                case 1:
                    //lista as tags;
                    ListTagsScreen.Load();
                    break;
                case 2:
                    //cadastra uma tag;
                    CreateTagScreen.Load();
                    break;
                case 3:
                    //Atualizar a Tag
                    UpdateTagScreen.Load();
                    break;
                case 4:
                    //Remove uma tag
                    DeleteTagScreen.Load();
                    break;
                case 5:
                    //Remove uma tag
                    MenuHomeScreen.Load();
                    break;
                default:
                    Load(); break;
            }
        }
    }
}