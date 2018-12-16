using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework1
{
    public class Snake : Reptile, ICrawl, ISwim
    {
        private int maxCrawlSpeed;
        private int maxSwim;

        public int MaxSwimmingSpeed
        {
            get
            {
                return this.maxCrawlSpeed;
            }
            set
            {
                this.maxCrawlSpeed = value;
            }
        }
        public int MaxSpeed
        {
            get
            {
                return this.maxSwim;
            }
            set
            {
                this.maxSwim = value;
            }
        }

        public void Hi()
        {
            Console.WriteLine("Hi there! My name is Snake and i am a reptile.");
            Console.WriteLine("I can do the following: ");
        }
        public void Crawl()
        {
            Console.WriteLine("- i can crawl;");
        }

        public void Swim()
        {
            Console.WriteLine("- i can swim;");
        }
    }
}
