﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Enums
    {
        enum Days { Sun,Mon,Tue,Wed,Thu,Fri,Sat};
        static void Main(string[] args)
        {
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;

            Console.WriteLine("Monday:{0}", WeekdayStart);
            Console.WriteLine("Friday:{0}", WeekdayEnd);


        }
    }
}
