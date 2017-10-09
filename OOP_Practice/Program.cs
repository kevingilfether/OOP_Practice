using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rando = new Random(); // makes new random object
            rando.Next(3, 30);

            Cat mittens = new Cat();
            mittens.Name = "Mittens";
            //Constructs Cat, uses the property to name cat "Mittens"\
            

            Cat cara = new Cat();
            cara.furColor = "Tortoiseshell";
            //"furColor" is private, so the program can't interact with it.
            //After making overloaded constructor, then 



        }
    }
}
