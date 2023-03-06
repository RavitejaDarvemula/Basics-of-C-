using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Practice
{
    class RegularExpressions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String:");
            string input;
            input = Convert.ToString(Console.ReadLine());
            string pattern = "\\s+";
            string replacement = " ";

            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);
            Console.WriteLine("Original String:{0}", input);
            Console.WriteLine("Replacement String:{0}", result);
        }
    }
}
