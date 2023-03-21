using doanwebnangcao.entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace doanwebnangcao.dao
{
    public class DaoSanPham
    {
        public static List<SanPham> getAllSanPham()
        {
            List<SanPham> lstGT = new List<SanPham>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaSanPham, TenSanPham, GiaTien, NhanVat, HangSanXuat, KichThuoc, PhatHanh, Anh1, Anh2, Anh3, Anh4, Anh5, Anh6, CategoryId, LoaiSP, Series, MaLoaiSP FROM SanPham";
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
                SanPham objSP = null;
                while (sqlDataReader.Read())
                {
                    objSP = new SanPham();


                    objSP.MaSanPham = Convert.ToInt32(sqlDataReader["MaSanPham"]);
                    objSP.TenSanPham = Convert.ToString(sqlDataReader["TenSanPham"]);
                    objSP.GiaTien = Convert.ToInt32(sqlDataReader["GiaTien"]);
                    objSP.NhanVat = Convert.ToString(sqlDataReader["NhanVat"]);
                    objSP.KichThuoc = Convert.ToString(sqlDataReader["KichThuoc"]);
                    objSP.PhatHanh = Convert.ToDateTime(sqlDataReader["PhatHanh"]);
                    objSP.Anh1 = Convert.ToString(sqlDataReader["Anh1"]);
                    objSP.Anh2 = Convert.ToString(sqlDataReader["Anh2"]);
                    objSP.Anh3 = Convert.ToString(sqlDataReader["Anh3"]);
                    objSP.Anh4 = Convert.ToString(sqlDataReader["Anh4"]);
                    objSP.Anh5 = Convert.ToString(sqlDataReader["Anh5"]);
                    objSP.Anh6 = Convert.ToString(sqlDataReader["Anh6"]);
                    objSP.CategoryId = Convert.ToInt32(sqlDataReader["CategoryId"]);
                    objSP.LoaiSP = Convert.ToString(sqlDataReader["LoaiSP"]);
                    objSP.Series = Convert.ToString(sqlDataReader["Series"]);
                    objSP.MaLoaiSP = Convert.ToInt32(sqlDataReader["MaLoaiSP"]);

                    lstGT.Add(objSP);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstGT;
            }
        }
        public static List<SanPham> getAllSanPhamByMaSanPham(int _maSanPham)
        {
            List<SanPham> lstSP = new List<SanPham>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaSanPham, TenSanPham, GiaTien, NhanVat, HangSanXuat, KichThuoc, PhatHanh, Anh1, Anh2, Anh3, Anh4, Anh5, Anh6, CategoryId, LoaiSP, Series, MaLoaiSP FROM SanPham  where MaSanPham='" + _maSanPham + "'";
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
                SanPham objSP = null;
                while (sqlDataReader.Read())
                {
                    objSP = new SanPham();


                    objSP.MaSanPham = Convert.ToInt32(sqlDataReader["MaSanPham"]);
                    objSP.TenSanPham = Convert.ToString(sqlDataReader["TenSanPham"]);
                    objSP.GiaTien = Convert.ToInt32(sqlDataReader["GiaTien"]);

                    objSP.NhanVat = Convert.ToString(sqlDataReader["NhanVat"]);
                    objSP.HangSanXuat = Convert.ToString(sqlDataReader["HangSanXuat"]);
                    objSP.KichThuoc = Convert.ToString(sqlDataReader["KichThuoc"]);
                    objSP.PhatHanh = Convert.ToDateTime(sqlDataReader["PhatHanh"]);
                    objSP.Anh1 = Convert.ToString(sqlDataReader["Anh1"]);
                    objSP.Anh2 = Convert.ToString(sqlDataReader["Anh2"]);
                    objSP.Anh3 = Convert.ToString(sqlDataReader["Anh3"]);
                    objSP.Anh4 = Convert.ToString(sqlDataReader["Anh4"]);
                    objSP.Anh5 = Convert.ToString(sqlDataReader["Anh5"]);
                    objSP.Anh6 = Convert.ToString(sqlDataReader["Anh6"]);
                    objSP.CategoryId = Convert.ToInt32(sqlDataReader["CategoryId"]);
                    objSP.LoaiSP = Convert.ToString(sqlDataReader["LoaiSP"]);
                    objSP.Series = Convert.ToString(sqlDataReader["Series"]);
                    objSP.MaLoaiSP = Convert.ToInt32(sqlDataReader["MaLoaiSP"]);







                    lstSP.Add(objSP);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstSP;
            }
        }

        public static List<SanPham> getAllSanPhamFigma()
        {
            List<SanPham> lstSP = new List<SanPham>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaSanPham, TenSanPham, GiaTien, NhanVat, HangSanXuat, KichThuoc, PhatHanh, Anh1, Anh2, Anh3, Anh4, Anh5, Anh6, CategoryId, LoaiSP, Series FROM SanPham where LoaiSP = 'figma' and YEAR(PhatHanh) >= 2022 ";
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
                SanPham objSP = null;
                while (sqlDataReader.Read())
                {
                    objSP = new SanPham();


                    objSP.MaSanPham = Convert.ToInt32(sqlDataReader["MaSanPham"]);
                    objSP.TenSanPham = Convert.ToString(sqlDataReader["TenSanPham"]);
                    objSP.GiaTien = Convert.ToInt32(sqlDataReader["GiaTien"]);

                    objSP.NhanVat = Convert.ToString(sqlDataReader["NhanVat"]);
                    objSP.HangSanXuat = Convert.ToString(sqlDataReader["HangSanXuat"]);
                    objSP.KichThuoc = Convert.ToString(sqlDataReader["KichThuoc"]);
                    objSP.PhatHanh = Convert.ToDateTime(sqlDataReader["PhatHanh"]);
                    objSP.Anh1 = Convert.ToString(sqlDataReader["Anh1"]);
                    objSP.Anh2 = Convert.ToString(sqlDataReader["Anh2"]);
                    objSP.Anh3 = Convert.ToString(sqlDataReader["Anh3"]);
                    objSP.Anh4 = Convert.ToString(sqlDataReader["Anh4"]);
                    objSP.Anh5 = Convert.ToString(sqlDataReader["Anh5"]);
                    objSP.Anh6 = Convert.ToString(sqlDataReader["Anh6"]);
                    objSP.CategoryId = Convert.ToInt32(sqlDataReader["CategoryId"]);
                    objSP.LoaiSP = Convert.ToString(sqlDataReader["LoaiSP"]);
                    objSP.Series = Convert.ToString(sqlDataReader["Series"]);






                    lstSP.Add(objSP);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstSP;
            }
        }

        public static List<SanPham> getAllTenSanPhamFigma(string _tenSanPham)
        {
            List<SanPham> lstSP = new List<SanPham>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaSanPham, TenSanPham, GiaTien, NhanVat, HangSanXuat, KichThuoc, PhatHanh, Anh1, Anh2, Anh3, Anh4, Anh5, Anh6, CategoryId, LoaiSP, Series FROM SanPham where LoaiSP = 'figma' and TenSanPham like N'%" + _tenSanPham + "%'";
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
                SanPham objSP = null;
                while (sqlDataReader.Read())
                {
                    objSP = new SanPham();


                    objSP.MaSanPham = Convert.ToInt32(sqlDataReader["MaSanPham"]);
                    objSP.TenSanPham = Convert.ToString(sqlDataReader["TenSanPham"]);
                    objSP.GiaTien = Convert.ToInt32(sqlDataReader["GiaTien"]);

                    objSP.NhanVat = Convert.ToString(sqlDataReader["NhanVat"]);
                    objSP.HangSanXuat = Convert.ToString(sqlDataReader["HangSanXuat"]);
                    objSP.KichThuoc = Convert.ToString(sqlDataReader["KichThuoc"]);
                    objSP.PhatHanh = Convert.ToDateTime(sqlDataReader["PhatHanh"]);
                    objSP.Anh1 = Convert.ToString(sqlDataReader["Anh1"]);
                    objSP.Anh2 = Convert.ToString(sqlDataReader["Anh2"]);
                    objSP.Anh3 = Convert.ToString(sqlDataReader["Anh3"]);
                    objSP.Anh4 = Convert.ToString(sqlDataReader["Anh4"]);
                    objSP.Anh5 = Convert.ToString(sqlDataReader["Anh5"]);
                    objSP.Anh6 = Convert.ToString(sqlDataReader["Anh6"]);
                    objSP.CategoryId = Convert.ToInt32(sqlDataReader["CategoryId"]);
                    objSP.LoaiSP = Convert.ToString(sqlDataReader["LoaiSP"]);
                    objSP.Series = Convert.ToString(sqlDataReader["Series"]);






                    lstSP.Add(objSP);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstSP;
            }
        }

        public static List<SanPham> getAllTenSanPhamPop(string _tenSanPham)
        {
            List<SanPham> lstSP = new List<SanPham>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaSanPham, TenSanPham, GiaTien, NhanVat, HangSanXuat, KichThuoc, PhatHanh, Anh1, Anh2, Anh3, Anh4, Anh5, Anh6, CategoryId, LoaiSP, Series FROM SanPham where LoaiSP = 'pop' and TenSanPham like N'%" + _tenSanPham + "%'";
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
                SanPham objSP = null;
                while (sqlDataReader.Read())
                {
                    objSP = new SanPham();


                    objSP.MaSanPham = Convert.ToInt32(sqlDataReader["MaSanPham"]);
                    objSP.TenSanPham = Convert.ToString(sqlDataReader["TenSanPham"]);
                    objSP.GiaTien = Convert.ToInt32(sqlDataReader["GiaTien"]);

                    objSP.NhanVat = Convert.ToString(sqlDataReader["NhanVat"]);
                    objSP.HangSanXuat = Convert.ToString(sqlDataReader["HangSanXuat"]);
                    objSP.KichThuoc = Convert.ToString(sqlDataReader["KichThuoc"]);
                    objSP.PhatHanh = Convert.ToDateTime(sqlDataReader["PhatHanh"]);
                    objSP.Anh1 = Convert.ToString(sqlDataReader["Anh1"]);
                    objSP.Anh2 = Convert.ToString(sqlDataReader["Anh2"]);
                    objSP.Anh3 = Convert.ToString(sqlDataReader["Anh3"]);
                    objSP.Anh4 = Convert.ToString(sqlDataReader["Anh4"]);
                    objSP.Anh5 = Convert.ToString(sqlDataReader["Anh5"]);
                    objSP.Anh6 = Convert.ToString(sqlDataReader["Anh6"]);
                    objSP.CategoryId = Convert.ToInt32(sqlDataReader["CategoryId"]);
                    objSP.LoaiSP = Convert.ToString(sqlDataReader["LoaiSP"]);
                    objSP.Series = Convert.ToString(sqlDataReader["Series"]);






                    lstSP.Add(objSP);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstSP;
            }
        }

        public static List<SanPham> getAllSanPhamFigmaByCategoryId(int _categoryId)
        {
            List<SanPham> lstSP = new List<SanPham>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaSanPham, TenSanPham, GiaTien, NhanVat, HangSanXuat, KichThuoc, PhatHanh, Anh1, Anh2, Anh3, Anh4, Anh5, Anh6, CategoryId, LoaiSP, Series FROM SanPham where CategoryId ='" + _categoryId + "' and LoaiSP ='figma' ";
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
                SanPham objSP = null;
                while (sqlDataReader.Read())
                {
                    objSP = new SanPham();


                    objSP.MaSanPham = Convert.ToInt32(sqlDataReader["MaSanPham"]);
                    objSP.TenSanPham = Convert.ToString(sqlDataReader["TenSanPham"]);
                    objSP.GiaTien = Convert.ToInt32(sqlDataReader["GiaTien"]);

                    objSP.NhanVat = Convert.ToString(sqlDataReader["NhanVat"]);
                    objSP.HangSanXuat = Convert.ToString(sqlDataReader["HangSanXuat"]);
                    objSP.KichThuoc = Convert.ToString(sqlDataReader["KichThuoc"]);
                    objSP.PhatHanh = Convert.ToDateTime(sqlDataReader["PhatHanh"]);
                    objSP.Anh1 = Convert.ToString(sqlDataReader["Anh1"]);
                    objSP.Anh2 = Convert.ToString(sqlDataReader["Anh2"]);
                    objSP.Anh3 = Convert.ToString(sqlDataReader["Anh3"]);
                    objSP.Anh4 = Convert.ToString(sqlDataReader["Anh4"]);
                    objSP.Anh5 = Convert.ToString(sqlDataReader["Anh5"]);
                    objSP.Anh6 = Convert.ToString(sqlDataReader["Anh6"]);
                    objSP.CategoryId = Convert.ToInt32(sqlDataReader["CategoryId"]);
                    objSP.LoaiSP = Convert.ToString(sqlDataReader["LoaiSP"]);
                    objSP.Series = Convert.ToString(sqlDataReader["Series"]);






                    lstSP.Add(objSP);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstSP;
            }
        }


        public static List<SanPham> getAllSanPhamPop()
        {
            List<SanPham> lstSP = new List<SanPham>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaSanPham, TenSanPham, GiaTien, NhanVat, HangSanXuat, KichThuoc, PhatHanh, Anh1, Anh2, Anh3, Anh4, Anh5, Anh6, CategoryId, LoaiSP, Series FROM SanPham where LoaiSP = 'pop' and YEAR(PhatHanh) >= 2022";
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
                SanPham objSP = null;
                while (sqlDataReader.Read())
                {
                    objSP = new SanPham();


                    objSP.MaSanPham = Convert.ToInt32(sqlDataReader["MaSanPham"]);
                    objSP.TenSanPham = Convert.ToString(sqlDataReader["TenSanPham"]);
                    objSP.GiaTien = Convert.ToInt32(sqlDataReader["GiaTien"]);

                    objSP.NhanVat = Convert.ToString(sqlDataReader["NhanVat"]);
                    objSP.HangSanXuat = Convert.ToString(sqlDataReader["HangSanXuat"]);
                    objSP.KichThuoc = Convert.ToString(sqlDataReader["KichThuoc"]);
                    objSP.PhatHanh = Convert.ToDateTime(sqlDataReader["PhatHanh"]);
                    objSP.Anh1 = Convert.ToString(sqlDataReader["Anh1"]);
                    objSP.Anh2 = Convert.ToString(sqlDataReader["Anh2"]);
                    objSP.Anh3 = Convert.ToString(sqlDataReader["Anh3"]);
                    objSP.Anh4 = Convert.ToString(sqlDataReader["Anh4"]);
                    objSP.Anh5 = Convert.ToString(sqlDataReader["Anh5"]);
                    objSP.Anh6 = Convert.ToString(sqlDataReader["Anh6"]);
                    objSP.CategoryId = Convert.ToInt32(sqlDataReader["CategoryId"]);
                    objSP.LoaiSP = Convert.ToString(sqlDataReader["LoaiSP"]);
                    objSP.Series = Convert.ToString(sqlDataReader["Series"]);






                    lstSP.Add(objSP);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstSP;
            }
        }


        public static List<SanPham> getAllSanPhamPopByCategoryId(int _categoryId)
        {
            List<SanPham> lstSP = new List<SanPham>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaSanPham, TenSanPham, GiaTien, NhanVat, HangSanXuat, KichThuoc, PhatHanh, Anh1, Anh2, Anh3, Anh4, Anh5, Anh6, CategoryId, LoaiSP, Series FROM SanPham where CategoryId ='" + _categoryId + "' and LoaiSP ='pop' ";
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
                SanPham objSP = null;
                while (sqlDataReader.Read())
                {
                    objSP = new SanPham();


                    objSP.MaSanPham = Convert.ToInt32(sqlDataReader["MaSanPham"]);
                    objSP.TenSanPham = Convert.ToString(sqlDataReader["TenSanPham"]);
                    objSP.GiaTien = Convert.ToInt32(sqlDataReader["GiaTien"]);

                    objSP.NhanVat = Convert.ToString(sqlDataReader["NhanVat"]);
                    objSP.HangSanXuat = Convert.ToString(sqlDataReader["HangSanXuat"]);
                    objSP.KichThuoc = Convert.ToString(sqlDataReader["KichThuoc"]);
                    objSP.PhatHanh = Convert.ToDateTime(sqlDataReader["PhatHanh"]);
                    objSP.Anh1 = Convert.ToString(sqlDataReader["Anh1"]);
                    objSP.Anh2 = Convert.ToString(sqlDataReader["Anh2"]);
                    objSP.Anh3 = Convert.ToString(sqlDataReader["Anh3"]);
                    objSP.Anh4 = Convert.ToString(sqlDataReader["Anh4"]);
                    objSP.Anh5 = Convert.ToString(sqlDataReader["Anh5"]);
                    objSP.Anh6 = Convert.ToString(sqlDataReader["Anh6"]);
                    objSP.CategoryId = Convert.ToInt32(sqlDataReader["CategoryId"]);
                    objSP.LoaiSP = Convert.ToString(sqlDataReader["LoaiSP"]);
                    objSP.Series = Convert.ToString(sqlDataReader["Series"]);






                    lstSP.Add(objSP);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstSP;
            }
        }

        public static List<SanPham> getAllSanPhamByCategorySP(int _maLoaiSP)
        {
            List<SanPham> lstSP = new List<SanPham>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaSanPham, TenSanPham, GiaTien, NhanVat, HangSanXuat, KichThuoc, PhatHanh, Anh1, Anh2, Anh3, Anh4, Anh5, Anh6, CategoryId, LoaiSP, Series, MaLoaiSP FROM SanPham where MaLoaiSP = '" + _maLoaiSP + "' ";
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
                SanPham objSP = null;
                while (sqlDataReader.Read())
                {
                    objSP = new SanPham();


                    objSP.MaSanPham = Convert.ToInt32(sqlDataReader["MaSanPham"]);
                    objSP.TenSanPham = Convert.ToString(sqlDataReader["TenSanPham"]);
                    objSP.GiaTien = Convert.ToInt32(sqlDataReader["GiaTien"]);

                    objSP.NhanVat = Convert.ToString(sqlDataReader["NhanVat"]);
                    objSP.HangSanXuat = Convert.ToString(sqlDataReader["HangSanXuat"]);
                    objSP.KichThuoc = Convert.ToString(sqlDataReader["KichThuoc"]);
                    objSP.PhatHanh = Convert.ToDateTime(sqlDataReader["PhatHanh"]);
                    objSP.Anh1 = Convert.ToString(sqlDataReader["Anh1"]);
                    objSP.Anh2 = Convert.ToString(sqlDataReader["Anh2"]);
                    objSP.Anh3 = Convert.ToString(sqlDataReader["Anh3"]);
                    objSP.Anh4 = Convert.ToString(sqlDataReader["Anh4"]);
                    objSP.Anh5 = Convert.ToString(sqlDataReader["Anh5"]);
                    objSP.Anh6 = Convert.ToString(sqlDataReader["Anh6"]);
                    objSP.CategoryId = Convert.ToInt32(sqlDataReader["CategoryId"]);
                    objSP.LoaiSP = Convert.ToString(sqlDataReader["LoaiSP"]);
                    objSP.Series = Convert.ToString(sqlDataReader["Series"]);
                    objSP.MaLoaiSP = Convert.ToInt32(sqlDataReader["MaLoaiSP"]);







                    lstSP.Add(objSP);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstSP;
            }
        }

        public static SanPham getOneSanPham(int _maSanPham)
        {
            SanPham objSP = null;
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaSanPham, TenSanPham, GiaTien, NhanVat, HangSanXuat, KichThuoc, PhatHanh, Anh1, Anh2, Anh3, Anh4, Anh5, Anh6, CategoryId, LoaiSP, Series, MaLoaiSP FROM SanPham  where MaSanPham='" + _maSanPham + "' ";
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
                    objSP = new SanPham();


                    objSP.MaSanPham = Convert.ToInt32(sqlDataReader["MaSanPham"]);
                    objSP.TenSanPham = Convert.ToString(sqlDataReader["TenSanPham"]);
                    objSP.GiaTien = Convert.ToInt32(sqlDataReader["GiaTien"]);

                    objSP.NhanVat = Convert.ToString(sqlDataReader["NhanVat"]);
                    objSP.HangSanXuat = Convert.ToString(sqlDataReader["HangSanXuat"]);
                    objSP.KichThuoc = Convert.ToString(sqlDataReader["KichThuoc"]);
                    objSP.PhatHanh = Convert.ToDateTime(sqlDataReader["PhatHanh"]);
                    objSP.Anh1 = Convert.ToString(sqlDataReader["Anh1"]);
                    objSP.Anh2 = Convert.ToString(sqlDataReader["Anh2"]);
                    objSP.Anh3 = Convert.ToString(sqlDataReader["Anh3"]);
                    objSP.Anh4 = Convert.ToString(sqlDataReader["Anh4"]);
                    objSP.Anh5 = Convert.ToString(sqlDataReader["Anh5"]);
                    objSP.Anh6 = Convert.ToString(sqlDataReader["Anh6"]);
                    objSP.CategoryId = Convert.ToInt32(sqlDataReader["CategoryId"]);
                    objSP.LoaiSP = Convert.ToString(sqlDataReader["LoaiSP"]);
                    objSP.Series = Convert.ToString(sqlDataReader["Series"]);
                    objSP.MaLoaiSP = Convert.ToInt32(sqlDataReader["MaLoaiSP"]);

                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return objSP;
            }
        }

        public static List<SanPham> getAllSanPhamNew()
        {
            List<SanPham> lstSP = new List<SanPham>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaSanPham, TenSanPham, GiaTien, NhanVat, HangSanXuat, KichThuoc, PhatHanh, Anh1, Anh2, Anh3, Anh4, Anh5, Anh6, CategoryId, LoaiSP, Series, MaLoaiSP FROM SanPham where YEAR(PhatHanh)  >=2022 ";
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
                SanPham objSP = null;
                while (sqlDataReader.Read())
                {
                    objSP = new SanPham();


                    objSP.MaSanPham = Convert.ToInt32(sqlDataReader["MaSanPham"]);
                    objSP.TenSanPham = Convert.ToString(sqlDataReader["TenSanPham"]);
                    objSP.GiaTien = Convert.ToInt32(sqlDataReader["GiaTien"]);

                    objSP.NhanVat = Convert.ToString(sqlDataReader["NhanVat"]);
                    objSP.HangSanXuat = Convert.ToString(sqlDataReader["HangSanXuat"]);
                    objSP.KichThuoc = Convert.ToString(sqlDataReader["KichThuoc"]);
                    objSP.PhatHanh = Convert.ToDateTime(sqlDataReader["PhatHanh"]);
                    objSP.Anh1 = Convert.ToString(sqlDataReader["Anh1"]);
                    objSP.Anh2 = Convert.ToString(sqlDataReader["Anh2"]);
                    objSP.Anh3 = Convert.ToString(sqlDataReader["Anh3"]);
                    objSP.Anh4 = Convert.ToString(sqlDataReader["Anh4"]);
                    objSP.Anh5 = Convert.ToString(sqlDataReader["Anh5"]);
                    objSP.Anh6 = Convert.ToString(sqlDataReader["Anh6"]);
                    objSP.CategoryId = Convert.ToInt32(sqlDataReader["CategoryId"]);
                    objSP.LoaiSP = Convert.ToString(sqlDataReader["LoaiSP"]);
                    objSP.Series = Convert.ToString(sqlDataReader["Series"]);
                    objSP.MaLoaiSP = Convert.ToInt32(sqlDataReader["MaLoaiSP"]);


                    lstSP.Add(objSP);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstSP;
            }
        }
    }
}