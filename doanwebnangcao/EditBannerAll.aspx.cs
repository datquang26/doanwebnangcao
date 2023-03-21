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
    public partial class EditBannerAll : System.Web.UI.Page
    {
        int queryMaBanner = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            queryMaBanner = Convert.ToInt32(Page.Request.QueryString["tbMaBanner"]);
            if (!Page.IsPostBack)
            {

                if (queryMaBanner > 0)
                {
                    BannerPop bannerAll = dao.DaoBannerPop.getOneBannerAll(queryMaBanner);

                    tbMaBanner.Enabled = false;
                    tbMaBanner.Text = queryMaBanner.ToString();

                    tbTenBanner.Text = bannerAll.TenBanner;
                    tbMoTaBanner.Text = bannerAll.MoTaBanner;
                    DropDownList1.Text = bannerAll.LoaiBanner;


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
                    SqlCommand cmd = new SqlCommand(" update BannerPop set TenBanner = @tenBanner, AnhBanner = @anhBanner, MoTaBanner = @moTaBanner , LoaiBanner = @loaiBanner where MaBanner = @maBanner  ", conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@maBanner", tbMaBanner.Text);

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


            if (tbMoTaBanner.Text == "" || tbTenBanner.Text == "" || FileUpload1.FileName == "" || tbMoTaBanner.Text == "" || DropDownList1.Text == "")
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