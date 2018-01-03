using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Doan3_TK
{
    public partial class Admin_ThemDanhMuc : System.Web.UI.Page
    {
        cs_danhmuc dm = new cs_danhmuc();
        protected string madm = "0";
        protected int type = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            CKFinder.FileBrowser _FileBrowser = new CKFinder.FileBrowser();
            _FileBrowser.BasePath = "ckfinder";
            try
            {
                madm = Request.QueryString["madm"].ToString();
            }
            catch
            {
                madm = "0";
            }
            try
            {
                int tmp = Convert.ToInt32(madm);
                if (tmp > 0)
                {

                    Label1.Text = "Cập nhật danh mục ";
                    butthem.Text = "Cập nhật danh mục";
                }
            }
            catch { madm = "0"; }

            if (!IsPostBack)
            {
                loadcontrol();
                if (madm != "0" && madm != null)
                {
                    loaddata();
                }
            }
        }
        protected void loadcontrol()
        {
            ddldmcha.DataSource = dm.laytoanbodm("2");
            ddldmcha.DataValueField = "madm";
            ddldmcha.DataTextField = "tendm";
            ddldmcha.DataBind();


            ddldmcha.Items.Insert(0, new ListItem("Danh mục cha", "0"));


            ddlloaidm.Items.Insert(0, new ListItem("Sản phẩm", "2"));
            ddlloaidm.Items.Insert(1, new ListItem("Tin tức", "1"));

            ddltrangthai.Items.Insert(0, new ListItem("Đã duyệt", "2"));
            ddltrangthai.Items.Insert(1, new ListItem("Chờ duyệt", "1"));
            ddltrangthai.Items.Insert(2, new ListItem("Cấm", "0"));
            ddltrangthai.SelectedValue = "1";
        }
        protected void loaddata()
        {
            DataSet ds = new DataSet();
            ds = dm.laydmtheoma(madm);

            ddldmcha.Text = ds.Tables[0].Rows[0]["DMcha"].ToString();
            txttendm.Text = ds.Tables[0].Rows[0]["TenDM"].ToString();
            txtmota.Text = ds.Tables[0].Rows[0]["MoTa"].ToString();
            ddlloaidm.Text = ds.Tables[0].Rows[0]["LoaiDM"].ToString();
            ddltrangthai.SelectedValue = ds.Tables[0].Rows[0]["TrangThai"].ToString();

        }

        protected void butthem_Click(object sender, EventArgs e)
        {

            if (txttendm.Text.Length < 1)
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có tên danh mục" + "')</script>");
                return;
            }


            try
            {
                dm.ThemMoi_SuaDanhMuc(Convert.ToInt32(madm), Convert.ToInt32(ddldmcha.Text), txttendm.Text, txtmota.Text, Convert.ToInt32(ddlloaidm.SelectedValue), Convert.ToInt32(ddltrangthai.SelectedValue));
                if (madm == "0")
                {
                    Response.Write("<script language='javascript'>alert('" + "Thêm mới thành công" + "')</script>");

                }
                else
                {
                    Response.Write("<script language='javascript'>alert('" + "Cập nhật sản phẩm thành công" + "')</script>");
                    loaddata();
                }
            }
            catch
            {
                Response.Write("<script language='javascript'>alert('" + "Thêm mới thất bại" + "')</script>");
            }
        }

        protected void butquayve_Click(object sender, EventArgs e)
        {
            Response.Redirect("./QL_DanhMuc.aspx");
        }


    }
}