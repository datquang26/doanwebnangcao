using doanwebnangcao.entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace doanwebnangcao.dao
{
    public class DaoLienHe
    {
        public static List<LienHe> getAllLienHe()
        {
            List<LienHe> lstLH = new List<LienHe>();
            //Lấy thông tin chuỗi kết nối từ Web.config
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
            //Viết câu lệnh truy vấn
            string strSQL = "SELECT MaLienHe, FullName, Email, SoDienThoai, NoiDung FROM LienHe";
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
                LienHe objLH = null;
                while (sqlDataReader.Read())
                {
                    objLH = new LienHe();


                    objLH.MaLienHe = Convert.ToInt32(sqlDataReader["MaLienHe"]);
                    objLH.Email = Convert.ToString(sqlDataReader["Email"]);
                    objLH.SoDienThoai = Convert.ToString(sqlDataReader["SoDienThoai"]);
                    objLH.FullName = Convert.ToString(sqlDataReader["FullName"]);
                    objLH.NoiDung = Convert.ToString(sqlDataReader["NoiDung"]);
                    


                    lstLH.Add(objLH);
                }
                sqlDataReader.Close();//Đóng đối tượng DataReader
                sqlConnection.Close();//Đóng kết nối
                sqlConnection.Dispose();//Giải phóng bộ nhớ
                return lstLH;
            }
        }
    }
}