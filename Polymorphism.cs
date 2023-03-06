using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Polymorphism
    {
        void print(int i)
        {
            Console.WriteLine("Printing int:{0}", i);
        }
        void print(double f)
        {
            Console.WriteLine("Printing double:{0}", f);
        }
        void print(string s)
        {
            Console.WriteLine("Printing string:{0}", s);
        }
        static void Main(string[] args)
        {
            Polymorphism p = new Polymorphism();

            p.print(2);
            p.print(3.4);
            p.print("Hello");
        }
    }
}
