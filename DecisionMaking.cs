using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class DecisionMaking
    {
       static void Main()
        {
            /*Console.WriteLine("Enter the integer: ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            bool isEven;
            isEven = (num%2==0)? true : false;
            Console.WriteLine(isEven);*/

            //switch
            Console.WriteLine("Enter the grade: ");
            char grade =Convert.ToChar(Console.ReadLine());
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                    Console.WriteLine("GOOD");
                    break;
                case 'C':
                    Console.WriteLine("Average!");
                    break;
                default:
                    Console.WriteLine("Invalid grade!");
                    break;
            }
            
        } 
    }
}
