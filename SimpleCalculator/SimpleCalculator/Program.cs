﻿using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clean Calculator");
            var CalculatorDriver = new CalculatorDriver();
            CalculatorDriver.Run(); 
            Console.WriteLine("Thank you for Calculating!");
            Console.ReadKey();

        }
    }
}
