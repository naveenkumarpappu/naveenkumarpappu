using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for student program
            Student student = new Student();
            student.displayResult();
            student.displayData();
            Console.WriteLine("-----------");
            //for car
            car car = new car(1234, "GTR", "Sports");
            car.showdetails();
            car.Carno = 9531;
            car.Carname = "Mustang";
            car.cartype = "muscle";
            Console.WriteLine("after change");
            Console.WriteLine($"car no is {car.carno} carname is {car.carname}and cartype is {car.cartype});
Console.WriteLine("---------");
            //loan
            Console.WriteLine("enter money");
            double amount=Convert.ToInt32(Console.ReadLine());
            Loan loan = new Loan();
            Loan.loanCalculator(amount);
            Console.Read();


        }
    }
}
