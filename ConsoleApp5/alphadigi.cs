using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class alphadigi
        
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter character");
            char ch=char.Parse(Console.ReadLine());
            if (ch >= 'A' && ch <= 'Z' || ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("character is alphabet");
            }
            else if(ch >= '0' && ch <= '9')
            {
                Console.WriteLine("character is digit");
            }
            else
            {
                Console.WriteLine("character is a special symbol");
            }

        }
    }
}
