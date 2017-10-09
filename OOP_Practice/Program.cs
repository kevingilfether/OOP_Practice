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
            //Random rando = new Random(); // makes new random object
            //rando.Next(3, 30);

            //Cat mittens = new Cat();
            //mittens.Name = "Mittens";
            ////Constructs Cat, uses the property to name cat "Mittens"\


            //Cat cara = new Cat();
            ////cara.furColor = "Tortoiseshell";
            ////"furColor" is private, so the program can't interact with it.
            ////After making overloaded constructor, thennnnn:

            //Cat karma = new Cat("Karma", 4, "tortoiseshell");
            ////This is using the overloaded constructor 

            //Console.WriteLine(mittens.Name);
            //Console.WriteLine(karma.Name);

            //karma.Eat();
            //karma.Eat();

            //karma.WorkOut();


            //Dog firstDoge = new Dog();

            //firstDoge.Weight = 60.00;
            //firstDoge.Height = 3.2f;
            //firstDoge.HairLength = "Flowing Main";
            //firstDoge.RunningSpeed = "will fetch ... eventually";

            //firstDoge.Groom();
            //Console.WriteLine(firstDoge.HairLength);

            //firstDoge.Run();
            //Console.WriteLine("The dog now weighs " + firstDoge.Weight);
            //firstDoge.Bark();

            Dog secondDoge = new Dog("fluffy", 4.04f);

            Console.WriteLine(secondDoge.HairLength);

            secondDoge.Groom();

            Console.WriteLine(secondDoge.HairLength);

            secondDoge.RunningSpeed = "faster than lightning";

            secondDoge.Run();

            Console.WriteLine(secondDoge.RunningSpeed);

            secondDoge.Weight = 78.9;

            Console.WriteLine(secondDoge.Weight);

            secondDoge.Bark();


        }
    }
}
