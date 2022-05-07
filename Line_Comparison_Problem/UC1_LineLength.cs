using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparison_Problem
{
    internal class UC1_LineLength
    {
        public static int x1;
        public static int x2;
        public static int y1;
        public static int y2;
        public static void points()

        {
            Console.WriteLine("\nUC1");

            Console.WriteLine("Enter the coordinates value for points");
            Console.WriteLine("Enter coordinate x for point1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate y for point1");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate x for point2");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate y for point2");
            y2 = Convert.ToInt32(Console.ReadLine());
        }
        public static void LineLength()
        {
            double value;
            points();
            double z = ((x1 * x1 - x2 * x2) + (y1 * y1 - y2 * y2));
            if (z < 0)
            {
                value = z * (-1);
            }
            else
            {
                value = z;
            }
            double length = Math.Sqrt(value);
            Console.WriteLine("Length of line is : {0} units", length);
        }
    }
}
