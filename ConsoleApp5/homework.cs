using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class homework
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter year");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))

            {
                Console.WriteLine("year is leap year");

            }


            else
            {
                Console.WriteLine("year is not leapyear");
            }
        }
    }

    class divisible
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int a = int.Parse(Console.ReadLine());
            if (a % 5 == 0 && a % 11 == 0)
            {
                Console.WriteLine("number is dividible by both numbers");
            }
            else
            {
                Console.WriteLine("number is not divisible by both numbers");
            }
        }

    }


    class cal
    {
        static void Main(string[] args)
        {
            int result=0;
            Console.WriteLine("enter first number");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int num2=int.Parse(Console.ReadLine());
            Console.WriteLine("enter action to be performed");
            Console.WriteLine("1.addition");
            Console.WriteLine("2.substraction");
            Console.WriteLine("3.multiplication");
            Console.WriteLine("4.division");
            int action=int.Parse(Console.ReadLine());
            if(action==1)
            {
                result = num1 + num2;
            }
            else if(action==2)
            {
                result=num2 - num1; 
            }
            else if(action ==3)
            {
                result = num1 * num2;
            }
            else if(action==4)
            {
                result=num1 / num2;
            }
            else
            {
                Console.WriteLine("invalid input");

            }
            Console.WriteLine(result);
        }
    }

    class denomination
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter amount");
            int amt = int.Parse(Console.ReadLine());
            int n2000 = amt / 2000;
            amt = amt % 2000;
            int n500 = amt / 500;
            amt = amt % 500;
            int n200 = amt / 200;
            amt = amt % 200;
            int n100 = amt / 100;
            amt = amt % 100;
            int n50 = amt / 50;
            amt = amt % 50;
            int n20 = amt / 20;
            amt = amt % 20;
            int n10 = amt / 10;
            amt = amt % 10;
            int n1 = amt / 1;
            amt = amt % 1;
            Console.WriteLine("notes of 2000:" + n2000);
            Console.WriteLine("notes of 500:" + n500);
            Console.WriteLine("notes of 200:" + n200);
            Console.WriteLine("notes of 100:" + n100);
            Console.WriteLine("notes of 50:" + n50);
            Console.WriteLine("notes of 20:" + n20);
            Console.WriteLine("notes of 10:" + n10);
            Console.WriteLine("notes of 1:" + n1);

        }
    }

    class grosssalary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter  number");
            int num = int.Parse(Console.ReadLine());
            if (num <= 10000)
            {
                int a = num;
                int hra = num * 20 / 100;
                int da = num * 80 / 100;
                Console.WriteLine("gross salary" + (a + hra + da));

            }
            if (num <= 20000 && num >= 10000)
            {
                int b = num;
                int hra = num * 25 / 100;
                int da = num * 90 / 100;
                Console.WriteLine("gross salary" + (b + hra + da));
            }
            if (num > 20000)
            {
                int c = num;
                int hra = (num * 30 / 100);
                int da = (num * 95 / 100);
                Console.WriteLine("gross salary" + (c + hra + da));
            }
        }
    }

    class evenodd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two number");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("number is even=" + a);
            }
            else
            {
                Console.WriteLine("number is odd=" + b);
            }
        }
    }

    class positive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("number is positive");
            }
            else if (a < 0)
            {
                Console.WriteLine("Negative");
            }
            else
                Console.WriteLine("Zero");
        }
    }

    class threedigi
    {
        static void Main(string[] args)
        {
            int sum;
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());



            if (n > 99 && n < 1000)
            {
                Console.WriteLine("is a three digit number" + n);
                int first = n / 100;
                int last = n % 10;
                sum = first + last;
                Console.WriteLine("sum of digits" + sum);
            }



            else
            {
                Console.WriteLine("is not a three digit number");
            }
        }
    }

    class error
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write any integer");
            double i = double.Parse(Console.ReadLine());
            if (i > 1 && i < 7)
            {
                Console.WriteLine("day exist");
            }
            else
            {
                Console.WriteLine("erroe,day does not exist");
            }
        }

        class onetofive
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter a number");
                int a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    Console.WriteLine("one");
                }
                else if (a == 2)
                {
                    Console.WriteLine("two");
                }
                else if (a == 3)
                {
                    Console.WriteLine("three");
                }
                else if (a == 4)
                {
                    Console.WriteLine("four");
                }
                else if (a == 5)
                {
                    Console.WriteLine("five");
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
        }
    }

    class mark
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter marks of five subjects");
            Console.WriteLine("enlish");
            int eng=int.Parse(Console.ReadLine());
            Console.WriteLine("physical education");
            int pe = int.Parse(Console.ReadLine());
            Console.WriteLine("physics");
            int phy = int.Parse(Console.ReadLine());
            Console.WriteLine("chemistry");
            int che = int.Parse(Console.ReadLine());
            Console.WriteLine("maths");
            int mat = int.Parse(Console.ReadLine());
            int total = eng + pe + phy + che + mat;
            int avg = total / 5;
            float per = (total * 100) / 500;
            if ((eng >= 1 && eng <= 100) && (pe >= 1 && pe <= 100) && (phy >= 1 && phy <= 100) && (che >= 1 && che <= 100) && (mat >= 1 && mat <= 100))
            {
                Console.WriteLine("total=" + total);
                Console.WriteLine("average=" + avg);
                Console.WriteLine("percentage=" + per);
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
