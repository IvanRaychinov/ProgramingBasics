﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side a: ");
            var a = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter side b: ");
            var b = decimal.Parse(Console.ReadLine());

            var area = a * b;

            Console.WriteLine("Area: " + area);
        }
    }
}
