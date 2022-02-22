using System;
using System.Linq;

namespace CoureConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(PointsForArray(new[] { 1, 2, 3, 4, 5 }));
            Console.WriteLine(PointsForArray(new[] { 15, 25, 35 })); 
            Console.WriteLine(PointsForArray(new[] { 8, 8 })); 
        }
        static int CalculatePoints(int n)
        {
            int pointsForEight = n switch
            {
                8 => 5,
                _ => 0
            };
            int pointsForParity = n % 2 == 0 ? 1 : 3;
            return pointsForEight + pointsForParity;
        }

        static int PointsForArray(int[] array)
        {
            return array.Aggregate(0, (sum, current) => sum + CalculatePoints(current));
        }


    }
}
