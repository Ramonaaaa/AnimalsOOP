using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework1
{
    public class Salmon : Animal, ISwim
    {
        private int maxSwimmingSpeed;

        public void Hello()
        {
            Console.WriteLine("Hello! My name is Solmon and i am a fish.");
            Console.WriteLine("The best thing i can do is to: ");
        }

        public int MaxSwimmingSpeed
        {
            get
            {
                return this.maxSwimmingSpeed;
            }
            set
            {
                this.maxSwimmingSpeed = value;
            }
        }

        public void Swim()
        {
            Console.WriteLine("- swim.");
        }
    }
}
