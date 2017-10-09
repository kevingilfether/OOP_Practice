using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    class Superhero
    {
        //fields
        bool isVisible;
        string name;
        string alignment;
        int powerLevel;

        //Properties
        public bool IsVisible
        {
            get { return this.isVisible; }
            set { this.isVisible = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Alignment
        {
            get { return this.alignment; }
        }

        public int PowerLevel
        {
            get { return this.powerLevel; }
            set { this.powerLevel = value; }
        }


        //Constructors
        public Superhero()
        {

        }

        public Superhero(bool isVisible, string name, string alignment)
        {
            this.isVisible = isVisible;
            this.name = name;
            this.alignment = alignment;
        }

        public Superhero(string alignment, int powerLevel)
        {
            this.alignment = alignment;
            this.powerLevel = powerLevel;
        }

        //Other Methods

        public void Shouts()
        {
            powerLevel = 9001;
        }

        public void WalksThroughDustCloud()
        {
            isVisible = true;
        }

        public void HeroicTurn(string newAlignment)
        {
            alignment = newAlignment;
        }

        public void NewIdentity(string newName)
        {
            name = newName;
        }

    }
}
