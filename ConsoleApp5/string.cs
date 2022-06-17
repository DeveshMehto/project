using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Spattern

    {
        static void Main(string[] args)
        {
          
            string str = "hello how are you";
            Console.WriteLine(str);
            string[] str1 = str.Split();
            for(int i = 0; i < str1.Length; i++)
            {
                for(int j = 0; j <=i; j++)
                {
                    Console.WriteLine(str1[j]+" ");
                }
                Console.WriteLine();
            }
            

        }
    }
    class Count
    {
        static void Main(string[] args)
        {
            string str = "hello how are you";
            Console.WriteLine(str);
            string[] str1 = str.Split();
            int count=0;
            for (int i = 0; i < str1.Length; i++)
            {
                count++;
            }
            Console.WriteLine("number of words are"+ count);
        }
    }
    class Sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();

            double sum = 0; 
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] >'0' && str[i]<='9')
                {
                    Console.WriteLine(str[i]);
                    double x=char.GetNumericValue(str[i]);
                    sum = sum + x;
                }
            }
            Console.WriteLine("sum"+sum);

        }
    }
    class UpperToLower
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str=Console.ReadLine();
            string newst = " ";
            for(int i = 0; i < str.Length; i++)
            {
                char ch=str[i];
                if(ch>='A' && ch<='Z')
                {
                    ch = (char)(ch + 32);
                }
                else
                {
                    ch = (char)(ch - 32);
                }
                newst = newst+ ch;
            }
            Console.WriteLine(newst);
        }
    }
    class Anagram
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine("enter 1st string");
            string s=Console.ReadLine();
            Console.WriteLine("enter 2nd string");
            string s1 = Console.ReadLine();

            string st1=s.ToLower();
            string st2=s1.ToLower();

            char[] ch1=st1.ToCharArray();
            char[] ch2=st2.ToCharArray();

           for(int i=0; i<ch1.Length; i++)
            {
                for (int j = i + 1; j < ch1.Length; j++)
                {
                    if (ch1[i] < ch1[j])
                    {
                        char temp = ch1[i];
                        ch1[i] = ch1[j];
                        ch1[j] = temp;
                    }
                }
            }
            for (int i = 0; i < ch2.Length; i++)
            {
                for (int j = i + 1; j < ch2.Length; j++)
                {
                    if (ch2[i] < ch2[j])
                    {
                        char temp = ch2[i];
                        ch2[i] = ch2[j];
                        ch2[j] = temp;
                    }
                }
            }

            Console.WriteLine(String.Join(" ", ch1));
            Console.WriteLine(String.Join(" ", ch2));
            Array.Sort(ch1);
            Array.Sort(ch2);
            Console.WriteLine("///////////////////////////////");
            Console.WriteLine(String.Join(" ", ch1));
            Console.WriteLine(String.Join(" ", ch2));

            string str1=new string(ch1);
            string str2=new string(ch2);

            if(str1.Equals(str2))
            {
                Console.WriteLine("string is Anagram");
            }
            else
            {
                Console.WriteLine("string is not Anagram");
            }


        }
    }
    class Stringbuilderdemo
    {
        static void Main(string[] args)
        {
            string s = " pune ";
            StringBuilder sb = new StringBuilder(s);
            Console.WriteLine(sb);
            sb.Append("  city  ");
            Console.WriteLine(sb);
            sb.AppendLine("  for fun  ");
            Console.WriteLine(sb);
            sb.Insert(6, "C#");
            Console.WriteLine(sb);

            sb.Remove(2, 6);
            Console.WriteLine(sb);

            for(int i=0;i<sb.Length;i++)
            {
                Console.WriteLine(sb[i]);
            }
        }
    }
    class Stringbuilder
    {
        static void Main(string[] args)
        {
            string s = "india";
            StringBuilder sb= new StringBuilder(s);
            sb.Append("");
            Console.WriteLine(sb);
            sb.Remove(2,3);
            Console.WriteLine(sb);
            sb.AppendLine("d");
            Console.WriteLine(sb);


        }
    }
    class Palindrome
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();
            string revser = "";
            for(int i = s.Length - 1; i >= 0; i--)
            {
                revser=revser + s[i];
            }
            Console.WriteLine(revser);
            if(revser.Equals(s))
            {
                Console.WriteLine("string is palindrome");

            }
            else
            {
                Console.WriteLine("string is not palindrome");
            }
            Console.ReadLine();
            

           

            
        }
    }
    class Average
    {
        static void Main(string[] args)
        {
            double count=0,sum=0,avg;
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();


            
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] > '0' && str[i] <= '9')
                {
                    Console.WriteLine(str[i]);
                    double x = char.GetNumericValue(str[i]);
                    sum = sum + x;
                    count++;
                }
            }
            Console.WriteLine("sum of string is" + sum);
            avg = sum / count;
            Console.WriteLine("avg of string" + avg);
        }
    }
    class Reverseword
    {
        static void Main(string[] args)
        {
            string str = "india is my country";
            string reverse = "";
            for(int i = 0; i < str.Length; i++)
            {
                reverse = str[i] + reverse;
                
            }
            Console.WriteLine(reverse);
        }
    }
    class Reverseword2
    {
        static void Main(string[] args)
        {
            string str = "india is my country";
            string reverse = "";
            for (int i = str.Length-1;i>=0; i--)
            {
                reverse = str[i] + reverse;

            }
            Console.WriteLine(reverse);
        }
    }
    class Reverseword3
    {
        static void Main(string[] args)
        {
            string s = "india is my country";
            Console.WriteLine(s);
            string[] str1 = s.Split();
            string reverse = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverse = reverse+ s[i];
            }
            Console.WriteLine(reverse);
            


            
        }
    }
    class EvenAvg
    {
        static void Main(string[] args)
        {

            int sum = 0, count = 0, avg;
            int[] a = { 2, 3, 5, 4, 18, 17, 23, 30, 8, 6, 10 };
            Console.WriteLine(String.Join(" ", a));
            Console.WriteLine("even element are");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(a[i]);
                    sum = sum + a[i];
                    count++;
                }
            }
            Console.WriteLine("sum of even element is" + sum);
            avg = sum / count;
            Console.WriteLine("avg of even elements" + avg);

        }
    }
    class Sorthalf
    {
        static void Main(string[] args)
        {
            char[] ch = new char[8];
            Console.WriteLine("enter array Element");
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine(".....................");
            Console.WriteLine(String.Join(" ", ch));

            for (int i = 0; i < ch.Length; i++)
            {
                for (int j = i + 1; j < ch.Length / 2; j++)
                {
                    if (ch[i] < ch[j])
                    {
                        char temp = ch[i];
                        ch[i] = ch[j];
                        ch[j] = temp;
                    }
                }
            }

            for (int i = ch.Length / 2; i < ch.Length; i++)
            {
                for (int j = i + 1; j < ch.Length; j++)
                {
                    if (ch[i] > ch[j])
                    {
                        char temp = ch[i];
                        ch[i] = ch[j];
                        ch[j] = temp;
                    }
                }
            }

            Console.WriteLine(String.Join(" ", ch));
        }
    }
}



