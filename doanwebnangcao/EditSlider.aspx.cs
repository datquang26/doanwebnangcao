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
    public partial class EditSlider : System.Web.UI.Page
    {
        int queryMaSliderAnh = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            queryMaSliderAnh = Convert.ToInt32(Page.Request.QueryString["tbMaSliderAnh"]);
            if (!Page.IsPostBack)
            {

                if (queryMaSliderAnh > 0)
                {
                    Slider slider = dao.DaoSlider.getOneSlider(queryMaSliderAnh);

                    tbMaSliderAnh.Enabled = false;
                    tbMaSliderAnh.Text = queryMaSliderAnh.ToString();




                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(strConnection))
                {
                    SqlCommand cmd = new SqlCommand(" update Slider set  Anh1 = @anh1, Anh2 = @anh2, Anh3 = @anh3, Anh4 = @anh4  where MaSliderAnh = @maSliderAnh  ", conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@maSliderAnh", tbMaSliderAnh.Text);


                    cmd.Parameters.AddWithValue("@anh1", FileUpload1.FileName);
                    cmd.Parameters.AddWithValue("@anh2", FileUpload2.FileName);
                    cmd.Parameters.AddWithValue("@anh3", FileUpload3.FileName);
                    cmd.Parameters.AddWithValue("@anh4", FileUpload4.FileName);




                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Response.Redirect("GridviewSlider.aspx");
                }
            }
        }

        bool validate()
        {
            bool result = false;


            if (tbMaSliderAnh.Text == "" || FileUpload1.FileName == "")
            {
                result = false;
                Label1.Text = "* Vui lòng nhập thêm thông tin sản phẩm *";

            }
            else
            {
                Label1.Text = "";
                result = true;
            }
            return result;
        }
    }
}