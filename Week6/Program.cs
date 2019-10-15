using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set up and placing values into constructors
            //Game g1 = new Game("Monopoly", 19.99m, new DateTime(1970, 01, 31));
            //Game g2 = new Game() { Price = 10.99m, ReleaseDate = new DateTime(2000, 6, 15) };

            //Set up and placing values into constructors for 2nd class
            ComputerGame cg1 = new ComputerGame("Sonic", 29.99m, new DateTime(1990, 3, 15), "0");
            ComputerGame cg2 = new ComputerGame("Mario", 24.99m, new DateTime(1995, 11, 7), "7");

            //Displays values with Tostrings
            //Console.WriteLine(g1.ToString());
            //Console.WriteLine(g2.ToString());
            //Console.WriteLine("");

            //Display with method
            //DisplayGame(g1);
            //DisplayGame(g2);
            DisplayGame(cg1);
            DisplayGame(cg2);
        }

        //This calls the objects to this method , calling ToString methods
        static void DisplayGame(Game game)
        {
            Console.WriteLine(game);
        }
    }
}
