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
    public partial class lien_he : System.Web.UI.Page
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
                    SqlCommand cmd = new SqlCommand("insert into LienHe( FullName, Email, SoDienThoai , NoiDung) values(@fullName,@email,@soDienThoai,@noiDung) ", conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@fullName", tbFullName.Text);

                    cmd.Parameters.AddWithValue("@email", tbEmail.Text);

                    cmd.Parameters.AddWithValue("@soDienThoai", tbSoDienThoai.Text);
                    cmd.Parameters.AddWithValue("@noiDung", tbNoiDung.Text);






                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("<script> alert('Liên hệ thành công!!!')</script>");
                }
            }
        }
        bool validate()
        {
            bool result = false;


            if (tbFullName.Text == "" || tbEmail.Text == "" || tbSoDienThoai.Text == "" || tbNoiDung.Text == "")
            {
                result = false;
                Label1.Text = "* Vui lòng nhập thêm thông tin liên hệ *";

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