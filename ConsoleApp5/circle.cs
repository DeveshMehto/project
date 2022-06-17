using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class circle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter radius of circle");
            double r=int.Parse(Console.ReadLine());
            double pi = 3.14;
            double area = pi * r * r;
            Console.WriteLine("area="+(pi*r*r));

        }
    }
}
