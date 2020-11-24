using System;

namespace lineComparisonProblem
{
    class Program
    {
        //Method to find the distance between the end points
        public static double EndPointsDistance()
        {
            Console.WriteLine("Enter the value of first point and second point");
            double pointOne = Convert.ToDouble(Console.ReadLine());
            double pointTwo = Convert.ToDouble(Console.ReadLine());
            double distanceBetweenPoints = Math.Pow((pointTwo - pointOne), 2);
            return distanceBetweenPoints;
        }

        //Method to find the length of the line
        public static double LengthOfLine()
        {
           double xCoordinate = EndPointsDistance();
           double yCoordinate = EndPointsDistance();
           double lengthOfLine = Math.Sqrt(xCoordinate + yCoordinate);
            return lengthOfLine;
        }

        //Method to compare the lengths of the two lines
        public static int ComparingLengthOfLines(double lengthOfLineOne, double lengthOfLineTwo) 
        {
            int differenceInLength = lengthOfLineOne.CompareTo(lengthOfLineTwo);
            if (differenceInLength == 0)
                Console.WriteLine("Length of the two lines are equal.");
            else if (differenceInLength > 0)
                Console.WriteLine("Length of line one is greater than length of line two");
            else
                Console.WriteLine("Length of line two is greater than length of line one");

            return differenceInLength;
           
        }

        static void Main(string[] args)
        {

            //Welcome message 
            Console.WriteLine("Welcome to Line Comparison Computation!");   
            
            //Calling the method to calculate the length of the line
            double lengthOfLineOne = LengthOfLine();
            Console.WriteLine("The length of line one : " + lengthOfLineOne);
            double lengthOfLineTwo = LengthOfLine();
            Console.WriteLine("The length of line two : " + lengthOfLineTwo);

            //Calling the method to compare the length of the lines
            int comparingLines = ComparingLengthOfLines(lengthOfLineOne, lengthOfLineTwo);
           
        }

    }

}
