using Blog.Screens.CategoryScreens;
using Blog.Screens.PostScreens;
using Blog.Screens.PostTagScreens;
using Blog.Screens.RoleScreens;
using Blog.Screens.RoleUserScreen;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreens;


namespace Blog.Screens.HomeScreens
{
    public class MenuHomeScreen
    {
        public static void Load() => Menu();

        private static void Menu()
        {
            //Console.Clear();

            System.Console.WriteLine("MY CURRENT BLOG.");
            System.Console.WriteLine("-------------------");
            System.Console.WriteLine("O que deseja fazer?");
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Gestão de Usuario");
            System.Console.WriteLine("2 - Gestão de Perfil/Role");
            System.Console.WriteLine("3 - Gestão de Categoria");
            System.Console.WriteLine("4 - Gestão de Tag");
            System.Console.WriteLine("5 - Gestão de Post");
            System.Console.WriteLine("6 - Vincular Perfil/Usuario");
            System.Console.WriteLine("7 - Vincular Post/Tag");
            System.Console.WriteLine("8 - Reports");
            System.Console.WriteLine("9 - Exit");
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
                    MenuPostScreen.Load();
                    break;
                case 6:
                    MenuRoleUserScreen.Run();
                    break;
                case 7:
                    MenuPostTagScreen.Load();
                    break;
                case 8:

                    break;
                case 9:
                    CloseHomeScreen.Run();
                    break;
                default:
                    Load();
                    break;
            }

        }
    }
}