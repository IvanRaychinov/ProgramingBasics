﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            double x = Math.Max(x1, x2) - Math.Min(x1, x2);
            double y = Math.Max(y1, y2) - Math.Min(y1, y2);

            Console.WriteLine("{0}\n{1}", x * y, 2 * (x + y));
        }
    }
}
