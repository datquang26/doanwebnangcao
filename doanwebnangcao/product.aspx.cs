using doanwebnangcao.dao;
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
    public partial class product : System.Web.UI.Page
    {
        int productID = 0;


        protected void Page_Load(object sender, EventArgs e)
        {
            productID = Convert.ToInt32(Page.Request.QueryString["productID"]);


            if (!Page.IsPostBack)
            {

            }

            if (productID > 0)
            {


                List<SanPham> lstSP = dao.DaoSanPham.getAllSanPhamByMaSanPham(productID);
                gvSP.DataSource = lstSP;
                gvSP.DataBind();
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (validate2())
            {

                if (Session["ID"] == null)
                {
                    Response.Redirect("login.aspx");
                }

                else
                {
                    productID = Convert.ToInt32(Page.Request.QueryString["productID"]);
                    GioHang data = DaoGioHang.getOneGioHang((int)Session["ID"], productID);
                    if (data == null)
                    {
                        int productID1 = Convert.ToInt32(Page.Request.QueryString["productID"]);
                        string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
                        using (SqlConnection conn = new SqlConnection(strConnection))
                        {
                            SqlCommand cmd = new SqlCommand("insert into GioHang(MaSanPham,ID, SoLuong) values(@maSanPham,@iD,@soLuong)", conn);
                            conn.Open();

                            cmd.Parameters.AddWithValue("@maSanPham", productID1);
                            cmd.Parameters.AddWithValue("@iD", Session["ID"]);
                            cmd.Parameters.AddWithValue("@soLuong", TextBox2.Text);

                            cmd.ExecuteNonQuery();
                            conn.Close();
                            Response.Redirect("cart.aspx");
                        }
                    }
                    else
                    {
                        int productID1 = Convert.ToInt32(Page.Request.QueryString["productID"]);
                        string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
                        using (SqlConnection conn = new SqlConnection(strConnection))
                        {
                            SqlCommand cmd = new SqlCommand("update GioHang set SoLuong = SoLuong + @soLuong where  MaSanPham = @maSanPham and ID =@iD   ", conn);
                            conn.Open();


                            cmd.Parameters.AddWithValue("@maSanPham", productID1);
                            cmd.Parameters.AddWithValue("@iD", Session["ID"]);

                            cmd.Parameters.AddWithValue("@soLuong", TextBox2.Text);

                            cmd.ExecuteNonQuery();
                            conn.Close();
                            Response.Redirect("cart.aspx");
                        }
                    }




                }





            }
        }

        bool validate2()
        {
            bool result = false;

            if (TextBox2.Text == "")
            {
                result = false;

                Label2.Text = "* Vui lòng nhập số lượng *";
            }

            else
            {
                Label2.Text = "";
                result = true;
            }
            return result;
        }
    }
}