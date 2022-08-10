using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblems
{
    public static class CartesianSystem
    {
        public static double length(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) * 1.0);
        }
        public static void main()
        {
            Console.WriteLine("Calculation of length :" + (Math.Round(length(8, 4, 5, 3) * 100000.0) / 100000.0));
        }
    }
}
