using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Computation
{
    class Length
    {
        public void FindLength()
        {
            double distance;
            Console.WriteLine("Enter the values of x1,x2,y1,y2 respectively");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double x2 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());
            double y2 = Convert.ToInt32(Console.ReadLine());

            distance = (double)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(distance);
        }
    }
}
