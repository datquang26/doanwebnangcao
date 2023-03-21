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
    public partial class EditSanPham : System.Web.UI.Page
    {
        int queryMaSanPham = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            queryMaSanPham = Convert.ToInt32(Page.Request.QueryString["tbMaSanPham"]);
            if (!Page.IsPostBack)
            {

                if (queryMaSanPham > 0)
                {
                    SanPham sanPham = dao.DaoSanPham.getOneSanPham(queryMaSanPham);
                    tbMaSanPham.Enabled = false;

                    tbMaSanPham.Text = queryMaSanPham.ToString();

                    tbTenSanPham.Text = sanPham.TenSanPham;
                    tbGiaTien.Text = Convert.ToString(sanPham.GiaTien);
                    tbNhanVat.Text = sanPham.NhanVat;

                    DropDownList1.Text = sanPham.HangSanXuat;
                    tbKichThuoc.Text = sanPham.KichThuoc;
                    tbPhatHanh.Text = Convert.ToDateTime(sanPham.PhatHanh).ToString();


                    DropDownList2.Text = Convert.ToString(sanPham.CategoryId);
                    DropDownList3.Text = sanPham.LoaiSP;
                    DropDownList5.Text = Convert.ToString(sanPham.MaLoaiSP);
                    DropDownList4.Text = sanPham.Series;


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
                    SqlCommand cmd = new SqlCommand("update SanPham set TenSanPham = @tenSanPham, GiaTien = @giaTien, NhanVat = @nhanVat, HangSanXuat = @hangSanXuat, KichThuoc = @kichThuoc, PhatHanh = @phatHanh, Anh1 = @anh1, Anh2 = @anh2, Anh3 =@anh3, Anh4 =@anh4, Anh5 =@anh5, Anh6 =@anh6, CategoryId =@categoryId, LoaiSP = @loaiSP, Series = @series, MaLoaiSP =@maLoaiSP  where MaSanPham = @maSanPham ", conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@maSanPham", tbMaSanPham.Text);

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


            if (tbMaSanPham.Text == "" || tbTenSanPham.Text == "" || tbGiaTien.Text == "" || tbNhanVat.Text == "" || DropDownList1.Text == "" || tbKichThuoc.Text == "" || tbPhatHanh.Text == "" || FileUpload1.FileName == "" || FileUpload2.FileName == "" || FileUpload3.FileName == "" || FileUpload4.FileName == "" || FileUpload5.FileName == "" || FileUpload6.FileName == "" || DropDownList2.Text == " " || DropDownList3.Text == " " || DropDownList4.Text == " " || DropDownList5.Text == " ")
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