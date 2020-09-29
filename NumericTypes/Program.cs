using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input rectangle length:");
            string rectLengthInput = Console.ReadLine();
            int rectLength = int.Parse(rectLengthInput);
            Console.WriteLine("Please input rectangle width:");
            string rectWidthInput = Console.ReadLine();
            int rectWidth = int.Parse(rectWidthInput);
            int rectArea = rectLength * rectWidth;
            Console.WriteLine("The area of the rectangle is " + rectArea);
        }
    }
}
