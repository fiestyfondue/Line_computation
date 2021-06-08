using System;

namespace Line_Computation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Length length = new Length(4, 4, 6,7);
            length.Len();

            LineCompare eq = new LineCompare();
            eq.CompareLines();
        }
     

    }
}
