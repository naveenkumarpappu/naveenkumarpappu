using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }

        //DateTime d = new DateTime();
        public List<Employee> employees()
        {
            List<Employee> empList = new List<Employee>();

            Employee e1 = new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 06, 08), City = "Mumbai" };
            Employee e2 = new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 08, 20), DOJ = new DateTime(2012, 07, 07), City = "Mumbai" };
            Employee e3 = new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 04, 12), City = "Pune" };
            Employee e4 = new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 06, 03), DOJ = new DateTime(2016, 02, 02), City = "Pune" };
            Employee e5 = new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 03, 08), DOJ = new DateTime(2016, 02, 02), City = "Mumbai" };
            Employee e6 = new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Cosultant", DOB = new DateTime(1989, 11, 07), DOJ = new DateTime(2014, 08, 08), City = "Chennai" };
            Employee e7 = new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 02), DOJ = new DateTime(2015, 06, 01), City = "Mumbai" };
            Employee e8 = new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 06), City = "Chennai" };
            Employee e9 = new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 08, 12), DOJ = new DateTime(2014, 12, 03), City = "Chennai" };
            Employee e10 = new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1981, 04, 12), DOJ = new DateTime(2016, 01, 02), City = "Pune" };
            empList.Add(e1);
            empList.Add(e2);
            empList.Add(e3);
            empList.Add(e4);
            empList.Add(e5);
            empList.Add(e6);
            empList.Add(e7);
            empList.Add(e8);
            empList.Add(e9);
            empList.Add(e10);
            return empList;
        }
    }
    class Query
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Console.WriteLine(" ");
            Console.WriteLine("Details of All Employees");
            IEnumerable<Employee> empnames = from emp in e1.employees()
                                             select emp;
            foreach (var v in empnames)
            {
                Console.WriteLine($"Employye id ={v.EmployeeID}, Name = {v.FirstName} {v.LastName}, Working As {v.Title},Date of birth {v.DOB},date of joining {v.DOJ},and location is{v.City}");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Details of Employees whose Location is not Mumbai");
            IEnumerable<Employee> location = from l in e1.employees()
                                             where l.City != "Mumbai"
                                             select l;
            foreach (var v in location)
            {
                Console.WriteLine($"Employye id ={v.EmployeeID}, Name = {v.FirstName} {v.LastName}, Working As {v.Title},Date of birth {v.DOB},date of joining {v.DOJ},and location is{v.City}");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Employees who are Assistant Manager");
            IEnumerable<Employee> title = from t in e1.employees()
                                          where t.Title == "AsstManager"
                                          select t;
            foreach (var v in title)
            {
                Console.WriteLine($"Employye id ={v.EmployeeID}, Name = {v.FirstName} {v.LastName}, Working As {v.Title},Date of birth {v.DOB},date of joining {v.DOJ},and location is{v.City}");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Employee Name Start's with S");
            IEnumerable<Employee> name = from n in e1.employees()
                                         where n.FirstName.Contains("S")
                                         select n;
            foreach (var v in name)
            {
                Console.WriteLine($"Employye id ={v.EmployeeID}, Name = {v.FirstName} {v.LastName}, Working As {v.Title},Date of birth {v.DOB},date of joining {v.DOJ},and location is{v.City}");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Employees who are Hired Before 1/1/2015");
            var date = from d in e1.employees()
                       where d.DOJ < DateTime.Parse("1/1/2015")
                       select d;

            foreach (var v in date)
            {

                Console.WriteLine($"Employye id ={v.EmployeeID}, Name = {v.FirstName} {v.LastName}, Working As {v.Title},Date of birth {v.DOB},date of joining {v.DOJ},and location is{v.City}");
            }
            Console.ReadLine();
        }
    }
}