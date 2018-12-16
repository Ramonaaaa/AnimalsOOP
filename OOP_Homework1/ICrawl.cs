using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework1
{
    interface ICrawl
    {
        void Crawl();
        int MaxSpeed { get; set; }
    }
}
