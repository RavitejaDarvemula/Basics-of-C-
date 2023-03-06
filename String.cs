using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class String
    {
        static void Main(string[] args)
        {
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string[] sarray = { "Hello","From","Hyderabad" };

            string fullname = fname + lname;
            Console.WriteLine("Full Name:{0}", fullname);

            string greetings = new string(letters);
            Console.WriteLine("Greetings:{0}", greetings);

            string message = string.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = string.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);


        }
    }
}
