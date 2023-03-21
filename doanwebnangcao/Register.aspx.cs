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
    public partial class Register : System.Web.UI.Page
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
                    SqlCommand cmd = new SqlCommand("insert into NguoiDung(FullName, Email, MatKhau) values (@fullName,@email, @matKhau)", conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@email", tbEmail.Text);
                    cmd.Parameters.AddWithValue("@matKhau", tbMatKhau.Text);
                    cmd.Parameters.AddWithValue("@fullName", tbFullName.Text);


                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Response.Redirect("login.aspx");
                }
            }
        }
        bool validate()
        {
            bool result = false;

            if (tbMatKhau.Text == "" && tbEmail.Text == "" && tbFullName.Text == "")
            {
                result = false;
                Label1.Text = "* Vui lòng nhập tên  ! *";
                Label2.Text = "* Vui lòng nhập Email ! *";
                Label3.Text = "* Vui lòng nhập mật khẩu ! *";

            }
            else if (tbEmail.Text == "" && tbFullName.Text == "")
            {
                result = false;
                Label1.Text = "* Vui lòng nhập tên ! *";
                Label2.Text = "* Vui lòng nhập Email ! *";
                Label3.Text = "";


            }
            else if (tbMatKhau.Text == "" && tbEmail.Text == "")
            {
                result = false;
                Label1.Text = "";
                Label2.Text = "* Vui lòng nhập Email ! *";
                Label3.Text = "* Vui lòng nhập mật khẩu ! *";

            }
            else if (tbMatKhau.Text == "" && tbFullName.Text == "")
            {
                result = false;
                Label1.Text = "* Vui lòng nhập tên  ! *";
                Label2.Text = "";
                Label3.Text = "* Vui lòng nhập mật khẩu ! *";
            }
            else if (tbEmail.Text == "")
            {
                result = false;
                Label1.Text = "";
                Label2.Text = "* Vui lòng nhập Email ! *";
                Label3.Text = "";

            }
            else if (tbMatKhau.Text == "")
            {
                result = false;
                Label1.Text = "";
                Label2.Text = "";
                Label3.Text = "* Vui lòng nhập mật khẩu ! *";
            }
            else if (tbFullName.Text == "")
            {
                result = false;
                Label1.Text = "* Vui lòng nhập tên  ! *";
                Label2.Text = "";
                Label3.Text = "";
            }

            else
            {
                Label1.Text = Label2.Text = Label3.Text = "";
                result = true;
            }
            return result;
        }
    }
}
