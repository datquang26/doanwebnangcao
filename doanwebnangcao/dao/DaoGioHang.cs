using doanwebnangcao.entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace doanwebnangcao.dao
{
    public class DaoGioHang
    {
        public static GioHang getOneGioHang(int _iD, int _maSanPham)
        {
            GioHang objGH = null;
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaGioHang, GioHang.MaSanPham, GioHang.ID, SoLuong, ThanhTien FROM GioHang, SanPham  where GioHang.MaSanPham = SanPham.MaSanPham and   GioHang.ID = '"+_iD+"' and SanPham.MaSanPham = '"+_maSanPham+"' ";
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
                    objGH = new GioHang();


                    objGH.MaGioHang = Convert.ToInt32(sqlDataReader["MaGioHang"]);
                    objGH.MaSanPham = Convert.ToInt32(sqlDataReader["MaSanPham"]);
                    objGH.ID = Convert.ToInt32(sqlDataReader["ID"]);
                    objGH.SoLuong = Convert.ToInt32(sqlDataReader["SoLuong"]);
                    objGH.ThanhTien = Convert.ToDouble(sqlDataReader["ThanhTien"]);

                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return objGH;
            }
        }
        public static GioHang TongTien(int _iD)
        {
            GioHang objGH = null;

            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;

            string sql = "select  ID, SUM(SanPham.GiaTien * SoLuong) as TongTien from SanPham, GioHang where GioHang.MaSanPham = SanPham.MaSanPham and ID = '" + _iD + "' group by ID";

            using (SqlConnection conn = new SqlConnection(strConnection))
            {
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.CommandType = System.Data.CommandType.Text;

                conn.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    objGH = new GioHang();
                    objGH.TongTien = Convert.ToString(reader["TongTien"]);
                }
                reader.Close();//Đóng đối tượng DataReader
                conn.Close();//Đóng kết nối
                conn.Dispose();//Giải phóng bộ nhớ
                return objGH;
            }
        }

        public static List<GioHang> getAllGioHangBySessionId(int _iD)
        {
            List<GioHang> lstGH = new List<GioHang>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaGioHang, SanPham.MaSanPham, NguoiDung.ID, SoLuong, SanPham.TenSanPham, SanPham.Anh1, SanPham.Anh2, SanPham.GiaTien, ThanhTien FROM GioHang, SanPham, NguoiDung where SanPham.MaSanPham = GioHang.MaSanPham and NguoiDung.ID =GioHang.ID and NguoiDung.ID = '" + _iD + "'";
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
                GioHang objGH = null;
                while (sqlDataReader.Read())
                {
                    objGH = new GioHang();


                    objGH.MaGioHang = Convert.ToInt32(sqlDataReader["MaGioHang"]);
                    objGH.MaSanPham = Convert.ToInt32(sqlDataReader["MaSanPham"]);
                    objGH.ID = Convert.ToInt32(sqlDataReader["ID"]);
                    objGH.SoLuong = Convert.ToInt32(sqlDataReader["SoLuong"]);
                    objGH.TenSanPham = Convert.ToString(sqlDataReader["TenSanPham"]);
                    objGH.GiaTien = Convert.ToInt32(sqlDataReader["GiaTien"]);
                    objGH.Anh1 = Convert.ToString(sqlDataReader["Anh1"]);
                    objGH.Anh2 = Convert.ToString(sqlDataReader["Anh2"]);
                    objGH.ThanhTien = Convert.ToDouble(sqlDataReader["ThanhTien"]);

                    lstGH.Add(objGH);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstGH;
            }
        }
    }
    
}