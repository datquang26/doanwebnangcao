using doanwebnangcao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace doanwebnangcao
{
    public partial class GridviewGioiThieu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                List<GioiThieu> lstGT = dao.DaoGioiThieu.getAllGioiThieu();
                gvGT.DataSource = lstGT;
                gvGT.DataBind();
            }
        }

        protected void gvGT_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int _maGioiThieu = Convert.ToInt32(gvGT.DataKeys[e.NewEditIndex].Value);
            GioiThieu gioiThieu = dao.DaoGioiThieu.getOneGioiThieu(_maGioiThieu);
            string strMaGioiThieu = gioiThieu.MaGioiThieu.ToString();
            Response.Redirect("EditGioiThieu.aspx?tbMaGioiThieu=" + strMaGioiThieu);
        }
    }
}