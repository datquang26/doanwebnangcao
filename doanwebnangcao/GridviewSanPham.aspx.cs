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
    public partial class GridviewSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<SanPham> lstSP = dao.DaoSanPham.getAllSanPham();
                gvSP.DataSource = lstSP;
                gvSP.DataBind();

            }

        }
        protected void gvSP_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvSP.PageIndex = e.NewPageIndex;
            List<SanPham> lstSP = dao.DaoSanPham.getAllSanPham();
            gvSP.DataSource = lstSP;
            gvSP.DataBind();
        }

        protected void gvSP_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            int MaSanPham = Convert.ToInt32(gvSP.DataKeys[e.RowIndex].Value);

            string strSql = "Delete from SanPham where MaSanPham = " + MaSanPham.ToString();
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;

            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand(strSql, sqlConnection);
                cmd.CommandType = System.Data.CommandType.Text;
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
            Response.Redirect("GridviewSanPham.aspx");
        }

        protected void gvSP_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int _maSanPham = Convert.ToInt32(gvSP.DataKeys[e.NewEditIndex].Value);
            SanPham sanPham = dao.DaoSanPham.getOneSanPham(_maSanPham);
            string strMasp = sanPham.MaSanPham.ToString();
            Response.Redirect("EditSanPham.aspx?tbMaSanPham=" + strMasp);
        }

        protected void gvSP_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {

        }
    }
}