using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //Access specifiers
    class Rectangle
    {
        // public double length;
        //public double width;


        //private double length;
        //private double width;

        internal double length;
        internal double width;

        /*public void AcceptDetails()
        {
            Console.WriteLine("Enter the length ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Width ");
            width = Convert.ToDouble(Console.ReadLine());
        }*/

         double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length:{0}", length);
            Console.WriteLine("Width:{0}", width);
            Console.WriteLine("Area:{0}", GetArea());
        }
    }
    class Encapsulation
    {
        static void Main(string [] args)
        {
            Rectangle ob = new Rectangle();
            ob.length = 2.5;
            ob.width = 3.6;
            //ob.AcceptDetails();
            ob.Display();
        }
    }
}
