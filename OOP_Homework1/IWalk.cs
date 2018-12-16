using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework1
{
    interface IWalk
    {
        void Walk();
        int MaxWalkingSpeed { get; set; }
    }
}
