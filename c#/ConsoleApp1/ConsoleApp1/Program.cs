using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static String str1;
        static String str2;
        static String str3;
        public static void Wlength()
        {
            Console.WriteLine("enter thr word");
            str1 = Console.ReadLine();
            Console.WriteLine(" the given word length is:", str1.Length);
            Console.WriteLine(str1.Length);
        }
        public static void Reverse()
        {
            Console.WriteLine("enter the word");
            str3 = Console.ReadLine();
            for (int i = str3.Length - 1; i >= 0; i--)
            {
                str2 = str2 + str3[i];
            }
            Console.WriteLine("reverse word is :{0}", str2);
        }

        static void Main(string[] args)
        {
            //String str1;
            //String str2;
            Wlength();
            Console.ReadLine();
            Reverse();
        }
    }
}
