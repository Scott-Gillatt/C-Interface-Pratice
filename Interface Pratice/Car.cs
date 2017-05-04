﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Pratice
{
    public class Car : IMachine
    {
        public string Name { get; set; }

        public void Start()
        {
            Console.WriteLine($"The {Name} started!");
        }

        public void End()
        {
            Console.WriteLine($"The {Name} Turned Off");
        }
    }
}
