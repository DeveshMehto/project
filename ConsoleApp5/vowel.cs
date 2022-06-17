using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a character");
            char v = char.Parse(Console.ReadLine());
            if (v == 'a' || v == 'e' || v == 'i' || v == 'o' || v == 'u')
            {
                Console.WriteLine("charater is vowel");

            }
            else
            {
                Console.WriteLine("character is consonant");
            }

        }
    }
}
