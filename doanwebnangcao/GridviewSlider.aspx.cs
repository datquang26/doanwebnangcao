using doanwebnangcao.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace doanwebnangcao
{
    public partial class GridviewSlider : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)

            {
                List<Slider> lstSL = dao.DaoSlider.getAllSlider();
                gvSL.DataSource = lstSL;
                gvSL.DataBind();
            }
        }

        protected void gvSL_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int _maSliderAnh = Convert.ToInt32(gvSL.DataKeys[e.NewEditIndex].Value);
            Slider slider = dao.DaoSlider.getOneSlider(_maSliderAnh);
            string strMaSliderAnh = slider.MaSliderAnh.ToString();
            Response.Redirect("EditSlider.aspx?tbMaSliderAnh=" + strMaSliderAnh);
        }
    }
}