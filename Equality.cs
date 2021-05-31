using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Computation
{
    public class Equality
    {
       
        public void LineEquals()
        {
            
            

            Console.WriteLine("Enter the value for x1 coordinate:");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value for x2 coordinate:");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value for y1 coordinate:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value for y2 coordinate:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double LineOne = (double)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(LineOne);
            double LineTwo = (double)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(LineTwo);
            if (LineTwo == LineOne)
            {
                Console.WriteLine("Lines are Equal");
            }
            else
            {
                Console.WriteLine("Lines are not Equal");
            }
        }
    }
}
