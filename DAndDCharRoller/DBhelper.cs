using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAndDCharRoller
{
    class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con =
                new SqlConnection();
            con.ConnectionString =
                "Data Source=DESKTOP-AS62QIP\\SQLEXPRESS;Initial Catalog=BookRegistration;Integrated Security=True";
            return con;
        }
    }
}
