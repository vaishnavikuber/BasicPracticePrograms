using System;
using System.Collections.Generic;
using System.Text;

namespace Print1ToN
{
    internal class Calculator
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter two numbers");
            int a=Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition of " + a + " and " + b + " is " + (a + b));
            Console.WriteLine("Substraction of " + a + " and " + b + " is " + (a - b));
            Console.WriteLine("Multiplication of " + a + " and " + b + " is " + (a * b));
            Console.WriteLine("Division of " + a + " and " + b + " is " + (a / b));
            Console.WriteLine("Modulus of " + a + " and " + b + " is " + (a % b));
        }
    }
}
