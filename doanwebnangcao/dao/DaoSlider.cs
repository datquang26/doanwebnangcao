using doanwebnangcao.entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace doanwebnangcao.dao
{
    public class DaoSlider
    {
        public static List<Slider> getAllSlider()
        {
            List<Slider> lstSL = new List<Slider>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaSliderAnh, Anh1, Anh2, Anh3, Anh4 FROM Slider";
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
                Slider objSL = null;
                while (sqlDataReader.Read())
                {
                    objSL = new Slider();


                    objSL.MaSliderAnh = Convert.ToInt32(sqlDataReader["MaSliderAnh"]);
                    objSL.Anh1 = Convert.ToString(sqlDataReader["Anh1"]);
                    objSL.Anh2 = Convert.ToString(sqlDataReader["Anh2"]);
                    objSL.Anh3 = Convert.ToString(sqlDataReader["Anh3"]);
                    objSL.Anh4 = Convert.ToString(sqlDataReader["Anh4"]);

                    lstSL.Add(objSL);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstSL;
            }
        }

        public static Slider getOneSlider(int _maSliderAnh)
        {
            Slider objSL = null;
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaSliderAnh, Anh1, Anh2, Anh3, Anh4 FROM Slider where MaSliderAnh = '" + _maSliderAnh + "'";
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
                    objSL = new Slider();


                    objSL.MaSliderAnh = Convert.ToInt32(sqlDataReader["MaSliderAnh"]);
                    objSL.Anh1 = Convert.ToString(sqlDataReader["Anh1"]);
                    objSL.Anh2 = Convert.ToString(sqlDataReader["Anh2"]);
                    objSL.Anh3 = Convert.ToString(sqlDataReader["Anh3"]);
                    objSL.Anh4 = Convert.ToString(sqlDataReader["Anh4"]);

                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return objSL;
            }
        }
    }
}