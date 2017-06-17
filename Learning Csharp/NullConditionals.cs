using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_Csharp
{
    class NullConditionals : Task
    {
        public override void Run()
        {
            // Null Conditional Operator and Null Propagatio

            //string valueNull = "Has a value";
            string valueNull = null;

            // C#5 and below
            Console.WriteLine(valueNull != null ? valueNull : "It is null");

            // C#6
            Console.WriteLine(valueNull ?? "It is null");

        }
    }
}
