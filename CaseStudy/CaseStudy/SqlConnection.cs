using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CaseStudy
{
    class SQLConnection
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlConnection getcon()
        {
            /* con = new SqlConnection("data source =LAPTOP-JOMHCDDM\\naveen kumar; Initial catalog =master;user id=Sa;password=Temp1234");
             con.Open();
             return con;*/
            String connection = @"data source=LAPTOP-JOMHCDDM\naveen kumar;Intial catalog=zensar;Integrated sSecurity=true";
            con = new SqlConnection(connection);
            con.Open();
            return con;
        }
    }
}
