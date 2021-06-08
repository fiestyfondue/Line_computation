using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Computation
{
    class LineCompare
    {
        public void CompareLines()
        {
            Length findLength1 = new Length(-7, 17, -4, 6);
            Length findLength2 = new Length(-7, 17, -4, 2);
            double LengthOfLine1 = findLength1.Len();
            double LengthOfLine2 = findLength2.Len();
            Compare2Lengths(LengthOfLine1, LengthOfLine2);
        }
        private void Compare2Lengths(double LengthOfLine1, double LengthOfLine2)
        {
            if (LengthOfLine1 == LengthOfLine2)
                Console.WriteLine($"Length of line1 {LengthOfLine1} is equal to Length of Line2 {LengthOfLine2}");
            else if (LengthOfLine1 > LengthOfLine2)
                Console.WriteLine($"Length of line1 {LengthOfLine1} is greater than Length of Line2 {LengthOfLine2}");
            else
                Console.WriteLine($"Length of line1 {LengthOfLine1} is less than Length of Line2 {LengthOfLine2}");
        }
    }
}
