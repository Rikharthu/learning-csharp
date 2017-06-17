using Learning_Csharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_Csharp
{
    class CovarianceAndContravariance : Task
    {
        public override void Run()
        {
            // Assignment compatibility.   
            string str = "test";
            // An object of a more derived type is assigned to an object of a less derived type.   
            object obj = str;

            // Covariance.   
            IEnumerable<string> strings = new List<string>();
            // An object that is instantiated with a more derived type argument   
            // is assigned to an object instantiated with a less derived type argument.   
            // Assignment compatibility is preserved.   
            IEnumerable<object> objects = strings;

            // Contravariance.             
            // Assume that the following method is in the class:   
            // static void SetObject(object o) { }   
            Action<object> actObject = SetObject;
            // An object that is instantiated with a less derived type argument   
            // is assigned to an object instantiated with a more derived type argument.   
            // Assignment compatibility is reversed.   
            Action<string> actString = actObject;

            actString("asd");


            // Covariance. A delegate specifies a return type as object,  
            // but you can assign a method that returns a string.  
            Func<object> del = GetString;

            // Contravariance. A delegate specifies a parameter type as string,  
            // but you can assign a method that takes an object.  
            Action<string> del2 = SetObject;

        }

        static object GetObject() { return null; }
        static void SetObject(object obj) { }

        static string GetString() { return ""; }
        static void SetString(string str) { }
    }
}
