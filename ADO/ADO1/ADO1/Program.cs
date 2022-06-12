
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BasicADO
{​​
class Program
    {​​
public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        static void Main(string[] args)
        {​​
SelectData();
            // GetScalarFun();
            Console.Read();
        }​​
public static void GetScalarFun()
        {​​
con = getcon();
            cmd = new SqlCommand("select count(Empid) from tblEmployee", con);
            int empcount = Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine("No of Employees : {​​0}​​", empcount);
        }​​
public static void SelectData()
        {​​
con = getcon();
            cmd = new SqlCommand("select * from tblEmployee", con);
            dr = cmd.ExecuteReader(); while (dr.Read())
            {​​
Console.WriteLine("Employee Id : " + dr[0] + " Employee Name : " + dr[1] +
" Employee Gender : " + dr[2] + " Employee Salary : " + dr[3]);
            }​​
}​​
public static SqlConnection getcon()
        {​​
con = new SqlConnection("data source  LAPTOP-JOMHCDDM\\SQLEXPRESS01; Initial catalog = Zensar; " + "user id= sa; password = Temp1234");
            con.Open();
            return con;
        }​​
}​​
}​​

