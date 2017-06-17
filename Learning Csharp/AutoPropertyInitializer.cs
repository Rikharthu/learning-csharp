using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_Csharp
{
    class AutoPropertyInitializer : Task
    {
        // C#5 and below
        /*
        public string MyString { get; set; }
        public int MyInt { get; set; }

        public AutoPropertyInitializer()
        {
            MyString = "My Value";
            MyInt = 6;
        }
        */

        // C#6 Auto-Property Initializers
        // no need for setter, if not used anywhere else
        public string MyString { get; } = "My Value";
        public int MyInt { get; } = 6;

        public AutoPropertyInitializer()
        {
        }


        public override void Run()
        {

        }
    }
}
