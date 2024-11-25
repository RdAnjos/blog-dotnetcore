using Blog.Screens.HomeScreens;

namespace Blog.Screens.PostTagScreens
{
    public class MenuPostTagScreen
    {
        public static void Load()
        {
            Menu();
        }

        private static void Menu()
        {
            //Console.Clear();

            System.Console.WriteLine("Menu Post & Tag Screen...");
            System.Console.WriteLine("-------------------------");
            System.Console.WriteLine("1 - Link Post with a Tag");
            System.Console.WriteLine("2 - Listing Tags with Posts Quantity");
            System.Console.WriteLine("3 - Listing Posts and Tags");
            System.Console.WriteLine("4 - Return to Main Menu");
            System.Console.WriteLine();
            System.Console.WriteLine();

            var option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    LinkPostWithTagScreen.Load();
                    break;
                case 2:
                    ListTagWithPostsQuantityScreen.Init();
                    break;
                case 3:
                    ListPostsAndTagsScreen.Run();
                    break;
                case 4:
                    MenuHomeScreen.Load();
                    break;
                default:
                    Load();
                    break;
            }
        }
    }
}