using System;

namespace MoreOnNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            string milesInput = Console.ReadLine();
            int milesDriven = int.Parse(milesInput);
            Console.WriteLine("How many gallons of gas have you consumed?");
            string gasInput = Console.ReadLine();
            int gasConsumed = int.Parse(gasInput);
            int milesPerGallon = milesDriven / gasConsumed;
            Console.WriteLine("You are getting " + milesPerGallon + " miles per gallon.");
        }
    }
}
