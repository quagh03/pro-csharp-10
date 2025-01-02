// This is after C# 9
// Rules around using top-level statements
// ONLY ONE file in the application can use top-level statements
// When using top-level statements, program cannot have a declared entry point 
// Cannot be enclosed in a namespaces
// Still access a string array of args
// return an application code by using return
             
// Console.WriteLine("Hello World!");


//This is before C# 9. Below are required code to print a String
//implicit global namespaces provided by .NET6/C#10 the using system; Statement is no longer needed
using System;

// Creates a custom namespaces to wrap Program class. Both this can be removed due to the top-level statement functionality introduced in C# 9
namespace chap3_core_csharp_constructs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# application");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}