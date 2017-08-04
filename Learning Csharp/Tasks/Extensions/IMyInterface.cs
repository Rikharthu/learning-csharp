using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_Csharp.Tasks.Extensions
{
    // You can use extension methods to extend a class or interface, but not to override them. 
    // An extension method with the same name and signature as an interface or class method will 
    // never be called. At compile time, extension methods always have lower priority than instance
    // methods defined in the type itself. In other words, if a type has a method named Process(int i), 
    // and you have an extension method with the same signature, the compiler will always bind to the instance method

    // When the compiler cannot find an instance method with a matching signature, 
    // it will bind to a matching extension method if one exists.

    // See MyExtensions
    public interface IMyInterface
    {
        void MethodB();
    }

    class A : IMyInterface
    {
        public void MethodB() { Console.WriteLine("A.MethodB()"); }
    }

    class B : IMyInterface
    {
        public void MethodB() { Console.WriteLine("B.MethodB()"); }
        public void MethodA(int i) { Console.WriteLine("B.MethodA(int i)"); }
    }

    class C : IMyInterface
    {
        public void MethodB() { Console.WriteLine("C.MethodB()"); }
        public void MethodA(object obj)
        {
            Console.WriteLine("C.MethodA(object obj)");
        }
    }

}
