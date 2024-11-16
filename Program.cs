using Blog.Screens.HomeScreens;
using Blog.Screens.TagScreens;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433; Database=Blog;TrustServerCertificate=true;User ID=sa; Password= @Password24#";
        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            MenuHomeScreen.Load();


            Console.ReadKey();
            Database.Connection.Close();
        }
    }
}