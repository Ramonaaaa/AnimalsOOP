using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework1
{
    public class WildDuck : Birds, IWalk, ISwim, IFly
    {
        private int maximumWalkingSpeed;
        private int maximumSwimSpeed;
        private int maximumFlySpeed;


        public void Hola()
        {
            Console.WriteLine("Hello! My name is Wild Duck and i am a bird.");
            Console.WriteLine("I can do the following: ");
        }

        public int MaxWalkingSpeed
        {
            get
            {
                return this.maximumWalkingSpeed;
            }
            set
            {
                this.maximumWalkingSpeed = value;
            }
        }
        public int MaxSwimmingSpeed
        {
            get
            {
                return this.maximumSwimSpeed;
            }
            set
            {
                this.maximumSwimSpeed = value;
            }
        }
        public int MaxFlyingSpeed
        {
            get
            {
                return this.maximumFlySpeed;
            }
            set
            {
                this.maximumFlySpeed = value;
            }
        }

        public void Fly()
        {
            Console.WriteLine("- i can fly;");
        }

        public void Swim()
        {
            Console.WriteLine("- i can swim;");
        }

        public void Walk()
        {
            Console.WriteLine("- i can walk;");
        }
    }

}
