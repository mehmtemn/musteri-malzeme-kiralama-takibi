using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Hizmet.SetSqlConnection
{
    public class SetSqlConnectionConfigurationItem
    {
        public SqlConnection SetConnectionStringNonStatic()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["baglanti"]);
            return con;
        }
    }
}
