﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
    public class Car
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public Car(string name, int year)
        {
            Name = name;
            Year = year;
        }
    }
}
