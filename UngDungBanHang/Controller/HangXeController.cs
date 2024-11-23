using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UngDungBanHang.Data;
using UngDungBanHang.Model;

namespace UngDungBanHang.Controller
{
    public class HangXeController
    {
        public List<HangXe> Get()
        {
            string query = "SELECT * FROM tbHangXe";
            List<HangXe> list = new List<HangXe>();
            try
            {
                using (SqlConnection cnn = Connection.CreateConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new HangXe()
                        {
                            Ma = reader.GetInt32(0),
                            Ten = reader.GetString(1)
                        });
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return null;
            }
        }
    }
}
