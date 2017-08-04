using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_Csharp.Tasks.Structs
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point(int x=0, int y=0, int z=0)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
