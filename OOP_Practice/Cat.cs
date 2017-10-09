using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    class Cat
    {
        //States
        //fields
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;

        //properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
            // Like a bouncer or a mama bear -- the intermediator
        }

        //Behaviors


        //Constructors
        public Cat()
        {
            //default constructor --
            //takes not parameters

        }
        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

        //Classes also have methods

        public void Eat()
        {
            if (isHungry == true)
            {
                isHungry = false;
            }

            Console.WriteLine("Is the cat hungry? " + isHungry);
        }

        public void WorkOut()
        {
            if (isHungry == false)
            {
                isHungry = true;
            }

            Console.WriteLine("The cat worked out. Hungry now? " + isHungry);
        }


    }
}
