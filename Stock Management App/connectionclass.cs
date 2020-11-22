using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Stock_Management_App
{
    public static class connectionclass
    { 
        public static SqlConnection Getconnection()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0EGE15A;Initial Catalog=Stock;Integrated Security=True");
            return con;
        }
    }
}
