using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungBanHang.Data
{
    public class Connection
    {
        private static string connString = LinkConnection.linkConnection;
        public static SqlConnection CreateConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                return conn;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }
    }
}
