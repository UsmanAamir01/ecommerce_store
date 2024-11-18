using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace ecommerce
{
    class Database
    {

        public OracleConnection GetConnection()
        {
            string connectionstring = "User Id= Ecomdb; Password = 37093688; Data Source=//localhost:1521/XE";
            return new OracleConnection(connectionstring);
        }
    }

}
