using doanwebnangcao.entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace doanwebnangcao.dao
{
    public class DaoGioiThieu
    {
        public static List<GioiThieu> getAllGioiThieu()
        {
            List<GioiThieu> lstGT = new List<GioiThieu>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaGioiThieu, IntroBannerImg, IntroVideo, TextIntroVideo, AnhGT1, JapanFigureImg, JapanFigureImg2, JapanFigureImg3, JapanFigureText FROM GioiThieu";
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
                GioiThieu objGT = null;
                while (sqlDataReader.Read())
                {
                    objGT = new GioiThieu();


                    objGT.MaGioiThieu = Convert.ToInt32(sqlDataReader["MaGioiThieu"]);
                    objGT.IntroBannerImg = Convert.ToString(sqlDataReader["IntroBannerImg"]);
                    objGT.IntroVideo = Convert.ToString(sqlDataReader["IntroVideo"]);
                    objGT.TextIntroVideo = Convert.ToString(sqlDataReader["TextIntroVideo"]);
                    objGT.AnhGT1 = Convert.ToString(sqlDataReader["AnhGT1"]);
                    objGT.JapanFigureImg = Convert.ToString(sqlDataReader["JapanFigureImg"]);
                    objGT.JapanFigureImg2 = Convert.ToString(sqlDataReader["JapanFigureImg2"]);
                    objGT.JapanFigureImg3 = Convert.ToString(sqlDataReader["JapanFigureImg3"]);
                    objGT.JapanFigureText = Convert.ToString(sqlDataReader["JapanFigureText"]);








                    lstGT.Add(objGT);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstGT;
            }
        }

        public static GioiThieu getOneGioiThieu(int _maGioiThieu)
        {
            GioiThieu objGT = null;
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaGioiThieu, IntroBannerImg, IntroVideo, TextIntroVideo, AnhGT1, JapanFigureImg, JapanFigureImg2, JapanFigureImg3, JapanFigureText FROM GioiThieu where MaGioiThieu = '" + _maGioiThieu + "' ";
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
                    objGT = new GioiThieu();

                    objGT.MaGioiThieu = Convert.ToInt32(sqlDataReader["MaGioiThieu"]);
                    objGT.IntroBannerImg = Convert.ToString(sqlDataReader["IntroBannerImg"]);
                    objGT.IntroVideo = Convert.ToString(sqlDataReader["IntroVideo"]);
                    objGT.TextIntroVideo = Convert.ToString(sqlDataReader["TextIntroVideo"]);
                    objGT.AnhGT1 = Convert.ToString(sqlDataReader["AnhGT1"]);
                    objGT.JapanFigureImg = Convert.ToString(sqlDataReader["JapanFigureImg"]);
                    objGT.JapanFigureImg2 = Convert.ToString(sqlDataReader["JapanFigureImg2"]);
                    objGT.JapanFigureImg3 = Convert.ToString(sqlDataReader["JapanFigureImg3"]);
                    objGT.JapanFigureText = Convert.ToString(sqlDataReader["JapanFigureText"]);

                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return objGT;
            }
        }
    }
}