using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblems
{
    public static class EquOfTwoLine
    {
        public static void Check(double a1 = -2, double b1 = 4, double c1 = 9, double a2 = -6, double b2 = 12, double c2 = 2)
        {
            if (a1 / a2 == b1 / b2)
            {
                Console.WriteLine("The a1 & b1 lines are Equal");
            }
            else if (a1 / a2 == c1 / c2)
            {
                Console.WriteLine("The a1 & c1 lines are Equal");
            }
            else if (b1 / b2 == c1 / c2)
            {
                Console.WriteLine("The b1 & c1 lines are Equal");
            }
            else
            {
                Console.WriteLine("The given lines are not Equal");
            }
        }
    }
}

