using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class EvenOddCount
    {
        static void Main(string[] args)
        {
         int even=0,odd=0;
            int[] a = { 4, 3, 9, 6, 5, 1 };
            Console.WriteLine("Arrayb element are");
            foreach(int i in a)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    even++;

                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("Number of even Array element"+even);
            Console.WriteLine("Number of odd Array element" + odd);
        }

    }
    class Nibs
    {
        private string materialType;
        private int width;
        public string MaterialType
        {
            get { return materialType; }
            set { materialType = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

    }
    class Refill
    {
        private string inkcolor;
        private int length;
        private int nib ;
            public string Inkcolor
        { get { return inkcolor; } set { inkcolor = value; } }  
        public int Length { get { return length; } set { length = value; } }
        public Nib nb
            { get { return nb; } set { nb = value; } }
    }
    class Penn
    {
        private Refill refill;
        private int caplength;
        private string brand;
        public int Caplength
            { get { return caplength; } set { caplength = value; } }    
        public string Brand
            { get { return brand; } set { brand = value; } }
        static void Main(string[] args)
        {
            Penn p = new Penn();
            p.caplength = 10;
            p.brand = "cello";
            p.refill = new Refill();
            p.refill.Inkcolor = "blue";
            p.refill.Length = 8;
            Refill rf=new Refill();
           Nibs n = new Nibs();
            n.MaterialType = "steel";
            n.Width = 2;

            Console.WriteLine("Caplengtgh="+p.caplength+"Brand"+p.brand+"Inkcolor"+p.refill.Inkcolor+" Length"+p.refill.Length+"Materialtype"+n.MaterialType+"Width"+n.Width);
        }
    }
    class SeprateZeros
    {
        static void Main(string[] args)
        {
            int temp;
            int[] arr = { 1, 2, 0, 4, 3, 0, 6, 5, 0, 8 };
            Console.WriteLine("Array before seperating zeros"+String.Join(" ",arr));
            for(int i = 0; i < arr.Length; i++)
            {
                temp = 0;
                for(int j = 0; j < arr.Length; j++)
                {
                    if(arr[i] == 0)
                    {
                        temp=arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array after seperating zeros" + String.Join(" ", arr));
        }
    }
   class PerfectSquare
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 16, 43, 25, 20, 60, 34, 9, 64 };
            Console.WriteLine("Array elements are"+String.Join(" ",arr));
            Console.WriteLine("perfect square from array elements are");
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j=1;j<arr[i];j++)
                {
                    if(arr[i]%j==0 && arr[i]/j==j)
                    {
                        Console.Write(arr[i]+" ");
                    }
                }
            }
        }
    }
    class ReplaceZero
    {
        static void Main(string[] args)
        {
            int[] arr = { 20, 0, 3, 4, 0, 6, 7, 0, 5, 2, 0 };
            Console.WriteLine("Array element are"+String.Join(" ",arr));
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i]==0)
                {
                    arr[i] = 1;
                }
                
            }
            Console.WriteLine("array elements after replacing zeros" + String.Join(" ", arr));
        }
    }
    class BuzzFizz
    {
        static void Main(string[] args)
        {
            int count1 = 0,count2=0,count3 = 0;
            Console.WriteLine("number from 1 to50");
            {
                for (int i = 1; i < 50; i++)
                {

                
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("BuzzFizz");
                        count3++;
                    }
                    else if(i%5==0)
                    {
                        Console.WriteLine("Fizz");
                        count2++;
                    }
                    else if(i % 3==0)
                    {
                        Console.WriteLine("Buzz");
                        count1++;
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }


                }
                Console.WriteLine("buzz is printed"+  count1 +" times");
                Console.WriteLine("Fizz is printed" + count2 + " times");
                Console.WriteLine("buzzFizz is printed" + count3 + " times");
            }

        }
    }



}
