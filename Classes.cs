using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Classes
    {
        /*public double length;
        public double breadth;
        public double height;*/

        //Constructor classes
        private double length;

        public Classes()//Constructor
        {
            Console.WriteLine("Object is created");
        }
        ~Classes()
        {
            Console.WriteLine("Object is destroyed");
        }
        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }


        static void Main(string[] args)
        {
            /*Classes b1 = new Classes();
            Classes b2 = new Classes();
            double volume = 0.0;

            b1.length = 3.0;
            b1.breadth = 7.0;
            b1.height = 6.0;

            b2.length = 12.0;
            b2.breadth = 16.0;
            b2.height = 15.0;

            volume = b1.length * b1.breadth * b1.height;
            Console.WriteLine("Volume of Box1:{0}", volume);

            volume = b2.length * b2.breadth * b2.height;
            Console.WriteLine("Volume of Box2:{0}", volume);*/
            Classes ob = new Classes();

            ob.setLength(3.7);
            Console.WriteLine("The length of the object is:{0}", ob.getLength());


        }
    }
}
