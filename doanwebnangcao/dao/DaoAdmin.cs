using doanwebnangcao.entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace doanwebnangcao.dao
{
    public class DaoAdmin
    {
        public static Admin GetOneAdminLogin(string _taikhoanAD, string _matKhauAD)
        {
            Admin objAD = null;

            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;

            string sql = "select MaAD, TaiKhoanAD, MatKhauAD, TenAD from aDMIN where TaiKhoanAD=@taikhoanAD and MatKhauAD=@matKhauAD";

            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.Parameters.Add("@taikhoanAD", System.Data.SqlDbType.VarChar).Value = _taikhoanAD;
                sqlCommand.Parameters.Add("@matkhauAD", System.Data.SqlDbType.VarChar).Value = _matKhauAD;

                sqlCommand.CommandType = System.Data.CommandType.Text;

                conn.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    objAD = new Admin();
                    objAD.MaAD = Convert.ToInt32(reader["MaAD"]);
                    objAD.TaiKhoanAD = Convert.ToString(reader["TaiKhoanAD"]);
                    objAD.MatKhauAD = Convert.ToString(reader["MatKhauAD"]);
                    objAD.TenAD = Convert.ToString(reader["TenAD"]);
                }
                reader.Close();//Đóng đối tượng DataReader
                conn.Close();//Đóng kết nối
                conn.Dispose();//Giải phóng bộ nhớ
                return objAD;
            }

        }
    }
}