using doanwebnangcao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace doanwebnangcao
{
    public partial class GridviewUserComment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                List<UserComment> lstUC = dao.DaoUserComment.getAllUserComment();
                gvUC.DataSource = lstUC;
                gvUC.DataBind();
            }
        }
        protected void gvUC_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvUC.PageIndex = e.NewPageIndex;
            List<UserComment> lstUC = dao.DaoUserComment.getAllUserComment();
            gvUC.DataSource = lstUC;
            gvUC.DataBind();
        }
    }
}