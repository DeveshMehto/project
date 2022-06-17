using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class greatest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 3 numbers");
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            int c=int.Parse(Console.ReadLine());
            if(a>b && a>c)
            {
                Console.WriteLine("a is greater");
            }
            else if(b>a && b>c)
            {
                Console.WriteLine("b is greater");
            }
            else
            {
                Console.WriteLine("c is greater");
            }
        }
    }
}
