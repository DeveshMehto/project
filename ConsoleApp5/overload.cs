using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class overload
    {
        int x = 10;
        public static void get()
        {
            overload o = new overload();
            Console.WriteLine("first method");
            Console.WriteLine(o.x);

        }
        public static void get(int a)
        {
            overload o = new overload();
            Console.WriteLine("second method");
            Console.WriteLine(o.x);
            Console.WriteLine(a);
        }
    }
    class methodover
    {
        static void Main(string[] args)
        {
            overload.get();
            overload.get(10);
        }
    }
   
    


}

