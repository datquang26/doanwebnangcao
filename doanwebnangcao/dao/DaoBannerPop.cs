using doanwebnangcao.entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace doanwebnangcao.dao
{
    public class DaoBannerPop
    {
        public static List<BannerPop> getAllBanner()
        {
            List<BannerPop> lstBA = new List<BannerPop>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaBanner, TenBanner, AnhBanner, MoTaBanner, LoaiBanner FROM BannerPop";
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
                BannerPop objBA = null;
                while (sqlDataReader.Read())
                {
                    objBA = new BannerPop();


                    objBA.MaBanner = Convert.ToInt32(sqlDataReader["MaBanner"]);
                    objBA.TenBanner = Convert.ToString(sqlDataReader["TenBanner"]);
                    objBA.AnhBanner = Convert.ToString(sqlDataReader["AnhBanner"]);
                    objBA.MoTaBanner = Convert.ToString(sqlDataReader["MoTaBanner"]);
                    objBA.LoaiBanner = Convert.ToString(sqlDataReader["LoaiBanner"]);

                    lstBA.Add(objBA);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstBA;
            }
        }


        public static List<BannerPop> getAllBannerFigma()
        {
            List<BannerPop> lstBA = new List<BannerPop>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaBanner, TenBanner, AnhBanner, MoTaBanner, LoaiBanner FROM BannerPop where LoaiBanner ='Figma'";
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
                BannerPop objBA = null;
                while (sqlDataReader.Read())
                {
                    objBA = new BannerPop();


                    objBA.MaBanner = Convert.ToInt32(sqlDataReader["MaBanner"]);
                    objBA.TenBanner = Convert.ToString(sqlDataReader["TenBanner"]);
                    objBA.AnhBanner = Convert.ToString(sqlDataReader["AnhBanner"]);
                    objBA.MoTaBanner = Convert.ToString(sqlDataReader["MoTaBanner"]);
                    objBA.LoaiBanner = Convert.ToString(sqlDataReader["LoaiBanner"]);


                    lstBA.Add(objBA);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstBA;
            }
        }

        public static List<BannerPop> getAllBannerPop()
        {
            List<BannerPop> lstBA = new List<BannerPop>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaBanner, TenBanner, AnhBanner, MoTaBanner, LoaiBanner FROM BannerPop where LoaiBanner ='Pop'";
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
                BannerPop objBA = null;
                while (sqlDataReader.Read())
                {
                    objBA = new BannerPop();


                    objBA.MaBanner = Convert.ToInt32(sqlDataReader["MaBanner"]);
                    objBA.TenBanner = Convert.ToString(sqlDataReader["TenBanner"]);
                    objBA.AnhBanner = Convert.ToString(sqlDataReader["AnhBanner"]);
                    objBA.MoTaBanner = Convert.ToString(sqlDataReader["MoTaBanner"]);
                    objBA.LoaiBanner = Convert.ToString(sqlDataReader["LoaiBanner"]);








                    lstBA.Add(objBA);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstBA;
            }
        }


        public static List<BannerPop> getAllBannerHomePage()
        {
            List<BannerPop> lstBA = new List<BannerPop>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaBanner, TenBanner, AnhBanner, MoTaBanner, LoaiBanner FROM BannerPop where LoaiBanner ='HomePage'";
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
                BannerPop objBA = null;
                while (sqlDataReader.Read())
                {
                    objBA = new BannerPop();


                    objBA.MaBanner = Convert.ToInt32(sqlDataReader["MaBanner"]);
                    objBA.TenBanner = Convert.ToString(sqlDataReader["TenBanner"]);
                    objBA.AnhBanner = Convert.ToString(sqlDataReader["AnhBanner"]);
                    objBA.MoTaBanner = Convert.ToString(sqlDataReader["MoTaBanner"]);
                    objBA.LoaiBanner = Convert.ToString(sqlDataReader["LoaiBanner"]);

                    lstBA.Add(objBA);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstBA;
            }
        }


        public static BannerPop getOneBannerAll(int _maBanner)
        {
            BannerPop objBA = null;
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaBanner, TenBanner, AnhBanner, MoTaBanner, LoaiBanner FROM BannerPop where MaBanner = '" + _maBanner + "' ";
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
                    objBA = new BannerPop();

                    objBA.MaBanner = Convert.ToInt32(sqlDataReader["MaBanner"]);
                    objBA.TenBanner = Convert.ToString(sqlDataReader["TenBanner"]);
                    objBA.AnhBanner = Convert.ToString(sqlDataReader["AnhBanner"]);
                    objBA.MoTaBanner = Convert.ToString(sqlDataReader["MoTaBanner"]);
                    objBA.LoaiBanner = Convert.ToString(sqlDataReader["LoaiBanner"]);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return objBA;
            }
        }
    }
}