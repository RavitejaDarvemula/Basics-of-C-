#define PI 
using System;

namespace Practice
{
    class PreprocessorDirectives
    {
        static void Main(string[] args)
        {
        #if (PI)
            Console.WriteLine("PI is defined");
        #else
            Console.WriteLine("PI is not defined");
        #endif
        }
    }
}