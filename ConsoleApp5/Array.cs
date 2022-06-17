using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Arrayprime

    {
        static void Main(string[] args)
        {
            int[] a = { 2, 5, 4, 7, 3, 8, 9, 6 };

            for (int i = 0; i < a.Length; i++)
            {
                int n = a[i];
                bool isPrime = true;
                for (int j = 2; j < n; j++)
                    if (n % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                if (isPrime == true)
                    Console.WriteLine(a[i]);

            }
        }
    }
    class Summ
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 5, 4, 7, 3, 8, };
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }

            Console.WriteLine(sum);
        }
    }
    class Reverse
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, };
            foreach (int p in a)
            {
                Console.WriteLine(p + " ");
            }
            Console.WriteLine("////////////////");
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i] + " ");
            }
        }
    }
    class Arrayodd
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 5, 7, 9, 11, 13, 15 };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                    Console.WriteLine(" " + a[i]);
            }
        }
    }
    class Arrayeven
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 6, 8, 10, 12 };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    Console.WriteLine(" " + a[i]);
            }
        }
    }
    class alternateelement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("enter array element");

            for (int i = 0; i < a.Length; i++)
            {
                int e = int.Parse(Console.ReadLine());
                a[i] = e;

            }
            Console.WriteLine("array elements are");
            foreach (int e in a)
            {
                Console.WriteLine(e + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Alternate array elements are");
            for (int i = 0; i < a.Length; i = i + 2)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
    class Sumofprime
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int sum = 0;


                int[] arr = { 2, 5, 13, 7, 3, 20, 9, 6, 17 };
                Console.WriteLine(string.Join(" ",arr));
                for (int i = 0; i < arr.Length; i++)
                {
                    int n = arr[i];
                    bool isPrime = true;
                    for (int j = 2; j < n/2; j++)
                        if (n % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    if (isPrime == true)
                    {
                        Console.WriteLine("Array elements are" + arr[i]);
                        sum = sum + arr[i];

                    }

                }
                Console.WriteLine("sum of prime elements in array is" + sum);
            }
        }
    }
    class MaxElement
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 5, 6, 7, 8, 9, };
            Console.WriteLine(String.Join(" ",arr));
            int max =arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max element is"+max);
        }
    }
    class Avgofoddno
    {
        static void Main(string[] args)
        {
            int sum = 0, count = 0,avg;
            int[] a = { 2, 3, 5, 4, 18, 17, 23, 30 };
            Console.WriteLine(String.Join(" ", a));
            Console.WriteLine("odd element are");
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i]%2!=0)
                {
                    Console.WriteLine(a[i]);
                    sum=sum+a[i];
                    count++;
                }

            }
            Console.WriteLine("sum of odd element is"+sum);
            avg = sum / count;
            Console.WriteLine("avg of odd elements" + avg);
        }
    }
    class Reverseelement
    {
        static void Main(string[] args)
        {
            char[]ch  = { 'a', 'b', 'c', 'd', 'e', };
            Console.WriteLine(String.Join(" ",ch));
            int j = ch.Length - 1;
            for(int i = 0; i <= ch.Length/2; i++)
            {
                char temp=ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                j--;
            }
            Console.WriteLine(String.Join(" ",ch));
        }
    }
    class MinElement
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 2, 7, 9, 6 };
            Console.WriteLine(String.Join(" ", arr));
            int min=arr[0];
            for(int i = 1; i <= arr.Length/2; i++)
            {
                if(arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("min element"+min);
        }
    }
    class Occurance
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 5, 3, 2, 2, 4, 6, 7, 6, 4 };
            Console.WriteLine(String.Join(" ",a));
            Console.WriteLine();
            Console.WriteLine("Number of each element occored");
            for(int i = 0; i < a.Length; i++)
            {
                int count = 1;
                bool isVisited=false;
                for(int k=i-1;k>=0;k--)
                {
                    if(a[i]==a[k])
                    {
                        isVisited=true;
                        break;
                    }
                }
                if(isVisited== false)
                {
                    for(int j=i+1;j<a.Length;j++)
                    {
                        if(a[i]==a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(a[i]+" "+count);
                }
            }
        }
    }
    class GivenelemOccurance
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 5, 3, 2, 2, 4, 6, 7, 6, 4 };
            Console.WriteLine(String.Join(" ", a));
            
            Console.WriteLine("Number of each element occored");
            int n=int.Parse(Console.ReadLine());
            int count = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(n==a[i])
                {
                    count++;

                }
            }
            Console.WriteLine();
            Console.WriteLine(n+" occured"+count+"times");
        }
    }
    class UniqueElement
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 5, 3, 2, 2, 4, 6, 7, 6, 4 };
            Console.WriteLine(String.Join(" ", a));
            Console.WriteLine();
            Console.WriteLine("Unique element");
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                bool isVisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if (isVisited == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    if(count == 1)
                    {
                        Console.WriteLine(a[i]);
                    }
                    Console.WriteLine(a[i] + " " + count);
                }
            }
        }
    }
    class MergeArray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 10 };
            int[] b = { 5,6,7,8,9 };
            int range=a.Length+b.Length;
            int[]c=new int[range];
            Console.WriteLine("First array is"+String.Join(" ",a));
            Console.WriteLine("First array is"+String.Join(" ", a));
            for(int i=0; i<a.Length; i++)
            {
                c[i]=a[i];

            }
            for(int j=0,k=a.Length;k<range && j<b.Length;j++,k++)
            {
                c[k]=b[j];
            }
            Console.WriteLine("after combining"+String.Join(" ",c));
        }
    }
    class Sortdemo
    {
        static void Main(string[] args)
        {
            char[] ch = new char[5];
                Console.WriteLine("enter array Element");
            for(int i=0; i<ch.Length; i++)
            {
                ch[i]= Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine(".....................");
            Console.WriteLine(String.Join(" ",ch));

            for(int i=0;i<ch.Length;i++)
            {
                for(int j=i+1;j<ch.Length;j++)
                {
                    if(ch[i]<ch[j])
                    {
                        char temp=ch[i];
                        ch[i]=ch[j];
                        ch[j]=temp;
                    }
                }
            }
            Console.WriteLine("............after.............");
            Console.WriteLine(String.Join(" ",ch));
        }        
    }
    class TwoDArray
    {
        static void Main(string[] args)
        {
            int[,]a = new int[3, 3] { { 1,2,3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    a[i,j]=int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("....................");
            
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j< a.GetLength(1);j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("...................");
            for(int i=0;i<=a.GetUpperBound(0);i++)
            {
                for(int j=0;j<=a.GetUpperBound(1);j++)
                {
                    Console.WriteLine(a[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
    class Evenelementarray
    {
        static void Main(string[] args)
        {

                           Console.WriteLine("enter length of array");
            int x=int.Parse(Console.ReadLine());
            int[]a=new int[x];
            Console.WriteLine("enter array element");
            for(int i=0;i<a.Length;i++)
            {
                int e=int.Parse(Console.ReadLine());
                a[i]=e;
            }
            Console.WriteLine("array element are");
            foreach(int ele in a)
            {
                Console.WriteLine(ele+" ");
            }
            Console.WriteLine();
            Console.WriteLine("even elements from array");
            for(int i=0;i<a.Length-1;i++)
            { if(a[i]%2==0)
                {
                    Console.Write(a[i]+" ");
                }
            }
        }
    }
    class Oddelementarray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter length of array");
            int x = int.Parse(Console.ReadLine());
            int[] a = new int[x];
            Console.WriteLine("enter array element");
            for (int i = 0; i < a.Length; i++)
            {
                int e = int.Parse(Console.ReadLine());
                a[i] = e;
            }
            Console.WriteLine("array element are");
            foreach (int ele in a)
            {
                Console.WriteLine(ele + " ");
            }
            Console.WriteLine();
            Console.WriteLine("even elements from array");
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] % 2 != 0)
                {
                    Console.Write(a[i] + " ");
                }
                else
                {
                    continue;
                }
            }
        }
    }
    class Addition
    {
        static void Main(string[] args)
        {
            int[,] a = { { 2, 6 }, { 1, 4 } };
            int[,] b = { { 3, 9 }, { 5, 7 } };
            Console.WriteLine("Array 1");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine(a[i, j] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Array 2");

            }
            Console.WriteLine("Array 2");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine(b[i, j] + " ");

                }
                Console.WriteLine();


            }
            int[,] result = new int[2, 2];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    result[i, j] = a[i, j] + b[i, j];

                }



            }
            Console.WriteLine("After addtion");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine(result[i, j] + " ");

                }
                Console.WriteLine();


            }
        }
    }


}
