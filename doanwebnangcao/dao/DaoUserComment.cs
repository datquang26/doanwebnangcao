using doanwebnangcao.entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace doanwebnangcao.dao
{
    public class DaoUserComment
    {

        public static List<UserComment> getAllUserComment()
        {
            List<UserComment> lstUC = new List<UserComment>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaComment, ID, TextComment, MaSanPham, Anh1 FROM UserComment";
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
                UserComment objUC = null;
                while (sqlDataReader.Read())
                {
                    objUC = new UserComment();


                    objUC.MaComment = Convert.ToInt32(sqlDataReader["MaComment"]);
                    objUC.ID = Convert.ToInt32(sqlDataReader["ID"]);
                    objUC.TextComment = Convert.ToString(sqlDataReader["TextComment"]);
                    objUC.MaSanPham = Convert.ToInt32(sqlDataReader["MaSanPham"]);
                    objUC.Anh1 = Convert.ToString(sqlDataReader["Anh1"]);

                    lstUC.Add(objUC);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstUC;
            }
        }


        public static List<UserComment> getAllUserCommentByMaSanPham(int _maSanPham)
        {
            List<UserComment> lstUC = new List<UserComment>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaComment, ID, FullName, TextComment, MaSanPham, Anh1 FROM UserComment where MaSanPham='" + _maSanPham + "'";
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
                UserComment objUC = null;
                while (sqlDataReader.Read())
                {
                    objUC = new UserComment();


                    objUC.MaComment = Convert.ToInt32(sqlDataReader["MaComment"]);
                    objUC.ID = Convert.ToInt32(sqlDataReader["ID"]);

                    objUC.FullName = Convert.ToString(sqlDataReader["FullName"]);
                    objUC.TextComment = Convert.ToString(sqlDataReader["TextComment"]);

                    objUC.MaSanPham = Convert.ToInt32(sqlDataReader["MaSanPham"]);
                    objUC.Anh1 = Convert.ToString(sqlDataReader["Anh1"]);



                    lstUC.Add(objUC);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstUC;
            }
        }
    }
}