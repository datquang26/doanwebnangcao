using doanwebnangcao.entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace doanwebnangcao
{
    public partial class pop_up_parade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<BannerPop> lstBA = dao.DaoBannerPop.getAllBannerPop();
            gvBA.DataSource = lstBA;
            gvBA.DataBind();

            if (!Page.IsPostBack)
            {
                List<SanPham> lstSP = dao.DaoSanPham.getAllSanPhamPop();
                gvSP.DataSource = lstSP;
                gvSP.DataBind();

                //bind drop
                //Lấy thông tin chuỗi kết nối từ Web.config
                string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
                //Viết câu lệnh truy vấn
                string strSQL = "SELECT CategoryId,CategoryName  FROM Category ";
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
                        DropDownList1.Items.Add(new ListItem(sqlDataReader["CategoryName"].ToString(), sqlDataReader["CategoryId"].ToString()));
                    }
                    sqlDataReader.Close();//Đóng đối tượng DataReader
                    sqlConnection.Close();//Đóng kết nối
                    sqlConnection.Dispose();//Giải phóng bộ nhớ

                }



            }
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<SanPham> lstCA = dao.DaoSanPham.getAllSanPhamPopByCategoryId(Convert.ToInt32(DropDownList1.SelectedValue));
            gvSP.DataSource = lstCA;
            gvSP.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<SanPham> lstSP = dao.DaoSanPham.getAllTenSanPhamPop(TextBox1.Text);
            gvSP.DataSource = lstSP;
            gvSP.DataBind();
        }
    }
}