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
    public partial class EditGioiThieu : System.Web.UI.Page
    {
        int queryMaGioiThieu = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            queryMaGioiThieu = Convert.ToInt32(Page.Request.QueryString["tbMaGioiThieu"]);
            if (!Page.IsPostBack)
            {

                if (queryMaGioiThieu > 0)
                {
                    GioiThieu gioiThieu = dao.DaoGioiThieu.getOneGioiThieu(queryMaGioiThieu);

                    tbMaGioiThieu.Enabled = false;
                    tbMaGioiThieu.Text = queryMaGioiThieu.ToString();
                    tbIntroVideo.Text = gioiThieu.IntroVideo;
                    tbTextIntroVideo.Text = gioiThieu.TextIntroVideo;
                    tbJapanFigureText.Text = gioiThieu.JapanFigureText;

                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                string strConnection = ConfigurationManager.ConnectionStrings["ConnDB"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(strConnection))
                {
                    SqlCommand cmd = new SqlCommand(" update GioiThieu set IntroBannerImg = @introBannerImg, IntroVideo = @introVideo, TextIntroVideo = @textIntroVideo, AnhGT1 = @anhGT1, JapanFigureImg = @japanFigureImg, JapanFigureImg2 = @japanFigureImg2, JapanFigureImg3 = @japanFigureImg3 , JapanFigureText = @japanFigureText   where MaGioiThieu = @maGioiThieu  ", conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@maGioiThieu", tbMaGioiThieu.Text);
                    cmd.Parameters.AddWithValue("@introBannerImg", FileUpload1.FileName);
                    cmd.Parameters.AddWithValue("@introVideo", tbIntroVideo.Text);
                    cmd.Parameters.AddWithValue("@textIntroVideo", tbTextIntroVideo.Text);
                    cmd.Parameters.AddWithValue("@anhGT1", FileUpload2.FileName);
                    cmd.Parameters.AddWithValue("@japanFigureImg", FileUpload3.FileName);
                    cmd.Parameters.AddWithValue("@japanFigureImg2", FileUpload4.FileName);
                    cmd.Parameters.AddWithValue("@japanFigureImg3", FileUpload5.FileName);
                    cmd.Parameters.AddWithValue("@japanFigureText", tbJapanFigureText.Text);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Response.Redirect("GridviewGioiThieu.aspx");
                }
            }
        }


        bool validate()
        {
            bool result = false;


            if (tbMaGioiThieu.Text == "" || FileUpload1.FileName == "" || tbIntroVideo.Text == "" || tbTextIntroVideo.Text == "" || FileUpload2.FileName == "" || FileUpload3.FileName == "" || FileUpload4.FileName == "" || FileUpload5.FileName == "" || tbJapanFigureText.Text == "")
            {
                result = false;
                Label1.Text = "* Vui lòng nhập thêm thông tin sản phẩm *";

            }
            else
            {
                Label1.Text = "";
                result = true;
            }
            return result;
        }
    }
}