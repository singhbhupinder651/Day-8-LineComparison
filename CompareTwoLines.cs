using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonNonStatic
{
    public class CompareTwoLines
    {
        public void CompareLines()
        {
            double lineOneLength, lineTwoLength;

            ModelALine lineOne = new ModelALine();
            lineOneLength = lineOne.LineLenght();
            Console.WriteLine("Length of Line One: " + lineOneLength);

            ModelALine lineTwo = new ModelALine();
            lineTwoLength = lineTwo.LineLenght();
            Console.WriteLine("Length of Line Two: " + lineTwoLength);


            //using CompareTo method to check which line is longer in length
            int result = lineOneLength.CompareTo(lineTwoLength);

            if (result > 0)
            {
                Console.WriteLine("Line one({0}) is greater than line two({1})", lineOneLength, lineTwoLength);
            }
            else if (result == 0)
            {
                Console.WriteLine("Line one is equal to line two");
            }
            else
            {
                Console.WriteLine("Line one({0}) is lesser than line two({1})", lineOneLength, lineTwoLength);
            }

        }
    }
}
