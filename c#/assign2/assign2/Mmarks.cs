using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign2
{
    internal class Mmarks
    {
            public void tmarks()
        {
            int totalMarks = 0;
            int[] arr = new int[10];
            Console.WriteLine("enter marks");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-----");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                totalMarks += arr[i];
            }
            Console.WriteLine("total marks=" + totalMarks);
            int average = totalMarks / arr.Length;
            Console.WriteLine("average Marks=" + average);
            Console.WriteLine("Minimum marks=" + arr.Min());
            Console.WriteLine("Minimum marks=" + arr.Max());
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
            }
            Console.WriteLine("ascending order");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                Console.WriteLine("decending order");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);

                }
            }

        }
    }
}

