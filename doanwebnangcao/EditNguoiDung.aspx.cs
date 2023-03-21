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
    public partial class EditNguoiDung : System.Web.UI.Page
    {
        int queryID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            queryID = Convert.ToInt32(Page.Request.QueryString["tbID"]);
            if (!Page.IsPostBack)
            {

                if (queryID > 0)
                {
                    NguoiDung nguoiDung = dao.DaoNguoiDung.getOneNguoiDung(queryID);

                    tbID.Enabled = false;
                    tbID.Text = queryID.ToString();

                    tbEmail.Enabled = false;
                    tbEmail.Text = nguoiDung.Email;
                    tbMatKhau.Enabled = false;
                    tbMatKhau.Text = nguoiDung.MatKhau;


                    tbFullName.Text = nguoiDung.FullName;




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
                    SqlCommand cmd = new SqlCommand(" update NguoiDung set  Email = @email, MatKhau = @matKhau, FullName = @fullName  where ID = @iD  ", conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@iD", tbID.Text);
                    cmd.Parameters.AddWithValue("@email", tbEmail.Text);
                    cmd.Parameters.AddWithValue("@matKhau", tbMatKhau.Text);
                    cmd.Parameters.AddWithValue("@fullName", tbFullName.Text);







                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Response.Redirect("GridviewNguoiDung.aspx");
                }
            }
        }

        bool validate()
        {
            bool result = false;


            if (tbID.Text == "" || tbEmail.Text == "" || tbMatKhau.Text == "" || tbFullName.Text == "")
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