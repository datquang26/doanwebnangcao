using doanwebnangcao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace doanwebnangcao
{
    public partial class loginAD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                Admin admin = dao.DaoAdmin.GetOneAdminLogin(tbTaiKhoanAD.Text, tbMatKhauAD.Text);
                if (admin == null)
                {

                    Label3.Text = "* Tài khoản hoặc mật khẩu chưa đúng vui lòng nhập lại ! *";
                }
                else
                {
                    Page.Session["TenAD"] = admin.TenAD;
                    Page.Session["MaAD"] = admin.MaAD;

                    Response.Redirect("GridviewBannerAll.aspx");

                }
            }
        }

        bool validate()
        {
            bool result = false;

            if (tbTaiKhoanAD.Text == "" && tbMatKhauAD.Text == "")
            {
                result = false;
                Label1.Text = "* Vui lòng nhập tài khoản ! *";
                Label2.Text = "* Vui lòng nhập mật khẩu ! *";
            }
            else if (tbTaiKhoanAD.Text == "")
            {
                result = false;
                Label1.Text = "* Vui lòng nhập tài khoản ! *";
                Label2.Text = "";

            }
            else if (tbMatKhauAD.Text == "")
            {
                result = false;
                Label2.Text = "* Vui lòng nhập mật khẩu ! *";
                Label1.Text = "";
            }

            else
            {
                Label1.Text = Label2.Text = "";
                result = true;
            }
            return result;
        }
    }
}