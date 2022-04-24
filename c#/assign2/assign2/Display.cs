using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign2
{
    internal class Display
    {
         public void StringProgram()
        {
            Console.WriteLine(" enter the word");
            String S1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine(S1.Length);
            string s2 = "";
            for(int i=S1.Length-1;i>=0;i--)
            {
                s2 = s2 + S1[i];
            }
            Console.WriteLine(s2);
            Console.WriteLine("enter the word");
            String first = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter the second word");
            String second = Convert.ToString(Console.ReadLine());
            if(first==second)
            {
                Console.WriteLine(first + "and" + second + " are same");
            }
            else
            {
                Console.WriteLine(first + "and" + second + "are not same");
            }
        }
    }
}
