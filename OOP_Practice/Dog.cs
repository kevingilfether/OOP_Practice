﻿using System;
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
        private double weight;

        //Properties - In PascalCase
        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        public float Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public string RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        //Constructor
        public Dog()
        {

        }

        public Dog(string hairLength, float height)
        {
            this.hairLength = hairLength;
            this.height = height;
        }

        //Methods
        public void Run()
        {
            runningSpeed = "getting faster.";
            weight--;
        }

        public void Bark()
        {
            Console.WriteLine("\a");
        }

        public void Potty()
        {
            weight = weight -= 0.1;
        }

        public void Groom()
        {
            hairLength = "all cleaned up";
        }
    }
}
