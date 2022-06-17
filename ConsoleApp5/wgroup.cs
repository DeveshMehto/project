using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class wgroup
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("enter  two number");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());


            sum = num1 + num2;
            Console.WriteLine(sum);
        }
    }

    class arithmetic
    {
        static void Main(string[] args)
        {
            int result = 0;
            int add, sub, mul, div;
            Console.WriteLine("enter two numbers");
            int num1=int.Parse(Console.ReadLine());
            int num2=int.Parse(Console.ReadLine());
            add=num1 + num2;
            Console.WriteLine(add);
            sub=num1 - num2;
            Console.WriteLine(sub);
            mul=num1 * num2;
            Console.WriteLine(mul);
            div=num1 / num2;
            Console.WriteLine(div);


           
        }
    }
    class areaofrec
    {
        static void Main(string[] args)
        {
            int area=0;
            Console.WriteLine("enter length and width of rectangle");
            int l=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            area = l * b;
            Console.WriteLine((l*b)+"is area of rectangle");
        }
    }
    class areaoftriangle
    {
        static void Main(string[] args)
        {
            int area = 0;
            Console.WriteLine("enter base and height og triangle");
            int b = int.Parse(Console.ReadLine());
            int h=int.Parse(Console.ReadLine());
            area = h * b * 1/2;
            Console.WriteLine("area of tringle is"+(h*b*1/2));

        }
    }
    class square
    {
        static void Main(string[] args)
        {
            int square=0;   
            Console.WriteLine("enter a number");
            int num=int.Parse(Console.ReadLine());
            square = num * num;
            Console.WriteLine(square);

        }
    }

    class cubes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int a = int.Parse(Console.ReadLine());
            int cube = a * a * a;
            Console.WriteLine("cube=" + (a * a * a));
        }
    }

    class sumofdigi
    {
        static void Main(string[] args)
        {
            int sum=0,rem;

            Console.WriteLine("enter digits");
            int n=int.Parse(Console.ReadLine());
            while (n > 0)
            {
                
                rem = n % 10;
                sum =sum+ rem;
                n = n / 10;
                
            }
            Console.WriteLine("sum of digits" + sum);
        }
    }
    class covert
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("enter value");
            string cen = (Console.ReadLine());
            switch (cen)
            {
                case "meter":
                    num = num / 1000;
                    Console.WriteLine("in meter"+num);
                    break; 
                case "km":
                    num = num / 100000;
                    Console.WriteLine("in km"+num);
                    break ;
                default:
                    Console.WriteLine("invalid choice"+num);
                    break ;



            }


        }
    }
    class marks
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter marks of five subjects");
                Console.WriteLine("enlish");
                int eng = int.Parse(Console.ReadLine());
                Console.WriteLine("physical education");
                int pe = int.Parse(Console.ReadLine());
                Console.WriteLine("physics");
                int phy = int.Parse(Console.ReadLine());
                Console.WriteLine("chemistry");
                int che = int.Parse(Console.ReadLine());
                Console.WriteLine("maths");
                int mat = int.Parse(Console.ReadLine());
                int total = eng + pe + phy + che + mat;
                int avg = total / 5;
                float per = (total * 100) / 500;
                if ((eng >= 1 && eng <= 100) && (pe >= 1 && pe <= 100) && (phy >= 1 && phy <= 100) && (che >= 1 && che <= 100) && (mat >= 1 && mat <= 100))
                {
                    Console.WriteLine("total=" + total);
                    Console.WriteLine("average=" + avg);
                    Console.WriteLine("percentage=" + per);
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
        }
    }
    class simpleinterest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter principle amiunt");
            int p=int.Parse(Console.ReadLine());
            Console.WriteLine("enter rate of interest");
            int r=int.Parse(Console.ReadLine());
            Console.WriteLine("enter time period");
            int t=int.Parse(Console.ReadLine());
            int si;
            

            si = (p * r * t) / 100;
            Console.WriteLine("simple interest is"+si);
        }
    }

}

