using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class oddeveter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int a=int.Parse(Console.ReadLine());
            string ans = a % 2 == 0 ? "even" : "odd";
            Console.WriteLine("ans"+ans);
                
        }
  
    
    }  
     class great
     {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 3 numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int ans = (a > b && a > c) ? a : (b > a && b > c) ? b: c ;
            Console.WriteLine(ans+"is max");

        }


     }

}

