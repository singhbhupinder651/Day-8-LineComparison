using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonNonStatic
{
    public class CheckEquality
    {
        public void CompareTwoLines()
        {
            double lineOneLength, lineTwoLength;

            ModelALine lineOne = new ModelALine();
            lineOneLength = lineOne.LineLenght();
            Console.WriteLine("Length of Line One: " + lineOneLength);

            ModelALine lineTwo = new ModelALine();
            lineTwoLength = lineTwo.LineLenght();
            Console.WriteLine("Length of Line Two: " + lineTwoLength);

            //checking equality using Equals method in C#
            bool checkEquality = lineOneLength.Equals(lineTwoLength);

            if (checkEquality)
            {
                Console.WriteLine("Both lines are equal in length.");
            }
            else
            {
                Console.WriteLine("They are not equal in lenght.");
            }
        }
    }
}
