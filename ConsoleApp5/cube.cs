using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class cube
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int a=int.Parse(Console.ReadLine());
            int cube = a * a * a;
            Console.WriteLine("cube="+(a*a*a));
        }
    }
}
