using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework1
{
    public class Animal
    {
        private string name;

        public Animal() { }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
    }
}
