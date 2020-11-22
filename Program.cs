using System;

namespace lineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Line Comparison Computation!");
            int x1, x2;
            int y1, y2;

            // Taking the coordinates for first point of line
            Console.WriteLine("Enter the values of x1 and y1 coordinates of the line");
           
            //Convert.ToInt32 is used to convert a value into 32bit specified integer
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
           
            // Taking the coordinates for second point of line
            Console.WriteLine("Enter the values of x2 and y2 coordinates of the line");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
           
            //Calculating the length of line
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of the line is : " + length);

        }
    }
}
