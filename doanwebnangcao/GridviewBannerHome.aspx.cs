using doanwebnangcao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace doanwebnangcao
{
    public partial class GridviewBannerHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<BannerHome> lstBH = dao.DaoBannerHome.getAllBannerHome();
                gvBH.DataSource = lstBH;
                gvBH.DataBind();
            }

        }

        protected void gvBH_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int _maBannerHome = Convert.ToInt32(gvBH.DataKeys[e.NewEditIndex].Value);
            BannerHome bannerHome = dao.DaoBannerHome.getOneBannerHome(_maBannerHome);
            string strMaBannerHome = bannerHome.MaBannerHome.ToString();
            Response.Redirect("EditBannerHome.aspx?tbMaBannerHome=" + strMaBannerHome);
        }
    }
}