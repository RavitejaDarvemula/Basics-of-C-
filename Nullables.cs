using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Nullables
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 14;

            double? num3 = new double?();
            double? num4 = 4.56;

            //null coalescing

            double num5 = num1 ?? 4.5;
            Console.WriteLine("Value of num5: {0}", num5);
            num5 = num2 ?? 5.9;
            Console.WriteLine("Value of num5: {0}", num5);



            bool? boolval = new bool?();
            Console.WriteLine("Nullables are:{0},{1},{2},{3}",num1,num2,num3,num4);
            Console.WriteLine("Boolean value is:{0}", boolval);

        }
    }
}
