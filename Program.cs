using System;

namespace lineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {

            //Welcome message 
            Console.WriteLine("Welcome to Line Comparison Computation!");

            //Taking four sets of variables are used to check equality of the two lines
            int x1, x2, x3, x4, y1, y2, y3, y4;
            
            // Taking the coordinates for first point of line one
            Console.WriteLine("Enter the values of x1 and y1 coordinates of the line one");
           
            //Convert.ToInt32 is used to convert a value into 32bit specified integer
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
           
            // Taking the coordinates for second point of line one
            Console.WriteLine("Enter the values of x2 and y2 coordinates of the line one");

            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            // Taking the coordinates for first point of line two
            Console.WriteLine("Enter the values of x3 and y3 coordinates of the line two");

            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());

            // Taking the coordinates for second point of line two
            Console.WriteLine("Enter the values of x4 and y4 coordinates of the line two");

            x4 = Convert.ToInt32(Console.ReadLine());
            y4 = Convert.ToInt32(Console.ReadLine());

            //Calculating the length of line one
            double lengthOfLineOne = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of the line one is : " + lengthOfLineOne);

            //Calculating the length of line two
            double lengthOfLineTwo = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("Length of the line two is : " + lengthOfLineTwo);

            //CompareTo method is used to compare instance of length of line by returning value of instance
            //to be greater than,lesser than or equal
            int differenceInLength = lengthOfLineOne.CompareTo(lengthOfLineTwo);

            //Using if loop to check if the two lines are equal ,smaller than or greater than in length
            if (differenceInLength == 0)
                Console.WriteLine("Length of the two lines are equal.");
            else if (differenceInLength > 0)
                Console.WriteLine("Length of line one is greater than length of line two");
            else
                Console.WriteLine("Length of line two is greater than length of line one");

        }

    }

}
