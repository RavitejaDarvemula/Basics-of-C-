using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Methods
    {
        /*public int Add(int a, int b)
    {
        int result;

        if (a > b)
        {
            result = a;
        }
        else
        {
            result = b;
        }
        return result;*/

        //recursion
        /* public int factorial(int num)
         {
             int result;
             if(num == 1)
             {
                 return 1;
             }
             else
             {
                 result = factorial(num - 1) * num;
                 return result;
             }

         }*/

        //parameter types
        //value
        //public void swap(int x,int y)
        //reference
        /*public void swap(ref int x, ref int y) 
            {
                int temp;
                temp = x;
                x = y;
                y = temp;
            }*/
        //output
        public void getValues(out int x , out int y)
        {
            Console.WriteLine("Enter the first value:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second value:");
            y = Convert.ToInt32(Console.ReadLine());
        }
        
             static void Main(string[] args)
        {
            /* Methods ob = new Methods();
             Console.WriteLine(ob.factorial(7)); */
            /*int num1 = 10;
            int num2 = 20;
            int ret;
            Methods ob = new Methods();
            ret = ob.Add(num1, num2);
            Console.WriteLine("Greater is :{0} ", ret);*/

            //
            /*Methods ob = new Methods();

            int a = 20;
            int b = 30;

            Console.WriteLine(a);
            Console.WriteLine(b);

            //value
            //ob.swap(a, b);

            //reference
            ob.swap(ref a, ref b);

            Console.WriteLine(a);
            Console.WriteLine(b);*/

            //output

            Methods ob = new Methods();
            int a, b;
            ob.getValues(out a, out b);
            Console.WriteLine(a);
            Console.WriteLine(b);
            }
        }
    }
