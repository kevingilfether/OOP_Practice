using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    class Dog
    {
        //fields - In camelCase
        private string hairLength;
        private float height;
        private string runningSpeed;
        private int weight;

        //Properties - In PascalCase
        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        public Dog()
        {

        }


        public void Run()
        {

        }

        public void Bark()
        {

        }
        public void Potty()
        {

        }
        public void Cuddle()
        {

        }

    }
}
