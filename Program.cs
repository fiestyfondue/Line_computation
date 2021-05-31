using System;

namespace Line_Computation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Length length = new Length();
            length.FindLength();

            Equality eq = new Equality();
            eq.LineEquals();
        }
     

    }
}
