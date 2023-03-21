using doanwebnangcao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace doanwebnangcao
{
    public partial class gioi_thieu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
                List<GioiThieu> lstGT = dao.DaoGioiThieu.getAllGioiThieu();
                gvGT.DataSource = lstGT;
                gvGT.DataBind();
            
        }
    }
}