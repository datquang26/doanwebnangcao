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
    public partial class GridviewBannerAll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<BannerPop> lstBA = dao.DaoBannerPop.getAllBanner();
                gvBA.DataSource = lstBA;
                gvBA.DataBind();

            }
        }

        protected void gvBA_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            int MaBanner = Convert.ToInt32(gvBA.DataKeys[e.RowIndex].Value);

            string strSql = "Delete from BannerPop where MaBanner = " + MaBanner.ToString();
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
            Response.Redirect("GridviewBannerAll.aspx");
        }

        protected void gvBA_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int _maBanner = Convert.ToInt32(gvBA.DataKeys[e.NewEditIndex].Value);
            BannerPop bannerAll = dao.DaoBannerPop.getOneBannerAll(_maBanner);
            string strMaBanner = bannerAll.MaBanner.ToString();
            Response.Redirect("EditBannerAll.aspx?tbMaBanner=" + strMaBanner);
        }
    }
}