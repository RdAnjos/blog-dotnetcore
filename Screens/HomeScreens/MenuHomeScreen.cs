using Blog.Screens.CategoryScreens;
using Blog.Screens.RoleScreens;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreens;


namespace Blog.Screens.HomeScreens
{
    public class MenuHomeScreen
    {
        public static void Load()
        {
            Menu();
        }
        private static void Menu()
        {
            Console.Clear();

            System.Console.WriteLine("MY CURRENT BLOG.");
            System.Console.WriteLine("-------------------");
            System.Console.WriteLine("O que deseja fazer?");
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Gestão de Usuario");
            System.Console.WriteLine("2 - Gestão de Perfil/Role");
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
                    MenuUserScreen.Load();
                    break;
                case 2:
                    MenuRoleScreen.Load();
                    break;
                case 3:
                    MenuCategoryScreen.Load();
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