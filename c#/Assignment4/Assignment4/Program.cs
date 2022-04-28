using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        abstract class Student
        {
            public string sName;
            public int sId;
            public double grade;

            public abstract Boolean IsPassed(double grade);

        }
        class Undergraduate : Student
        {

            public override bool IsPassed(double grade)
            {
                Console.WriteLine("enter name");
                sName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("enter id");
                sId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter grade");
                grade = Convert.ToDouble(Console.ReadLine());
                if (grade > 70.0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        class Grad : Student
        {
            public override bool IsPassed(double grade)
            {
                Console.WriteLine("enter name");
                sName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("enter id");
                sId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter  grade");
                grade = Convert.ToDouble(Console.ReadLine());
                if (grade > 80.0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            internal class Program
            {
                static void Main(string[] args)
                {
                    Student student;
                    student = new Undergraduate();
                    Console.WriteLine(student.IsPassed(student.grade));
                    student = new Grad();
                    Console.WriteLine(student.IsPassed(student.grade));
                    Console.Read();
                }
            }
        }
    }
}

