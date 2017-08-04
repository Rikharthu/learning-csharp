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
        // Handy shortcut for console writeline
        Action<string> cw = Console.WriteLine;


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

        // You can use built-in Action<>() instead of creating custom delegates all over the place
        public void MethodWithActionCallback(int param1, int param2, Action<string> callback)
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
            MethodWithCallback(1, 2, s => Console.WriteLine(s));

            MethodWithCallback(1, 2, delegate (string message)
            {
                Console.WriteLine("Anonymous delegate: " + message);
            });

            MethodWithActionCallback(1, 2, (str) => { Console.WriteLine(str); });

            Action<string> writeAction = new Action<string>((str)=>Console.WriteLine(str));
            Action<string> actionDelegateWrapper = new Action<string>(del2);

            MethodWithActionCallback(1, 2, writeAction);
            MethodWithActionCallback(1, 2, actionDelegateWrapper);

            cw("Using cw instead of Console.WriteLine()");
        }
    }
}
