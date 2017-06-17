using System;
using System.Collections.Generic;

namespace Learning_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Is a keyword for System.Decimal
            decimal dec = 3.14159265359m;
            double dub = 3.14159265359;
            Console.WriteLine(dec.GetType());
            Console.WriteLine(sizeof(decimal));
            Console.WriteLine(dub.GetType());
            Console.WriteLine(sizeof(double));
            // TODO differences

            List<Task> tasks = new List<Task>();
            tasks.Add(new Formatting());
            tasks.Add(new Delegates());
            tasks.Add(new CovarianceAndContravariance());

            bool retry = true;

            do
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i,3}) {tasks[i]}");
                }
                int choice = int.Parse(Console.ReadLine());
                tasks[choice].Run();

                Console.WriteLine("\nRetry? (y/n)");
                retry = Console.ReadLine().ToLower().Equals("y");
            } while (retry);
        }
    }
}