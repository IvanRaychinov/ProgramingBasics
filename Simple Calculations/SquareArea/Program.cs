﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine(a * a);
        }
    }
}
