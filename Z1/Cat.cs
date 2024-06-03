﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Z1
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        public new void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
