using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class reverse
    {
        static void Main(string[] args)
           
        {
           
            int sum=0;
            Console.WriteLine("enter number");
            int n=int.Parse(Console.ReadLine());
           for(int i=1;i<=n;i++)
           { 
              sum=(sum*2)+1;
                Console.WriteLine(sum+" ");
           }
            
        }
    }
}
