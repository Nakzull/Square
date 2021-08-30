using System;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("side = ");
            int side = Convert.ToInt32(Console.ReadLine());
            Square square = new Square(side);
            Console.WriteLine("Perimeter = " + square.Perimeter(side) + "\nArea = " + square.Area(side));
        }
    }
}
