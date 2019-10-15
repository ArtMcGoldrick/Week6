using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    //This class is for storing all the details about games
    public abstract class Game
    {
        //This is the properties setting up for the constructors
        protected decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        private readonly string Name;
        public string _name { get { return Name; } }


        //This is the constuctors linking to each other or intializing(also places values in)
        public Game(string name, decimal price, DateTime releasedate)
        {
            Name = name;
            Price = price;
            ReleaseDate = releasedate;
        }
        public Game(string name, decimal price) : this(name, price, DateTime.Now) { }
        public Game() : this("", 0) { }


        //This method is for returning all values in a string 
        public override string ToString()
        {
            return $"The name is {Name}, the price is {Price}, the date is {ReleaseDate}.";
        }

        //Takes percent then amends
        public abstract void UpdatePrice(decimal percentageIncrease)
        //{
        //    Price *= (1 + percentageIncrease);
        //}
    }//End of class


    //This class is for PEGI rating and for discount
    class ComputerGame : Game
    {
        public string PEGI_Rating { get; set; }
        public ComputerGame(string name, decimal price, DateTime date, string pegi) : base(name, price, date)
        {
            PEGI_Rating = pegi;
        }

        //This is for discounts
        public decimal GetDiscountPrice()
        {
            return Price * .9m;
        }


        //This method is for returning all values in a string (+pegi)
        public override string ToString()
        {
            return string.Format($"{base.ToString()} PEGI {PEGI_Rating}");
        }


        //Takes percent then amends
        public override void UpdatePrice(decimal percentageIncrease)
        {
            Price *= (1 + percentageIncrease);
            Console.WriteLine("Updating the price");
        }

    }
}
