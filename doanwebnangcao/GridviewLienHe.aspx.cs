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
    public partial class GridviewLienHe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<LienHe> lstGT = dao.DaoLienHe.getAllLienHe();
                gvLH.DataSource = lstGT;
                gvLH.DataBind();
            }
        }
        protected void gvLH_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            int MaLienHe = Convert.ToInt32(gvLH.DataKeys[e.RowIndex].Value);

            string strSql = "Delete from LienHe where MaLienHe= " + MaLienHe.ToString();
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
            Response.Redirect("GridviewLienHe.aspx");
        }
    }
}