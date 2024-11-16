using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Screens.HomeScreens
{
    public class CloseHomeScreen
    {
        public static void Run()
        { Close(); }

        private static void Close()
        {
            System.Console.WriteLine("Wait! We are closing this application...");
            Thread.Sleep(3000);

            System.Environment.Exit(1);
        }
    }
}