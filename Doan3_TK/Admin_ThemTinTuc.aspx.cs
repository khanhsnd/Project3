using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Doan3_TK
{
    public partial class Admin_ThemTinTuc : System.Web.UI.Page
    {
        cs_tintuc tt = new cs_tintuc();
        cs_danhmuc dm = new cs_danhmuc();
        protected string matin = "0";
        protected int type = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            CKFinder.FileBrowser _FileBrowser = new CKFinder.FileBrowser();
            _FileBrowser.BasePath = "ckfinder";
            _FileBrowser.SetupCKEditor(ckconten);
            try
            {
                matin = Request.QueryString["matin"].ToString();

            }
            catch
            {
                matin = "0";
            }

            try
            {
                if (Convert.ToInt32(matin) > 0)
                {
                    Label1.Text = "Cập nhật tin tức";
                    butthem.Text = "Cập nhật tin tức";
                }
            }
            catch
            {
                matin = "0";
            }



            if (!IsPostBack)
            {
                loadcontrol();
                LayNam();
                if (matin != "0" && matin != null)
                {
                    loaddata();
                }
            }
        }
        protected void loadcontrol()
        {

            ddldanhmuc.DataSource = dm.danhmuctt();
            ddldanhmuc.DataValueField = "madm";
            ddldanhmuc.DataTextField = "tendm";
            ddldanhmuc.DataBind();

            ddltrangthai.Items.Insert(0, new ListItem("Đã duyệt", "2"));
            ddltrangthai.Items.Insert(1, new ListItem("Chờ duyệt", "1"));
            ddltrangthai.Items.Insert(2, new ListItem("Cấm", "0"));
            ddltrangthai.SelectedValue = "1";
        }
        protected void loaddata()
        {
            DataSet ds = new DataSet();
            ds = tt.laytttheoma_admin(matin);

            txttieude.Text = ds.Tables[0].Rows[0]["TieuDe"].ToString();
            txtmota.Text = ds.Tables[0].Rows[0]["MoTa"].ToString();
            ckconten.Text = ds.Tables[0].Rows[0]["NoiDung"].ToString();
            ddltrangthai.SelectedValue = ds.Tables[0].Rows[0]["TrangThai"].ToString();
            //  txtngayxb.Text = ds.Tables[0].Rows[0]["NgayXB"].ToString();
            ddldanhmuc.SelectedValue = ds.Tables[0].Rows[0]["MaDM"].ToString();
            imghinhanh.ImageUrl = ds.Tables[0].Rows[0]["HinhAnh"].ToString();

            try
            {
                DateTime tm = Convert.ToDateTime(ds.Tables[0].Rows[0]["NgayXB"].ToString());
                ddNgay.SelectedValue = tm.Day.ToString();
                ddThang.SelectedValue=tm.Month.ToString();
                ddNam.SelectedValue = tm.Year.ToString();
            }
            catch
            {}
        }
        protected void LayNam()
        {

            ddNam.Items.Clear();
            for (int i = 1; i <= 31; i++)
            {
                string tmp=i.ToString();
                if (i < 10)
                {
                    tmp = "0" + i;
                }

                ddNgay.Items.Insert(0, new ListItem(tmp, tmp));
                if (i <= 12)
                {
                    ddThang.Items.Insert(0, new ListItem(tmp, tmp));
                }
                if (i <= 2)
                {
                    ddNam.Items.Insert(0, new ListItem((DateTime.Now.Year + i - 1).ToString(), (DateTime.Now.Year + i - 1).ToString()));
                }
            }
           
            ddNam.SelectedValue = DateTime.Now.Year.ToString();
            ddNgay.SelectedValue = DateTime.Now.Day.ToString();
            ddThang.SelectedValue = DateTime.Now.Month.ToString();
        }
        protected void butthem_Click(object sender, EventArgs e)
        {
         

            if (txttieude.Text.Length < 1)
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có tiêu đề" + "')</script>");
                return;
            }

            if (txtmota.Text.Length < 1)
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có mô tả tin tức" + "')</script>");
                return;
            }
            if (ckconten.Text.Length < 1)
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có nội dung tin tức" + "')</script>");
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
                string Ngayxb = ddNam.SelectedValue + "/" + ddThang.SelectedValue + "/" + ddNgay.SelectedValue;
                tt.ThemMoi_SuaTinTuc(Convert.ToInt32(matin), Convert.ToInt32(ddldanhmuc.SelectedValue), txttieude.Text, txtmota.Text, ckconten.Text, hinhanh, Ngayxb, Convert.ToInt32(ddltrangthai.SelectedValue), 1);
                if (matin == "0")
                {
                    Response.Write("<script language='javascript'>alert('" + "Thêm mới thành công" + "')</script>");
                  
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('" + "Cập nhật tin tức thành công" + "')</script>");
                    loaddata();
                }
            }
            catch
            {
                Response.Write("<script language='javascript'>alert('" + "Thêm mới thất bại" + "')</script>");
            }
        }

        protected void butquayve_Click1(object sender, EventArgs e)
        {
            Response.Redirect("./QL_TinTuc.aspx");
        }
    }
}