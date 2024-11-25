using Blog.Screens.HomeScreens;

namespace Blog.Screens.RoleScreens
{
    public class MenuRoleScreen
    {
        public static void Load()
        {
            Menu();
        }

        private static void Menu()
        {
            Console.Clear();

            System.Console.WriteLine("ROLE MANAGEMENT");
            System.Console.WriteLine("---------------");
            System.Console.WriteLine("1 - Create a new Role.");
            System.Console.WriteLine("2 - Read a Role.");
            System.Console.WriteLine("3 - Update a Role.");
            System.Console.WriteLine("4 - Delete a Role.");
            System.Console.WriteLine("5 - Return to the Main Menu.");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Enter a Option: ");
            var option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreateRoleScreen.Run();
                    break;
                case 2:
                    ReadRoleScreen.Run();
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