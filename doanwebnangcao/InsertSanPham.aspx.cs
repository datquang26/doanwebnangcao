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
    public partial class InsertSanPham : System.Web.UI.Page
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
                    SqlCommand cmd = new SqlCommand("insert into SanPham(TenSanPham,GiaTien,NhanVat,HangSanXuat,KichThuoc,PhatHanh,Anh1,Anh2,Anh3,Anh4,Anh5,Anh6,CategoryId,LoaiSP,Series,MaLoaiSP ) values(@tenSanPham,@giaTien,@nhanVat,@hangSanXuat,@kichThuoc,@phatHanh,@anh1,@anh2,@anh3,@anh4,@anh5,@anh6,@categoryId,@loaiSP,@series,@maLoaiSP)", conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@tenSanPham", tbTenSanPham.Text);
                    cmd.Parameters.AddWithValue("@giaTien", tbGiaTien.Text);
                    cmd.Parameters.AddWithValue("@nhanVat", tbNhanVat.Text);
                    cmd.Parameters.AddWithValue("@hangSanXuat", DropDownList1.Text);
                    cmd.Parameters.AddWithValue("@kichThuoc", tbKichThuoc.Text);
                    cmd.Parameters.AddWithValue("@phatHanh", tbPhatHanh.Text);
                    cmd.Parameters.AddWithValue("@anh1", FileUpload1.FileName);
                    cmd.Parameters.AddWithValue("@anh2", FileUpload2.FileName);
                    cmd.Parameters.AddWithValue("@anh3", FileUpload3.FileName);
                    cmd.Parameters.AddWithValue("@anh4", FileUpload4.FileName);
                    cmd.Parameters.AddWithValue("@anh5", FileUpload5.FileName);
                    cmd.Parameters.AddWithValue("@anh6", FileUpload6.FileName);

                    cmd.Parameters.AddWithValue("@categoryId", DropDownList2.Text);
                    cmd.Parameters.AddWithValue("@loaiSP", DropDownList3.Text);
                    cmd.Parameters.AddWithValue("@series", DropDownList4.Text);
                    cmd.Parameters.AddWithValue("@maLoaiSP", DropDownList5.Text);


                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Response.Redirect("GridviewSanPham.aspx");
                }
            }
        }

        bool validate()
        {
            bool result = false;


            if (tbTenSanPham.Text == "" || tbGiaTien.Text == "" || tbNhanVat.Text == "" || DropDownList1.Text == "" || tbKichThuoc.Text == "" || tbPhatHanh.Text == "" || FileUpload1.FileName == "" || FileUpload2.FileName == "" || FileUpload3.FileName == "" || FileUpload4.FileName == "" || FileUpload5.FileName == "" || FileUpload6.FileName == "" || DropDownList2.Text == " " || DropDownList3.Text == " " || DropDownList4.Text == " " || DropDownList5.Text == " ")
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