using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_Csharp
{
    public abstract class Task
    {
        public abstract void Run();
        public string getName() => this.GetType().Name;
    }
}
