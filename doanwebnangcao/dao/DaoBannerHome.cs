using doanwebnangcao.entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace doanwebnangcao.dao
{
    public class DaoBannerHome
    {
        public static List<BannerHome> getAllBannerHome()
        {
            List<BannerHome> lstBH = new List<BannerHome>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaBannerHome, Anh1,Anh2 FROM BannerHome";
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
                BannerHome objBH = null;
                while (sqlDataReader.Read())
                {
                    objBH = new BannerHome();


                    objBH.MaBannerHome = Convert.ToInt32(sqlDataReader["MaBannerHome"]);
                    objBH.Anh1 = Convert.ToString(sqlDataReader["Anh1"]);
                    objBH.Anh2 = Convert.ToString(sqlDataReader["Anh2"]);

                    lstBH.Add(objBH);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstBH;
            }
        }

        public static BannerHome getOneBannerHome(int _maBannerHome)
        {
            BannerHome objBH = null;
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaBannerHome, Anh1, Anh2 FROM BannerHome where MaBannerHome = '" + _maBannerHome + "'";
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
                    objBH = new BannerHome();


                    objBH.MaBannerHome = Convert.ToInt32(sqlDataReader["MaBannerHome"]);
                    objBH.Anh1 = Convert.ToString(sqlDataReader["Anh1"]);
                    objBH.Anh2 = Convert.ToString(sqlDataReader["Anh2"]);





                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return objBH;
            }
        }
    }
}