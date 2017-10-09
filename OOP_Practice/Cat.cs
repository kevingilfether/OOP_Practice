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

    }
}
