using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GestContactManager
    {
        private const string connectionString = "Data Source=(local);Initial Catalog=GestionContact;Integrated Security=True";

        private SqlConnection sqlConnection = new SqlConnection(connectionString);

        public SqlConnection Sqlconnection
        {
            get
            {
                return sqlConnection;
            }
        }
        public bool Open()
        {
            try
            {
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                    sqlConnection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Close()
        {
            try
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                    sqlConnection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}