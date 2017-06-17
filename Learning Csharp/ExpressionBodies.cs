using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_Csharp
{
    class ExpressionBodies : Task
    {
        public string FirstName { get; } = "John";
        public string LastName { get; } = "Wick";

        // Calculated properties:
        // C#5
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        // C#6 - uses lambda expressions
        public string FullName2 => FirstName + " " + LastName;

        // C#6 bodies methods
        private double add(double v, double a) => v + a;

        public override void Run()
        {
            Console.WriteLine(FullName);
            Console.WriteLine(FullName2);
            Console.WriteLine(add(3, 4));
        }
    }
}
