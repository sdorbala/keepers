using System;

namespace challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] weights = { 100, 200, 150, 80, 25, 75, 25, 90 };
            int limit = 200;
            Console.WriteLine("Number of boats needed = " + RescueBoats.NumberOfBoats(weights, limit));
        }
    }
}
