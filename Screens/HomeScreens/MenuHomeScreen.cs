using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Screens.TagScreens;

namespace Blog.Screens.HomeScreens
{
    public class MenuHomeScreen
    {
        public static void LoadMe()
        {
            Load();
        }
        private static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Meu Blog.");
            System.Console.WriteLine("-------------------");
            System.Console.WriteLine("O que deseja fazer?");
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Gestão de Usuario");
            System.Console.WriteLine("2 - Gestão de Perfil");
            System.Console.WriteLine("3 - Gestão de Categoria");
            System.Console.WriteLine("4 - Gestão de Tag");
            System.Console.WriteLine("5 - Vincular Perfil/Usuario");
            System.Console.WriteLine("6 - Vincular Post/Tag");
            System.Console.WriteLine("7 - Relatórios");
            System.Console.WriteLine();
            System.Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    MenuTagScreen.Load();
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;

                default:
                    Load();
                    break;
            }

        }
    }
}