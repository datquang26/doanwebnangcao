using doanwebnangcao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace doanwebnangcao
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                NguoiDung nguoiDung = dao.DaoNguoiDung.GetOneNguoiDungLogin(tbEmail.Text, tbMatKhau.Text);
                if (nguoiDung == null)
                {

                    Label3.Text = "* Email hoặc mật khẩu chưa đúng vui lòng nhập lại ! *";
                }
                else
                {
                    Page.Session["FullName"] = nguoiDung.FullName;
                    Page.Session["ID"] = nguoiDung.ID;

                    Response.Redirect("homepage.aspx");

                }
            }
        }

        bool validate()
        {
            bool result = false;

            if (tbMatKhau.Text == "" && tbEmail.Text == "")
            {
                result = false;
                Label1.Text = "* Vui lòng nhập Email ! *";
                Label2.Text = "* Vui lòng nhập mật khẩu ! *";
            }
            else if (tbEmail.Text == "")
            {
                result = false;
                Label1.Text = "* Vui lòng nhập Email ! *";
                Label2.Text = "";

            }
            else if (tbMatKhau.Text == "")
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