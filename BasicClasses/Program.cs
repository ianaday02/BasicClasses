using System;

namespace BasicClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Year = 2018;
            myCar.Make = "Mazda";
            myCar.Model = "CX-5";

            Console.WriteLine($"I love going on road trips in my {myCar.Year} {myCar.Make} {myCar.Model}!");
        }
    }
}