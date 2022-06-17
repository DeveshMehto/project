using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class loop
    {

        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(i);
        }
    }

    class nb
    {
        static void Main(string[] args)
        {
            for (int i = 35; i <= 75; i++)
                Console.WriteLine(i);
        }
    }

    class nbs
    {
        static void Main(string[] args)
        {
            for (int i = 125; i >= 85; i--)
                Console.WriteLine(i);
        }
    }

    class odd
    {
        static void Main(string[] args)
        {
            for (int i = 25; i <= 45; i = i + 2)
                Console.WriteLine(i);
        }
    }

    class count
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("count odd number between 1to20");
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                    count++;

            }
            Console.WriteLine(count);


        }
    }

    class factor
    {
        static void Main(string[] args)
            
        {
            
            Console.WriteLine("enter number");
            int a = int.Parse(Console.ReadLine());

            int sum=0;
            Console.WriteLine("factor are");
            for (int i = 1; i <= a; i++)
            {
                if (a%i == 0)

                    Console.WriteLine(i);
                sum += 1;
                
            }
            Console.WriteLine("sum of factors"+sum);
        }
    }

    class table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number to print table");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(a * i);
            }

        }
    }

    class power
    {
        static void Main(string[] args)
        {
            int baseno, index, power = 1;
            Console.WriteLine("enter base number ");
            baseno = int.Parse(Console.ReadLine());
            Console.WriteLine("enter index number");
            index = int.Parse(Console.ReadLine());
            while (index >= 1)
            {
                power = power * baseno;
                index--;
                Console.WriteLine(power);
            }

        }
    }

    class oodp
    {
        static void Main(string[] args)
        {
            for (int i = 121; i <= 229; i = i + 2)
                Console.WriteLine(i);
        }
    }

    class evenp
    {
        static void Main(string[] args)
        {
            for (int i = 521; i >= 229; i = i - 2)
                Console.WriteLine(i);
        }
    }
    class brk
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }

    class gcdlcm
    {
        static void Main(string[] args)
        {
            int temp, LCM, GCD, n1, n2;
            Console.WriteLine("enter  number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number");
            int num2 = int.Parse(Console.ReadLine());
            n1 = num1;
            n2 = num2;
            while(n2!=0)
            {
                temp = n2;
                n2 = n1 % n2;
                n1 = temp;
            }    
            GCD = n1;
            LCM = (num1 * num2) / GCD;

            Console.WriteLine("LCM"+num1,+num2,+LCM);
                Console.WriteLine("GDC"+num1+num2+GCD);
        }
    }

    class alpha
    {
        static void Main(string[] args)
        {
            char ch;
            for (ch = 'a'; ch <= 'z'; ch++)
                Console.WriteLine(ch);
        }
    }
     
    class evenn
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                    sum += i;
            }
                Console.WriteLine("sum of even number is"+sum);
            
        }
    }

    class oddn
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                    sum += i;
            }
            Console.WriteLine("sum of odd number is" + sum);

        }

        class countdigi
        {
            static void Main(string[] args)
            {
                int count = 0;
                Console.WriteLine("enter number");
                int a = int.Parse(Console.ReadLine());
                while (a != 0)
                {
                    a = a / 10;
                    count++;
                    Console.WriteLine("number od digits are" + count);
                }
            }

        }
    }
    class productofdigi
    {
        static void Main(string[] args)
        {
            int product = 1, rem = 0;
            Console.WriteLine("enter number");
            int a=int.Parse(Console.ReadLine());    
            while(a != 0)
            {
                rem = a % 10;
                a=a / 10;
                product = product * rem;
            }
            Console.WriteLine("productof digits are"+product);
        }
         class primeno
         {
            static void Main(string[] args)
            {
                int count;
                
                Console.WriteLine("prime numbers from 400 to 300 are");
                for (int i = 400; i <= 300; i--)
                { count = 0;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        count++;
                        break;
                    }
                }
                

            }
         }
    }

    class palindrome
    {
        static void Main(string[] args)
        {
            int num,rem,sum=0,temp;
            Console.WriteLine("enter a number");
            num=int.Parse(Console.ReadLine());
            temp = num;
            while(num>0)
            {
                rem=num % 10;
                num=num / 10;
                sum = sum * 10 + rem;

            }
            Console.WriteLine("the reverse number is"+sum);
            if(temp==sum)
            {
                Console.WriteLine("number is palindrome");
            }
            else
            {
                Console.WriteLine("number is not palindrome");
                Console.WriteLine();
            }

            


        }

        class spy
        {
            static void Main(string[] args)
            {
                int add = 0, mul = 1;
                int n=int.Parse(Console.ReadLine());
                int num = n;
                while(n!=0)
                {
                    int rem=n%10;
                    add = add + rem;
                    mul = mul * rem;
                    n=n / 10;

                }
                if(add==mul)
                {
                    Console.WriteLine(num+"number is spy number");
                }
                else
                    Console.WriteLine(num+"number is not spy number");
            }
        }
    }

    class series
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("enter a number");
            int n=int.Parse(Console.ReadLine());
            while(i<=n)
            {
                if (i % 2 != 0)
                {
                    int a = (i * i);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
        class series2
        {
            static void Main(string[] args)
            {
                int i = 1;
                Console.WriteLine("enter a number");
                int n = int.Parse(Console.ReadLine());
                while (i <= n)
                {
                    int sq = i * i;
                    int cube=i * i * i;
                    Console.WriteLine(sq+cube);
                    i++;
                }
            }
        }
    }
     class armstrongno
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("enter the number");
            n= int.Parse(Console.ReadLine());   
            temp = n;
            while(n>0)
            {
                r = n % 10;
                sum=sum+(r*r*r);
                n = n / 10;

            }
            if (temp == sum)
                Console.WriteLine(temp + "number is armstrong");
            else
                Console.WriteLine(temp + "number is not armstrong");
        }
    }
     
    class display
    {
        static void Main(string[] args)
        {
            int i = 86;
            while(i>=25)
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }

    class sum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("enter  two number");
            int num1=int.Parse(Console.ReadLine());
            int num2=int.Parse(Console.ReadLine());
            
            
                sum=num1 + num2;
                Console.WriteLine(sum);
            
        }

    }

    class nested
    {
        static void Main(string[] args)
        {
            
            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=4;j++)
                {
                    Console.WriteLine("*");

                }
                Console.WriteLine();
            }
        }
    }
    
    class pattern1
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
    class pattern2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
     class pattern3
     {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = i; j <= 4; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();

            }
        }
     }
    class pattern4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");

                }
                Console.WriteLine();
            }
        }
    }
    struct pattern5
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");

                }
                Console.WriteLine();
            }
        }
    }
    class trimorfic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int a=int.Parse(Console.ReadLine());
            int cube = a * a * a;
            Console.WriteLine(cube);
            int c = cube % 10;

            if(a== c)
            {
                Console.WriteLine(a+"is trimorfic number");
            }
            else
            {
                Console.WriteLine(a + "is not trimorfic number");
            }

        }
    }
    class area
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first numbers");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int num2=int.Parse(Console.ReadLine());

            
            
                Console.WriteLine("1.circle\n 2.rectangle\n 3.triangle\n 4.square");
                Console.WriteLine("enter you choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("area of circle" + (3.14 * num1 * num1));
                        break;
                    case 2:
                        Console.WriteLine("area of rectangle" + (num2 * num1));
                        break;
                    case 3:
                        Console.WriteLine("area of triangle" + (num1 * num2 * 1 / 2));
                        break;
                    case 4:
                        Console.WriteLine("area of square" + (num1 * num1));
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }



            

        }
    }
     class table2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("display table between 1 to 5");
            
            for(int a =1;a<=5;a++)
            {
                for(int i=1;i<=10;i++)
                {
                    Console.WriteLine(a+"*"+i+"="+(a*i));
                }
                
            }




        }
        

    }
    class automorph
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num=int.Parse(Console.ReadLine());
            int temp = num;
            int sq = num * num;
            int count = 0;
            while(num>0)
            {
                count++;
                num = num / 10;

            }
            Console.WriteLine(count);
            num = temp;
            int sum=0;
            while (num > 0)
            {
                int r = num % 10;
            }
                int power = 1;
            while (count>0)   
            {
                    power=power*10;
                count--;

            }
            Console.WriteLine(power);
            num= temp;
            int end = sq % power;
            if(num==end)
            {
                Console.WriteLine("automorph");
            }
            else
            {
                Console.WriteLine("not automorph");
            }

            
                
        }
    }


    class pattern6
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");

                }
                Console.WriteLine();

            }
        }
    }
    class pattern7
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<= 4; i++)
            {
                for (int j = 4; j >=i; j--)
                {
                    Console.Write(j + " ");

                }
                Console.WriteLine();

            }
        }
    }
    class pattern8
    {
        static void Main(string[] args)
        {
            int value = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                    value++;

                }
                Console.WriteLine();

            }
        }
    }
    class pattern9
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if(i==1 || i==5 ||j==1 ||j==5)
                        Console.WriteLine("*");
                    else
                        Console.WriteLine(" ");
                    

                }
                Console.WriteLine();

            }
        }
    }
    class disarium
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num=int.Parse(Console.ReadLine());
            int temp = num;
            int count=0;    
            while(num>0)
            {
                count++;
                num = num / 10;

            }
            Console.WriteLine(count);
            num = temp;
            int sum = 0;
            while (num > 0)
            {
                int r = num % 10;
                int power = 1;
                for(int i=1;i<=count;i++)
                {
                    power = power * r;
                }
                sum= sum + power;
                count--;
                num = num / 10;

            }
            num = temp;
            if(num==sum)
            {
                Console.WriteLine("number is disarium");
            }
            else
            {
                Console.WriteLine("number is not disarium");
            }
        }
    }

    class sumofprime
    {
        static void Main(string[] args)
        {
            int count, sum = 0;
            Console.WriteLine("prime number from 1 to 10");
            for(int i=1;i<10;i++)

            {
                for(int j=2;j<=i;j++) 
                count = 0;
                break;
                

            }
            
        }
    }
}

