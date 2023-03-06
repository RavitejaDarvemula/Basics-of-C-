using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Arrays
    {
        //passing array as a function argument
        /*double getAverage(int[] arr, int size)
        {
            int i;
            double avg;
            int sum = 0;

            for (i = 0; i < size; ++i)
            {
                sum += arr[i];
            }
            avg = (double)sum / size;
            return avg;
        }*/

        //param array
        /*public int AddElements(params int[] arr)
        {
            int sum = 0;

            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }*/
    static void Main(string[] args)
        {
            /*int[] n = new int[10];


            for (int i = 0; i < 10; i++) {
                n[i] = i + 100;
            }*/

            //multiD array
            //int[,] a = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };

            //int i, j;
            //Jagged Array
            /* int [][] = new int[][]{new int[]{0,0},new int[]{1,2},new int[]{2,4},new int[]{3,6},new int[]{4,8}};
             * int i,j;
             * for(i=0;i<5;i++){
                    for(j=0;j<2;j++){
                            Console.WriteLine("a[{0}][{1}] = {2}", i ,j, a[i][j]);
                            }
                            }*/




            /*for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}]:{1}", j, n[j]);
            }
            Console.ReadKey();*/

            //for each
            /*foreach(int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Element[{0}] = {1} ", i, j);
            }*/
            /*for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
                }
            }*/
            /*Arrays app = new Arrays();

            int[] balance = new int[] { 1000, 2, 3, 17, 50 };
            double avg;

            avg = app.getAverage(balance, 5);

            Console.WriteLine("Average value is: {0} ", avg);*/

            //
            /*Arrays ob = new Arrays();
            int sum = ob.AddElements(512, 720, 250, 567, 889);

            Console.WriteLine("The sum is: {0}", sum);*/
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            int[] temp = list;
            Console.Write("Original Array: ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Array.Reverse(temp);
            Console.Write("Reversed Array: ");

            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Array.Sort(list);
            Console.Write("Sorted Array: ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


        }
    }
}
