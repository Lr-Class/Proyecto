using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class ConexionDbDCostaFood
    {
        public string ConnectionString;
        internal SqlConnection connection;
        public ConexionDbDCostaFood(string connetionString)
        {
            ConnectionString = connetionString;
            connection = new SqlConnection(ConnectionString);
        }
        public void Open()
        {
            connection.Open();
        }
        public void Close()
        {
            connection.Close();
        }
        
    }
}
