using Learning_Csharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Learning_Csharp.Tasks.Extensions;

namespace Learning_Csharp
{
    class Extensions : Task
    {
        /*
         * Extension methods enable you to "add" methods to existing types without creating a new derived type,
         * recompiling, or otherwise modifying the original type. These are a special kind of static method, but
         * they are called as if they were instance methods on the extended type.
         */

        public override void Run()
        {
            // An example are LINQ standard query operators (using System.Linq) that add query 
            // functionality to the existing IEnumerable(OrderBy, GroupBy and etc)
            int[] ints = { 10, 45, 15, 39, 21, 26 };
            var result = ints.OrderBy(g => g); // Extension method from System.Linq
            // from source:
            // public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector);
            foreach (var i in result)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();

            // Use our string extension method
            String text = "Hello Extension Methods";
            int count = text.WordCount(); // from MyExtensions
            System.Console.Write(String.Format("Phrase \"{0}\" has {1} words\n", text, count));

            // Declare an instance of class A, class B, and class C.
            A a = new A();
            B b = new B();
            C c = new C();

            // For a, b, and c, call the following methods:
            //      -- MethodA with an int argument
            //      -- MethodA with a string argument
            //      -- MethodB with no argument.

            // A contains no MethodA, so each call to MethodA resolves to 
            // the extension method that has a matching signature.
            a.MethodA(1);           // Extension.MethodA(object, int)
            a.MethodA("hello");     // Extension.MethodA(object, string)

            // A has a method that matches the signature of the following call
            // to MethodB.
            a.MethodB();            // A.MethodB()

            // B has methods that match the signatures of the following
            // method calls.
            b.MethodA(1);           // B.MethodA(int)
            b.MethodB();            // B.MethodB()

            // B has no matching method for the following call, but 
            // class Extension does.
            b.MethodA("hello");     // Extension.MethodA(object, string)

            // C contains an instance method that matches each of the following
            // method calls.
            c.MethodA(1);           // C.MethodA(object)
            c.MethodA("hello");     // C.MethodA(object)
            c.MethodB();            // C.MethodB()
        }
    }
}
