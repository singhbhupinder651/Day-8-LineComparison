using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonNonStatic
{
    public class ModelALine
    {
        public double LineLenght()
        {
            Random random = new Random();
            int x1 = random.Next(0, 21);
            int y1 = random.Next(0, 21);
            int x2 = random.Next(0, 21);
            int y2 = random.Next(21, 41);

            double SqrXVal = Math.Pow((x2 - x1), 2);
            double SqrYVal = Math.Pow((y2 - y1), 2);
            double length = Math.Sqrt(SqrXVal + SqrYVal);

            return length;
        }
    }
}
