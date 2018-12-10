using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Cidades
{
    public class DataBase
    {
        private string connectionString = "Server=localhost;Database=TCS_AbstactFactory;Trusted_Connection=True;";
        private SqlConnection connection;
        public DataBase()
        {
            //connectionString = "Data Source='localhost';Database=tcs_abstractfactory;Uid=root;Pwd=master.007,1";
            connection = new SqlConnection(connectionString);
        }

        public SqlDataReader ExecuteQuery(string query, bool hasReturnValue)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            if (hasReturnValue)
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return reader;
                }
            }
            else
            {
                command.ExecuteNonQuery();
            }
            connection.Close();
            return null;

        }
    }
}
