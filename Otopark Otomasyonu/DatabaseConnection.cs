using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu
{
    public class DatabaseConnection
    {
        public string connectionString;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        public DatabaseConnection()
        {
            connectionString = "Data Source=CAN-ATA;Initial Catalog=otopark_simulasyonu;Integrated Security = True";
            connection = new SqlConnection(connectionString);
          
        }
        public void CloseConnection()
        {
            connection.Close();
        }

        public SqlDataReader DataReader(string query)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand(query,connection);
            var execute = cmd.ExecuteReader();
            
            return execute; 
        }
        public bool State()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void OpenConnection()
        {
            connection.Open();
        }
        public bool State()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SqlProcess(string query)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand(query,connection);
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
        }
        
       

    }
}
