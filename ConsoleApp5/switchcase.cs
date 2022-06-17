using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class switchcase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num= int.Parse(Console.ReadLine());
            
            switch(num%2 )
            {
                    case 0: Console.WriteLine(num+"even");
                    break;
                    case 1: Console.WriteLine(num+"odd");
                    break;

            }

        }
    }
    class days
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter week days");
            int day = int.Parse(Console.ReadLine());
            if (day == 1)
            {
                Console.WriteLine("It's sunday");
            }
            else if (day == 2)
            {
                Console.WriteLine("It's monday");
            }
            else if (day == 3)
            {
                Console.WriteLine("It's tuesday");
            }
            else if (day == 4)
            {
                Console.WriteLine("It's wednesday");
            }
            else if (day == 5)
            {
                Console.WriteLine("It's thusday");


            }
            if (day == 6)
            {
                Console.WriteLine("It's friday");
            }
            if (day == 7)
            {
                Console.WriteLine("It's saturday");
            }
        }
    }

    class calculator
    {
        static void Main(string[] args)
        {
            Char op;
            double num1, num2;
            Console.WriteLine("enter the operations(+,-,*,/)");
            op = Console.ReadLine()[0];
            Console.WriteLine("enter 2 numbers one by one");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());
            switch (op)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", num1, num2, (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", num1, num2, (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}", num1, num2, (num1 * num2));
                    break;
                case '/':
                    if (num2 == 0.0)
                        Console.WriteLine("divide by zero siyuation");
                    else
                        Console.WriteLine("{0}/{1}={2}", num1, num2, (num1 / num2));
                    break;
                default:
                    Console.WriteLine("{0} ian an invalid operator", op);
                    break;
            }
        }
    }
}
