using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace Codebase3
{
    public class Employee

    {

        public static void Main()

        {
            string connectionString = "Data Source=LAPTOP-JOMHCDDM\SQLEXPRESS01;" + "Initial Catalog=store;Integrated Security=SSPI";
            string procedure = "CustomerAdd";
            String strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetEmployeeDetailsByID";
            cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = txtID.Text.Trim();
            cmd.Connection = con;
            try
            {
                con.Open();
                GridView1.EmptyDataText = "No Records Found";
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}
