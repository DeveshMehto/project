using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class swap
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            int temp;
            Console.WriteLine("before swapping value of a={0},b={1}", a, b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("after swapping value of a={0},b={1}", a, b);
            Console.ReadLine();
        }
    }
}
