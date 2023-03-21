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
    public partial class homepage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Slider> lstSL = dao.DaoSlider.getAllSlider();
            gvSL.DataSource = lstSL;
            gvSL.DataBind();

            List<BannerHome> lstBH = dao.DaoBannerHome.getAllBannerHome();
            gvBH.DataSource = lstBH;
            gvBH.DataBind();

            List<BannerPop> lstBA = dao.DaoBannerPop.getAllBannerHomePage();
            gvBA.DataSource = lstBA;
            gvBA.DataBind();

            List<SanPham> lstSP2 = dao.DaoSanPham.getAllSanPhamNew();
            gvSP2.DataSource = lstSP2;
            gvSP2.DataBind();

            List<BannerHome> lstBH2 = dao.DaoBannerHome.getAllBannerHome();
            gvBH2.DataSource = lstBH2;
            gvBH2.DataBind();

            if (!Page.IsPostBack)
            {


                List<SanPham> lstSP = dao.DaoSanPham.getAllSanPhamPop();
                gvSP.DataSource = lstSP;
                gvSP.DataBind();

                //bind drop
                //Lấy thông tin chuỗi kết nối từ Web.config
                string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
                //Viết câu lệnh truy vấn
                string strSQL = "SELECT MaLoaiSP, TenLoaiSP  FROM CategorySP ";
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
                        DropDownList1.Items.Add(new ListItem(sqlDataReader["TenLoaiSP"].ToString(), sqlDataReader["MaLoaiSP"].ToString()));
                    }
                    sqlDataReader.Close();//Đóng đối tượng DataReader
                    sqlConnection.Close();//Đóng kết nối
                    sqlConnection.Dispose();//Giải phóng bộ nhớ

                }
            }
        }

       
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<SanPham> lstCASP = dao.DaoSanPham.getAllSanPhamByCategorySP(Convert.ToInt32(DropDownList1.SelectedValue));
            gvSP.DataSource = lstCASP;
            gvSP.DataBind();
        }
    }
}