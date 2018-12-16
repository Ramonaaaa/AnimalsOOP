using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework1
{
    public class LadyBug : Insect, IFly, IWalk
    {
        private int maxFlyingSpeed;
        private int maxWalk;

        public int MaxFlyingSpeed
        {
            get
            {
                return this.maxFlyingSpeed;
            }
            set
            {
                this.maxFlyingSpeed = value;
            }
        }

        public int MaxWalkingSpeed
        {
            get
            {
                return this.maxWalk;
            }
            set
            {
                this.maxWalk = value;
            }
        }

        public void Fly()
        {
            Console.WriteLine("The best thing i can do is to fly.");
        }

        public override string ToString()
        {
            return "Hey there! My name is " + this.Name + " and i am an insect. " +
                "\nMy maximum flying speed is " + this.MaxFlyingSpeed + " km/h. " +
                "\nMy maximum walking speed is " + this.maxWalk + " km/h.";
        }

        public void Walk()
        {
            throw new NotImplementedException();
        }
    }
}
