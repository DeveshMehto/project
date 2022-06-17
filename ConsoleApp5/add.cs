using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class add
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 2 numbers");
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("addition"+sum);
        }
    }
}
