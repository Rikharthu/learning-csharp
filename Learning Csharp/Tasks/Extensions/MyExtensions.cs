using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_Csharp.Tasks.Extensions
{
    // Class containt extension methods must be static
    public static class MyExtensions
    {
        // You can use extension methods to extend a class or interface, but not to override them. 
        // An extension method with the same name and signature as an interface or class method will 
        // never be called. At compile time, extension methods always have lower priority than instance
        // methods defined in the type itself. In other words, if a type has a method named Process(int i), 
        // and you have an extension method with the same signature, the compiler will always bind to the instance method

        // Extension methods are defined as static methods but are called using instance method syntax
        // Their first parameter specifies which type the method operates on, and preceded by the "this" keyword
        // They are in scope only when you explicitly import the namespace into your source code with a "using" directive

        // Create an extension method for the string class
        public static int WordCount(this String str)
        {
            Console.WriteLine("Called WordCount() on " + str);
            // parameter 'this String str' is an actual object instance upon which this extension method is called

            return str.Split(new char[] { ' ', '.', ',', '?', '!' },
                StringSplitOptions.RemoveEmptyEntries).Length;


        }

        public static void MethodA(this IMyInterface myInterface, int i)
        {
            Console.WriteLine
                ("Extension.MethodA(this IMyInterface myInterface, int i)");
        }

        public static void MethodA(this IMyInterface myInterface, string s)
        {
            Console.WriteLine
                ("Extension.MethodA(this IMyInterface myInterface, string s)");
        }

        // This method is never called in ExtensionMethodsDemo1, because each 
        // of the three classes A, B, and C implements a method named MethodB
        // that has a matching signature.
        public static void MethodB(this IMyInterface myInterface)
        {
            Console.WriteLine
                ("Extension.MethodB(this IMyInterface myInterface)");
        }

    }
}
