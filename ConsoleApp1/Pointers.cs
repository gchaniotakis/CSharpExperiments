using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExperiments
{
    public class Pointers
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Pointers(int x, int y)
        {
            X = x;
            Y = y;
        }

        public unsafe void PrintPointers()
        {
            var x = X;
            var y = Y;
            var xPtr = &x;
            var yPtr = &y;

            Console.WriteLine((int)xPtr);
            Console.WriteLine((int)yPtr);
            Console.WriteLine(*xPtr);
            Console.WriteLine(*yPtr);
        }
    }
}
