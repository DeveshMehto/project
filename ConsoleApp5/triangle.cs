using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter base & height of triangle");
            int b=int.Parse(Console.ReadLine());
            int h=int.Parse(Console.ReadLine());
            int area = b * h*1/2;
            Console.WriteLine("area="+(b*h*1/2));
        }
    }
}
