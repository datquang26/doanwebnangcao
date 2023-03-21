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
    public partial class InsertBannerAll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(strConnection))
                {
                    SqlCommand cmd = new SqlCommand("insert into BannerPop(TenBanner,AnhBanner, MoTaBanner, LoaiBanner ) values(@tenBanner,@anhBanner,@moTaBanner, @loaiBanner)", conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@tenBanner", tbTenBanner.Text);
                    cmd.Parameters.AddWithValue("@anhBanner", FileUpload1.FileName);
                    cmd.Parameters.AddWithValue("@moTaBanner", tbMoTaBanner.Text);

                    cmd.Parameters.AddWithValue("@loaiBanner", DropDownList1.Text);



                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Response.Redirect("GridviewBannerAll.aspx");
                }
            }
        }

        bool validate()
        {
            bool result = false;


            if (tbTenBanner.Text == "" || FileUpload1.FileName == "" || tbMoTaBanner.Text == "" || DropDownList1.Text == "")
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