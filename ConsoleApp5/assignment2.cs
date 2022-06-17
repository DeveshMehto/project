using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class assignment2
    {
        static void Main(string[] args)
        {
            for (int i= 1; i <= 50;i++)
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("its square"+(i*i));
                }


        }
    }
    class oneto100
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number between 1 to 100 except 5 and 10");
            for (int i = 1; i <= 100; i++)
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
    class allfactor
    {
        static void Main(string[] args)

        {

            Console.WriteLine("enter number");
            int a = int.Parse(Console.ReadLine());

            int sum = 0;
            Console.WriteLine("factor are");
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)

                    Console.WriteLine(i);
                sum += 1;

            }
            Console.WriteLine("sum of factors" + sum);
        }
    }
    class fibbo
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3;
            Console.WriteLine("fibbo up to 20");
            Console.WriteLine(n1+"\n"+n2);
            for(int i=3;i<=20;i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            }
        }
    }
    class Harshadnumber
    {
        static void Main(string[] args)
        {
            int rem = 0, sum = 0;
            Console.WriteLine("enter number to check harshad number or not");
            int n=int.Parse(Console.ReadLine());
            int temp = n;
            while(n!=0)
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;

            }
            Console.WriteLine("sum of digits"+temp+"is"+sum);
            if (temp % sum == 0)
            {
                Console.WriteLine(temp + "is harshad number");
            }
            else
            {
                Console.WriteLine(temp+"is not harshad number");
            }
        }
    }
    class factors
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                { 
                       Console.WriteLine("RedBlue");
                }
                else if(i%3==0)
                {
                    Console.WriteLine("Red");
                }
                else if(i% 5==0)
                {
                    Console.WriteLine("Blue");
                    
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    class krishnamurthy
    {
        static void Main(string[] args)
        {
            int rem=0,sum=0,fact,temp;
            Console.WriteLine("enter a number");
            int n=int.Parse(Console.ReadLine());
            temp = n;
            while(n!=0)
            {
                fact = 1;
                rem = n % 10;
                for(int i=rem;i>=1;i--)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                n = n / 10;
            }
            Console.WriteLine("sum of factorial"+sum);
            if(temp==sum)
            {
                Console.WriteLine(temp+"is a krishnamurthy number....");
            }
            else
            {
                Console.WriteLine(temp+"is not a krishnamurthy number....8");
            }
        }
    }


}
