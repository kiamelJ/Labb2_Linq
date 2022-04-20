using DBManyToManyTest1.Models;
using System;
using System.Linq;

namespace DBManyToManyTest1
{
    class Program
    {
        static void Main(string[] args)
        {          
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Handler.MainMenu();
            }
        }
    }
}
