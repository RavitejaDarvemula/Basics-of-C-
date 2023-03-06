using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Loops
    {
        static void Main(String[] args)
        {
            //while
            /*int a = 10;
            while (a < 20)
            {
                Console.WriteLine("Value of a:{0}",a);
                a++;
            }*/
            //for
            /*int n;
            Console.WriteLine("Enter the Number:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The {0} table is:", n);
            for(int a = 1; a < 11; a=a+1)
            {
                Console.WriteLine("{0} X {1} = {2}", n, a, n*a);
            }*/
            //do-while
            /*int a = 1;
            int n;
            Console.WriteLine("Enter the Number: ");
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("{0} X {1} = {2}", n, a, n * a);
                a++;

            } while (a < 11);*/

            //nested loops
            /*int i, j;
            for (i = 2; i < 100; i++)
            {
                for(j=2;j<=(i/j);j++)
                    if((i%j) == 0)
                    {
                        break;
                    }
                if (j > (i / j))
                {
                    Console.WriteLine("{0} is prime", i);
                }
            }*/
            //break
            /*int a = 10;

            while (a < 20)
            {
                Console.WriteLine("Value of a:{0}", a);
                a++;
                if (a > 15)
                {
                    break;
                }
            }*/
            //Continue
            /*int a = 10;
            do
            {
                if (a == 15)
                {
                    a = a + 1;
                    continue;
                }
                Console.WriteLine("Value of a:{0}", a);
                a++;
            } while (a < 20);*/
            /*for (;;)
            {
                Console.WriteLine("Infinite");
            }*/
        }
    }
}
