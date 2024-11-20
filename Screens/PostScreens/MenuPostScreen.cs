using Blog.Screens.HomeScreens;

namespace Blog.Screens.PostScreens
{
    public class MenuPostScreen
    {
        public static void Load() => Menu();

        private static void Menu()
        {
            Console.Clear();

            System.Console.WriteLine("Post Management.");
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("1 - Create a Post");
            System.Console.WriteLine("2 - Read a Post");
            System.Console.WriteLine("3 - Update a Post");
            System.Console.WriteLine("4 - Delete a Post");
            System.Console.WriteLine("5 - Return to Main Menu");

            var option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreatePostScreen.Load();
                    break;
                case 2:
                    ReadPostScreen.Load();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    MenuHomeScreen.Load();
                    break;
                default:
                    Load();
                    break;
            }
        }
    }
}