using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnt4
{
    internal class Employee
    {
        public int Empid;
        public string EMpame;
        public float Salary;

        public Employee()
        {
            Console.WriteLine("enter e id");
            Empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter e name");
            EMpame = Console.ReadLine();
            Console.WriteLine("enter e salary");
            Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employee id " + Empid + " Emplyee name " + EMpame + " and Salary is " + Salary);
        }
    }
    class ParttimeEmployee : Employee
    {
        public int Wages;

        public ParttimeEmployee() : base()
        {
            Console.WriteLine("enter wages");
            Wages = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("wages " + Wages);
        }

    }
    class main
    {
        public static void Main(string[] args)
        {
            ParttimeEmployee parttimeEmployee = new ParttimeEmployee();
            Console.ReadLine();
        }
    }
}
