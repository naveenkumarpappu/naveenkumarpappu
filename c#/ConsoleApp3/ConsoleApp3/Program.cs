using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assgn2
{
    internal class Program
    {
        public void array()
        {
            int sum = 0;
            Console.WriteLine("enter size");
            int size=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("enter vales");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-----------");
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
                sum += arr[i];
            }
            int average=sum/arr.Length;
            Console.WriteLine("average of an array="+average);
            Console.WriteLine("Minimum value of an array=" + arr.Min());
            Console.WriteLine("maximum value of an array=" + arr.Max());
        }
        static void Main(string[] args)
        {


        }
    }
}
