using System;
using System.Collections.Generic;
using System.Text;

namespace Print1ToN
{
    internal class Rectangle
    {
        static void area(int length,int width)
        {

            Console.WriteLine("The area of rectangle is "+(length*width));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter width");
            int width = int.Parse(Console.ReadLine());

            area(length, width);
            Console.ReadLine();
        }

    }
}
