using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class rectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter length & width of rectangle");
            int l=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            int area = l * b;
            Console.WriteLine("area of rectangle="+(l*b));
        }
    }
}
