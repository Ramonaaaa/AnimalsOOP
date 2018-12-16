using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework1
{
    public class Platypus : Mammals, ISwim, IWalk
    {
        private int maxWalkingSpeed;
        private int maxSwimmingSpeed;

        public void Hey()
        {
            Console.WriteLine("Hello! My name is Platybus and i am a mammal.");
            Console.WriteLine("I can do the following: ");
        }

        public int MaxWalkingSpeed
        {

            get
            {
                return this.maxWalkingSpeed;
            }
            set
            {
                if (value > 0)
                {
                    this.maxWalkingSpeed = value;
                }

            }
        }

        public int MaxSwimmingSpeed
        {
            get
            {
                return maxSwimmingSpeed;
            }
            set
            {
                maxSwimmingSpeed = value;
            }
        }


        public void Swim()
        {
            Console.WriteLine("- i can swim.");
        }

        public void Walk()
        {
            Console.WriteLine("- i can walk.");
        }
    }
}
