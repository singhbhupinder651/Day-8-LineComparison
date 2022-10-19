using System;

namespace LineComparisonNonStatic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.WriteLine("Use Case #1: Model a Line and Calculate Length");
            Console.WriteLine("Use Case #2: Check Equality of Two Lines");
            Console.WriteLine("Use Case #3: Compare Two Lines");

            Console.Write("Choose a use case number to run the program: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ModelALine line = new ModelALine();
                    double lineLength = line.LineLenght();
                    Console.WriteLine("Length of line: " + lineLength);
                    break;
                case 2:
                    CheckEquality checkEquality = new CheckEquality();
                    checkEquality.CompareTwoLines();
                    break;
                case 3:
                    CompareTwoLines compareTwoLines = new CompareTwoLines();
                    compareTwoLines.CompareLines();
                    break;
                default:
                    Console.WriteLine("Please enter a valid use case number!");
                    break;
            }
        }
    }
}