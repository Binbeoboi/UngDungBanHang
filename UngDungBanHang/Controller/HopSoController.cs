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
    public class HopSoController
    {
        public List<HopSo> Get()
        {
            string query = "SELECT * FROM tbTheLoaiXe";
            List<HopSo> list = new List<HopSo>();
            try
            {
                using (SqlConnection cnn = Connection.CreateConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new HopSo()
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
