using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    class Basics
    {
        //variables
        public void Add()
        {
            Console.WriteLine("Enter a value:");
            short a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter b value:");
            int b= Convert.ToInt32(Console.ReadLine());
            double c = a + b;
            Console.WriteLine("The result of a+b is:{0}", c);
        }
        //type-conversions
        public void tc()
        {
            double d = 1234.67;
            int i;
            i = (int)d;
            Console.WriteLine(i);
            bool b = true;
            Console.WriteLine("Boolean:{0}", b.ToString());
        }
        //Constant-Literals
        public void cl() {
            const double pi = 3.14159;
            double r;
            Console.WriteLine("Enter the radius:");
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * r * r;
            Console.WriteLine("Radius:{0},Area:{1}", r, areaCircle);
        }
    }
    class DecisionMaking
    {
        //terinary operator
        public void to()
        {
            Console.WriteLine("Enter the integer:");
            int num = Convert.ToInt32(Console.ReadLine());
            string isEven;
            isEven = (num % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(isEven);
        }
        //switch
        public void Switch()
        {
            Console.WriteLine("Enter the grade:");
            char grade = Convert.ToChar(Console.ReadLine());
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                    Console.WriteLine("Good");
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
    //loops
    class Loops
    {
        public void wile(int a, int b)
        {

            while (a < b)
            {
                Console.WriteLine("value of a:{0}", a);
                a++;
            }
        }
        public void fr(int a, int b)
        {
            for (a = a; a <= b; a++)
            {
                Console.WriteLine("The value of a is:{0}", a);
            }
        }
        public void dw()
        {
            int a = 1;
            int n;
            Console.WriteLine("Enter the Number:");
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("{0} X {1} = {2}", n, a, n * a);
                a++;
            } while (a < 11);

        }
        public void nested()
        {
            int i, j;
            for (i = 2; i < 10; i++)
            {
                for (j = 2; j <= (i / j); j++)
                    if ((i % j) == 0)
                    {
                        break;
                    }
                if (j > (i / j))
                {
                    Console.WriteLine("{0} is prime", i);
                }

            }
        }
        public void br()
        {
            int a = 10;

            while (a < 20)
            {
                Console.WriteLine("Value of a:{0}", a);
                a++;
                if (a > 15)
                {
                    break;
                }
            }
        }
        public void ct()
        {
            int a = 10;
            do
            {
                if (a == 15)
                {
                    a = a + 1;
                    continue;
                }
                Console.WriteLine("Value of a:{0}", a);
                a++;
            } while (a < 20);
        }
        public void fe()
        {
            string[] names = { "The BoogeyMan", "Baba Yaga", "John wick", "Johnatan Wick" };
            foreach(string name in names) {
                Console.WriteLine("The names of JW are:{0}", name);
            }
        }

    }
    class Encapsulation
    {
        //Access specifiers
        public class pub {
        public double length;
        public double width;
        public double GetArea()
        {
            return length * width;
        }
            public void Display()
            {
                Console.WriteLine("Length:{0}", length);
                Console.WriteLine("Width:{0}", width);
                Console.WriteLine("Area:{0}", GetArea());
            }
       }
        public class pri
        {
            private double length;
            private double width;
            public void AcceptDetails()
            {
                Console.WriteLine("Enter the length:");
                length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the width");
                width = Convert.ToDouble(Console.ReadLine());
            }
            double GetArea()
            {
                return length * width;
            }
            public void Display()
            {
                Console.WriteLine("Length:{0}", length);
                Console.WriteLine("Width:{0}", width);
                Console.WriteLine("Area:{0}", GetArea());
            }
        }
    }
    class Methods
    {
        //recursion
        public int recursion(int num)
        {
            
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = recursion(num - 1) * num;
                return result;
            }
        }
        //parameter types
        public void value(int x,int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine(x);
            Console.WriteLine(y);

        }
        //references
        public void reference(ref int x,ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        //outputs
        public void output(out int x, out int y)
        {
            Console.WriteLine("Enter the first value:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second value:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
    class Nullables
    {
        public void nill()
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
            Console.WriteLine("Nullables are:{0},{1},{2},{3}", num1, num2, num3, num4);
            Console.WriteLine("Boolean value is:{0}", boolval);
        }
    }
    class Arrays
    {
        public void arr()
        {
            int[] n = new int[10];
            int i, j;

            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
        }
        //multiD array
        public void marr()
        {
            int[,] a = new int[5, 2] { { 1, 1 }, { 1, 2 }, { 1, 3 }, { 1, 4 }, { 1, 5 }  };
            int i, j;
            for (i = 0; i < 5; i++)
            {

                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
                }
            }

        }
        //passing array as a function arg
        public double getAverage(int[] arr, int size)
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
        }
        public int AddElements(params int[] arr)
        {
            int sum = 0;

            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }
        //methods(array)
        public void am()
        {
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
    class Strings
    {
        public void str()
        {
            string fname = "John";
            string lname = "wick";

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string[] sarray = { "Hello", "From", "Hyderabad" };

            string fullname = fname + lname;
            Console.WriteLine("Full Name:{0}", fullname);

            string greetings = new string(letters);
            Console.WriteLine("Greetings:{0}", greetings);

            string message = string.Join(" ", sarray);
            Console.WriteLine("Message:{0}", message);

            DateTime waiting = new DateTime(2023, 4, 7, 15, 16, 1);
            string chat = string.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message:{0}", chat);

        }
    }
    class Structures
    {
        struct Books
        {
            public string title;
            public string author;
            public string subject;
            public int book_id;
        }
        public void stru()
        {
            Books Book1;
            Books Book2;
            Book1.title = "C Programming";
            Book1.author = "Nuha Ali";
            Book1.subject = "C Programming Tutorial";
            Book1.book_id = 6495407;
            Book2.title = "Telecom Billing";
            Book2.author = "Zara Ali";
            Book2.subject = "Telecom Billing Tutorial";
            Book2.book_id = 6495700;
            Console.WriteLine("Book 1 title : {0}", Book1.title);
            Console.WriteLine("Book 1 author : {0}", Book1.author);
            Console.WriteLine("Book 1 subject : {0}", Book1.subject);
            Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);
            Console.WriteLine("Book 2 title : {0}", Book2.title);
            Console.WriteLine("Book 2 author : {0}", Book2.author);
            Console.WriteLine("Book 2 subject : {0}", Book2.subject);
            Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);
        }
    }
    class Enums
    {
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        public void en()
        {
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;

            Console.WriteLine("Monday:{0}", WeekdayStart);
            Console.WriteLine("Friday:{0}", WeekdayEnd);

        }

    }
    class Classes
    {
        public double length;
        public double breadth;
        public double height;
        //constructor
       /* public Classes()
        {
            Console.WriteLine("Object is created");
        }*/
        //destructor
        /*~Classes() { 
            Console.WriteLine("Object is destroyed");
        }*/
        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }
        public void vol()
        {
            Classes b1 = new Classes();
            Classes b2 = new Classes();
            double volume = 0.0;
            volume = b1.length * b1.breadth * b1.height;
            Console.WriteLine("Volume of Box1:{0}", volume);

            volume = b2.length * b2.breadth * b2.height;
            Console.WriteLine("Volume of Box2:{0}", volume);
        }
    }
    class Inheritance
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }
    public interface PaintCost
    {
        int getCost(int area);
    }
    class Rectt : Inheritance, PaintCost
    {
        public int getArea()
        {
            return (width * height);
        }
        public int getCost(int area)
        {
            return area * 70;
        }

    }
    class Polymorphism
    {
       public void print(int i)
        {
            Console.WriteLine("Printing int:{0}", i);
        }
        public void print(double f)
        {
            Console.WriteLine("Printing double:{0}", f);
        }
        public void print(string s)
        {
            Console.WriteLine("Printing string:{0}", s);
        }
    }
    class Interfaces
    {
        public interface ITransactions
        {
            void showTransaction();
            double getAmount();
        }
        public class Transaction :ITransactions
        {
            private string tCode;
            private string date;
            private double amount;

            public Transaction()
            {
                tCode = " ";
                date = " ";
                amount = 0.0;
            }
            public Transaction(string c, string d, double a)
            {
                tCode = c;
                date = d;
                amount = a;
            }
            public double getAmount()
            {
                return amount;
            }
            public void showTransaction()
            {
                Console.WriteLine("Transaction:{0}", tCode);
                Console.WriteLine("Date:{0}", date);
                Console.WriteLine("Amount:{0}", getAmount());
            }
        }
    }
    class Final
    {
        static void Main(string[] args)
        {
            Basics ba = new Basics();
            DecisionMaking dm = new DecisionMaking();
            Loops lp = new Loops();
            Encapsulation en = new Encapsulation();
            Encapsulation.pub pb = new Encapsulation.pub();
            Encapsulation.pri pr= new Encapsulation.pri();
            Methods m = new Methods();
            Nullables n = new Nullables();
            Arrays ar = new Arrays();
            Strings sr = new Strings();
            Structures sttr = new Structures();
            Enums enn = new Enums();
            Classes ob = new Classes();
            Rectt Rect = new Rectt();
            Polymorphism p = new Polymorphism();
            Interfaces intre = new Interfaces();
            Interfaces.Transaction t1 = new Interfaces.Transaction("001", "8/10/2012", 78900.00);
            Interfaces.Transaction t2 = new Interfaces.Transaction("002", "9/10/2012", 451900.00);
            //ba.Add();
            //ba.tc();
            //ba.cl();
            //dm.to();
            //dm.Switch();
            //Console.WriteLine("Enter a start value ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a end value ");
            //int y = Convert.ToInt32(Console.ReadLine());
            //lp.wile(x,y);
            //lp.fr(x, y);
            //lp.dw();
            //lp.nested();
            //lp.br();
            //lp.ct();
            //lp.fe();
            pb.length = 2.5;
            pb.width = 3.6;
            //pb.Display();
            //pr.AcceptDetails();
            //pr.Display();
            //Console.WriteLine("Enter the number:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(m.recursion(num));
            //m.value(3, 7);
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            // m.reference(ref a,ref b);
            int a, b;
            //m.output(out a, out b);
            //n.nill();
            //ar.arr();
            //ar.marr();
            int[] balance = new int[] { 1000, 2, 3, 17, 50 };
            //Console.WriteLine("Average value is: {0} ", ar.getAverage(balance, 5));
            //Console.WriteLine("The sum is:{0}", ar.AddElements(512, 720, 250, 567, 889));
            //ar.am();
            //sr.str();
            //sttr.stru();
            //enn.en();
            //ob.setLength(6.7);
            //Console.WriteLine("The length of the object is:{0}", ob.getLength());
            int area;
            Rect.setWidth(5);
            Rect.setHeight(7);
            area = Rect.getArea();
            //Console.WriteLine("Total area: {0}", Rect.getArea());
            //Console.WriteLine("Total Cost:{0}", Rect.getCost(area));
            //p.print(2);
            //p.print(3.4);
            //p.print("Hello");
            t1.showTransaction();
            t2.showTransaction();
        }
    }
}
