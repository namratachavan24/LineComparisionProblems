using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblems
{
    public class CompareTwoLines
    {
        public static void display(int x1, int y1, int x2, int y2)
        {

            {
                int le1, le2;
                if (x1 == x2)
                {
                    int comp = y1.CompareTo(y2);
                    if (comp == 0)
                    {
                        Console.WriteLine("Both line are equals");
                    }
                    else if (comp >= 0)
                    {
                        Console.WriteLine("Second line is Smaller than first");
                    }
                    else
                    {
                        Console.WriteLine("Second line is bigger than First");
                    }
                }
                else
                {
                    le1 = y1 - x1;
                    le2 = y2 - x2;
                    int comp = le1.CompareTo(le2);
                    if (comp == 0)
                    {
                        Console.WriteLine("Both line are equals");
                    }
                    else if (comp >= 0)
                    {
                        Console.WriteLine("Second line is Smaller than first");
                    }
                    else
                    {
                        Console.WriteLine("Second line is bigger than First");
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}