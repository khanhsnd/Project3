using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Doan3_TK
{
    public partial class Admin_ThemBanner : System.Web.UI.Page
    {
        cs_banner bn = new cs_banner();
        protected string ma = "0";
        protected void Page_Load(object sender, EventArgs e)
        {
            CKFinder.FileBrowser _FileBrowser = new CKFinder.FileBrowser();
            _FileBrowser.BasePath = "ckfinder";
            try
            {
                ma = Request.QueryString["ma"].ToString();

            }
            catch
            {
                ma = "0";
            }


            try
            {
                if (Convert.ToInt32(ma) > 0)
                {
                    Label1.Text = "Cập nhật banner";
                    butthem.Text = "Cập nhật banner";
                }
            }
            catch
            {
                ma = "0";
            }



            if (!IsPostBack)
            {
                loadcontrol();
                if (ma != "0" && ma != null)
                {
                    loaddata();
                }
            }
        }
        protected void loadcontrol()
        {

            ddltrangthai.Items.Insert(0, new ListItem("Đã duyệt", "2"));
            ddltrangthai.Items.Insert(1, new ListItem("Chờ duyệt", "1"));
            ddltrangthai.Items.Insert(2, new ListItem("Cấm", "0"));
            ddltrangthai.SelectedValue = "1";
        }
        protected void loaddata()
        {
            DataSet ds = new DataSet();
            ds = bn.laybntheoma(ma);

            txttieude.Text = ds.Tables[0].Rows[0]["TieuDe"].ToString();
            txtlink.Text = ds.Tables[0].Rows[0]["Link"].ToString();
            ddltrangthai.SelectedValue = ds.Tables[0].Rows[0]["TrangThai"].ToString();
            imghinhanh.ImageUrl = ds.Tables[0].Rows[0]["HinhAnh"].ToString();
        }
        protected void butthem_Click(object sender, EventArgs e)
        {
            if (txttieude.Text.Length < 1)
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có tiêu đề" + "')</script>");
                return;
            }

            if (txtlink.Text.Length < 1)
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có link" + "')</script>");
                return;
            }
          
            string hinhanh = "";
            try
            {
                hinhanh = imghinhanh.ImageUrl;

                if (Request.Form["urlanh"] != "")
                {
                    hinhanh = Request.Form["urlanh"];
                }
            }
            catch
            { }

            if (hinhanh.Length < 1)
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có hình ảnh tin tức" + "')</script>");
                return;
            }
            try
            {
                bn.ThemMoi_SuaBanner(Convert.ToInt32(ma), txttieude.Text, txtlink.Text, hinhanh, Convert.ToInt32(ddltrangthai.SelectedValue));
              

                if (ma == "0")
                {
                    Response.Write("<script language='javascript'>alert('" + "Thêm mới thành công" + "')</script>");

                }
                else
                {
                    Response.Write("<script language='javascript'>alert('" + "Cập nhật thành công" + "')</script>");
                    loaddata();
                }
                
            }
            catch {
                Response.Write("<script language='javascript'>alert('" + "Thêm thất bại" + "')</script>");
            }

        }

        protected void butquayve_Click(object sender, EventArgs e)
        {
            Response.Redirect("./QL_Banner.aspx");
        }
    }
}