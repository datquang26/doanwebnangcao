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
    public partial class GridviewNguoiDung : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                List<NguoiDung> lstND = dao.DaoNguoiDung.getAllNguoiDung();
                gvND.DataSource = lstND;
                gvND.DataBind();
            }
        }
        protected void gvND_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvND.PageIndex = e.NewPageIndex;
            List<NguoiDung> lstND = dao.DaoNguoiDung.getAllNguoiDung();
            gvND.DataSource = lstND;
            gvND.DataBind();
        }

        protected void gvND_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            int ID= Convert.ToInt32(gvND.DataKeys[e.RowIndex].Value);

            string strSql = "Delete from NguoiDung where ID = " + ID.ToString();
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
            Response.Redirect("GridviewNguoiDung.aspx");
        }

        protected void gvND_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int _iD = Convert.ToInt32(gvND.DataKeys[e.NewEditIndex].Value);
            NguoiDung nguoiDung = dao.DaoNguoiDung.getOneNguoiDung(_iD);
            string strID = nguoiDung.ID.ToString();
            Response.Redirect("EditNguoiDung.aspx?tbID=" + strID);
        }
    }
}