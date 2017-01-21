﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //x1, y1, x2, y2, x и y (като се гарантира, че x1 < x2 и y1 < y2
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            if (x1 < x2 && y1 < y2)
            {
                if (((x == x1 || x == x2) && (y > y1 && y < y2)) || ((x > x1 && x < x2) && (y == y1 || y == y2)) || ((x == x1 || x == x2) && (y == y1 || y == y2)))
                {
                    Console.WriteLine("Border");
                }
                else
                {
                    Console.WriteLine("Inside / Outside");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
