using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Hizmet.SetSqlConnection
{
    public class SetSqlConectionConfiguration
    {
        public static SqlConnection SetConnectionString()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["baglanti"]);
            return con;
        }
    }
}
