using doanwebnangcao.entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace doanwebnangcao.dao
{
    public class DaoNguoiDung
    {
        public static List<NguoiDung> getAllNguoiDung()
        {
            List<NguoiDung> lstND = new List<NguoiDung>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT ID, Email, MatKhau, FullName FROM NguoiDung";
            //Định nghĩa đối tượng Connection
            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                //Khởi tạo đối tượng Command
                SqlCommand sqlCommand = new SqlCommand(strSQL, sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.Text;
                //Mở kết nối tới CSDL
                sqlConnection.Open();
                //Sử dụng đối tượng DataReader để đọc dữ liệu
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                NguoiDung objND = null;
                while (sqlDataReader.Read())
                {
                    objND = new NguoiDung();


                    objND.ID = Convert.ToInt32(sqlDataReader["ID"]);
                    objND.Email = Convert.ToString(sqlDataReader["Email"]);
                    objND.MatKhau = Convert.ToString(sqlDataReader["MatKhau"]);
                    objND.FullName = Convert.ToString(sqlDataReader["FullName"]);
                   

                    lstND.Add(objND);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstND;
            }
        }

        public static NguoiDung getOneNguoiDung(int _iD)
        {
            NguoiDung objND = null;
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT ID, Email, MatKhau, FullName FROM NguoiDung where ID = '" + _iD + "'";
            //Định nghĩa đối tượng Connection
            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                //Khởi tạo đối tượng Command
                SqlCommand sqlCommand = new SqlCommand(strSQL, sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.Text;
                //Mở kết nối tới CSDL
                sqlConnection.Open();
                //Sử dụng đối tượng DataReader để đọc dữ liệu
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    objND = new NguoiDung();


                    objND.ID = Convert.ToInt32(sqlDataReader["ID"]);
                    objND.Email = Convert.ToString(sqlDataReader["Email"]);
                    objND.MatKhau = Convert.ToString(sqlDataReader["MatKhau"]);
                    objND.FullName = Convert.ToString(sqlDataReader["FullName"]);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return objND;
            }
        }

        public static NguoiDung GetOneNguoiDungLogin(string _email, string _matKhau)
        {
            NguoiDung objND = null;

            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;

            string sql = "select ID,Email,MatKhau,FullName from [NguoiDung] where Email=@email and MatKhau=@matKhau";

            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = _email;
                sqlCommand.Parameters.Add("@matKhau", System.Data.SqlDbType.VarChar).Value = _matKhau;

                sqlCommand.CommandType = System.Data.CommandType.Text;

                conn.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    objND = new NguoiDung();
                    objND.ID = Convert.ToInt32(reader["ID"]);
                    objND.Email = Convert.ToString(reader["Email"]);
                    objND.MatKhau = Convert.ToString(reader["MatKhau"]);
                    objND.FullName = Convert.ToString(reader["FullName"]);
                }
                reader.Close();//Đóng đối tượng DataReader
                conn.Close();//Đóng kết nối
                conn.Dispose();//Giải phóng bộ nhớ
                return objND;
            }

        }
    }
}