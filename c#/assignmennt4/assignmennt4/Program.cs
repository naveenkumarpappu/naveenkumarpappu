using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmennt4
{
    internal class student
    {
        public int studId;
        public string studName;
        public double examFee;

        public student(int studId, string studName, double examFee)
        {
            this.studId = studId;
            this.studName = studName;
            this.examFee = examFee;
        }

        public virtual void displayDetails()
        {
            Console.WriteLine("student name " + studName + " student id is " + studId + " and his examfee " + examFee);
        }
        public virtual double payFee(double feeAmount)
        {
            Console.WriteLine("fee paid is " + feeAmount);
            return examFee - feeAmount;
        }

    }
    class DayScholar : student
    {
        public double transportFee;

        public DayScholar(double transportFee, int studId, string studName, double examFee) : base(studId, studName, examFee)
        {
            this.transportFee = transportFee;
        }
        public override double payFee(double feeAmount)
        {
            return base.payFee(feeAmount) + transportFee;
        }
        public override void displayDetails()
        {
            base.displayDetails();
            Console.WriteLine("transport fee " + transportFee);
            Console.WriteLine("total fee " + (examFee + transportFee));
        }

    }
    class Hosteller : student
    {
        public double hostelFee;
        public Hosteller(double hostelFee, int studId, string studName, double examFee) : base(studId, studName, examFee)
        {
            this.hostelFee = hostelFee;
        }
        public override double payFee(double feeAmount)
        {
            return base.payFee(feeAmount) + hostelFee;
        }
        public override void displayDetails()
        {
            base.displayDetails();
            Console.WriteLine("hostel fee " + hostelFee);
            Console.WriteLine("total fee " + (examFee + hostelFee));
        }
    }
    class RunClass
    {
        public static void Main()
        {
            DayScholar d = new DayScholar(5000.0, 9441, "naveen", 152200.0);
            d.displayDetails();
            Console.WriteLine("remaining fee " + d.payFee(1500));
            Hosteller hosteller = new Hosteller(6000.0, 234, "horsey", 23000.0);
            hosteller.displayDetails();
            Console.WriteLine("remaining fee " + hosteller.payFee(1000));
            Console.ReadLine();
        }

    }
}
