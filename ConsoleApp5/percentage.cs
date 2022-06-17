using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class percentage
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("enter marks of phy");
            int phy=int.Parse(Console.ReadLine());
            Console.WriteLine("enter marks of chem");
            int chem = int.Parse(Console.ReadLine());
            Console.WriteLine("enter marks of maths");
            int maths = int.Parse(Console.ReadLine());
            Console.WriteLine("enter marks of pe");
            int pe = int.Parse(Console.ReadLine());
            Console.WriteLine("enter marks of english");
            int english = int.Parse(Console.ReadLine());
            Console.WriteLine("enter marks of english");
            int per;
            int total;
            total = phy + chem + maths + pe + english;
            per = total/5;
            if(per >=60)
            {
                Console.WriteLine("first division");
            }
            else if(per<60 && per>=48)
            {
                Console.WriteLine("second division");
            }
            else if(per<48 && per>=36)
            {
                Console.WriteLine("third division");
            }
            else
            {
                Console.WriteLine("fail");
            }



        }


    }
}
