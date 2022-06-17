using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class assignment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number between 1 to 100 except 5 and 10");
            for(int i=1;i<=100;i++)
            {
                if (i % 5 != 0 && i % 10 != 0)
                {
                    Console.WriteLine(i);
                }
                else
                    continue;
            }
        }
    }
    class behavior
    {
        static void main(String[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            }
            while (b != 3);
        }

    }
    class spy
    {
        static void Main(string[] args)
        {
            int add = 0, mul = 1;
            int n = int.Parse(Console.ReadLine());
            int num = n;
            while (n != 0)
            {
                int rem = n % 10;
                add = add + rem;
                mul = mul * rem;
                n = n / 10;

            }
            if (add == mul)
            {
                Console.WriteLine(num + "number is spy number");
            }
            else
                Console.WriteLine(num + "number is not spy number");
        }


    }
    class trimorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int a = int.Parse(Console.ReadLine());
            int cube = a * a * a;
            Console.WriteLine(cube);
            int c = cube % 10;

            if (a == c)
            {
                Console.WriteLine(a + "is trimorfic number");
            }
            else
            {
                Console.WriteLine(a + "is not trimorfic number");
            }
        }
    }
    class patrn
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <=6; i++)
            {
                for(int j = 1; j <=i; j++)
                {
                    Console.Write("");
                }
                for(int k=1; k <=6-i; k++)
                {
                    Console.Write("*"+"");
                }
                Console.WriteLine();

            }
        }
    }
    class patrn2
    {
        static void Main(string[] args)
        {
            for (int i = 5; i <= i; i--)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write("");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();

            }
        }
    }

}
