using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace first_space
{
    class namespace_cl
    {
        public void fun()
        {
            Console.WriteLine("Inside the firstspace");
        }
    }
}
namespace second_space
{
    class namespace_cl
    {
        public void fun()
        {
            Console.WriteLine("Inside the secondspace");
        }
    }

}

namespace Practice
{
    class Namespaces
    {
        static void Main(string[] args)
        {
            first_space.namespace_cl fc = new  first_space.namespace_cl();
            second_space.namespace_cl sc = new second_space.namespace_cl();

            fc.fun();
            sc.fun();


        }
    }
}
