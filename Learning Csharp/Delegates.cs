using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_Csharp
{
    ///<summary>
    /// A delegate is a type that safely encapsulates a method, 
    /// similar to a function pointer in C and C++. Unlike C function pointers, 
    /// delegates are object-oriented, type safe, and secure. The type of a 
    /// delegate is defined by the name of the delegate.
    ///</summary>
    class Delegates : Task
    {
        // declares a delegate that can encapsulate a method that takes a string as an argument and returns void
        public delegate void Del(string message);

        // A method that matches our Del delegate parameters (accepts string, returns void)
        public static void DelegateMethod(string message)
        {
            Console.WriteLine($"from DelegateMethod: {message}");
        }

        public void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }

        public override void Run()
        {
            // Using the delegate:
            // 1. imitialization with a named method
            Del handler = DelegateMethod;
            handler("Hello, World!");
            // P.S. you can actually do this too:
            Del writeLine = Console.WriteLine;
            writeLine("Hallo!");

            // 2. anonymous method
            Del del2 = delegate (string s) { Console.WriteLine($"from anonymous method: {s}"); };
            del2("Hello, World!");

            // 3. lambda expression
            Del lambdaDelegate = (str) => { Console.WriteLine($"from lambda delegate: {str}"); };
            lambdaDelegate("Hello, World!");

            // Callbacks:
            MethodWithCallback(1, 2, lambdaDelegate);
            MethodWithCallback(1, 2, Console.WriteLine);
            // lambda
            MethodWithCallback(1, 2, s=>Console.WriteLine(s));
        }
    }
}
