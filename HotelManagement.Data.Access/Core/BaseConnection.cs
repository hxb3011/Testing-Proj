using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data.Access.Core
{
    public static class BaseConnection
    {
        public static MySqlConnection Connection
            => new(new MySqlConnectionStringBuilder()
            {
                Server = "localhost",
                Database = "qlks",
                UserID = "toan",
                Password = "123",
                Port = 3306
            }.ToString());

        public static MySqlConnection getConnection()
        {
            var mysqlBuilder = new MySqlConnectionStringBuilder();
            mysqlBuilder["Server"] = "localhost";
            mysqlBuilder["Database"] = "qlks";
            mysqlBuilder["UID"] = "toan";
            mysqlBuilder["PWD"] = "123";
            mysqlBuilder["Port"] = "3306";

            string mysqlStringConnection = mysqlBuilder.ToString();

            MySqlConnection connection = new MySqlConnection(mysqlStringConnection);

            return connection;
        }

    }
}
