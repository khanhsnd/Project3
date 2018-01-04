using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Doan3_TK
{
    public partial class Admin_ThemSanPham : System.Web.UI.Page
    {
        cs_sanpham sp = new cs_sanpham();
        cs_danhmuc dm = new cs_danhmuc();
        protected string idsp = "0";
      
        protected void Page_Load(object sender, EventArgs e)
        {
            CKFinder.FileBrowser _FileBrowser = new CKFinder.FileBrowser();
            _FileBrowser.BasePath = "ckfinder";
            _FileBrowser.SetupCKEditor(ckconten);
            try
            {
                idsp = Request.QueryString["masp"].ToString();
            }
            catch
            {
                idsp = "0";
            }

            try
            {
                if (Convert.ToInt32(idsp) > 0)
                {                    
                    Label1.Text = "Cập nhật sản phẩm";
                    butthem.Text = "Cập nhật sản phẩm";
                }
            }
            catch
            {
                idsp = "0";
            }

            if (!IsPostBack)
            {
                Init();
                if (idsp != "0" && idsp != null)
                {
                    Showdata();
                }
            }
        }
        protected void Init()
        {
            ddldanhmuc.DataSource = dm.danhmucsp();
            ddldanhmuc.DataValueField = "madm";
            ddldanhmuc.DataTextField = "tendm";
            ddldanhmuc.DataBind();

            ddltrangthai.Items.Insert(0, new ListItem("Đã duyệt", "2"));
            ddltrangthai.Items.Insert(1, new ListItem("Chờ duyệt", "1"));
            ddltrangthai.Items.Insert(2, new ListItem("Cấm", "0"));
            ddltrangthai.SelectedValue = "1";
        }
        protected void Showdata()
        {
            DataSet ds = new DataSet();
            ds = sp.laysptheoma_admin(idsp);
            txttensp.Text = ds.Tables[0].Rows[0]["tensp"].ToString();
            txtmasp.Text = ds.Tables[0].Rows[0]["masp"].ToString();
            txtgioithieu.Text = ds.Tables[0].Rows[0]["GioiThieu"].ToString();
            ckconten.Text = ds.Tables[0].Rows[0]["chitiet"].ToString();
            txtgiaban.Text = ds.Tables[0].Rows[0]["GiaBan"].ToString();
            ddltrangthai.SelectedValue = ds.Tables[0].Rows[0]["TrangThai"].ToString();
            ddldanhmuc.SelectedValue = ds.Tables[0].Rows[0]["MaDM"].ToString();
            txtsoluong.Text = ds.Tables[0].Rows[0]["SL"].ToString();
            imghinhanh.ImageUrl = ds.Tables[0].Rows[0]["HinhAnh"].ToString();
          

        }

        protected void butthem_Click(object sender, EventArgs e)
        {
            // bat dieu kien
            if (txtmasp.Text.Length < 1)
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có mã sản phẩm" + "')</script>");
                return;

            }
            if (txttensp.Text.Length < 1)
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có tên sản phẩm" + "')</script>");
                return;
            }

            if (txtgioithieu.Text.Length < 1)
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có giới thiệu sản phẩm" + "')</script>");
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
                Response.Write("<script language='javascript'>alert('" + "Chưa có hình ảnh sản phẩm" + "')</script>");
                return;
            }
            try
            {
                double gia = Convert.ToDouble(txtgiaban.Text);

                if (gia < 1)
                {
                    Response.Write("<script language='javascript'>alert('" + "Giá sản phẩm phải >0" + "')</script>");
                    return;
                }
            }
            catch
            {
                Response.Write("<script language='javascript'>alert('" + "Giá bán không hợp lệ" + "')</script>");
                return;
            }
            int sl = 0;
            try
            {
                int gia = Convert.ToInt32(txtgiaban.Text);

                if (sl < 0)
                {
                    sl = 0;
                }
            }
            catch
            {
                Response.Write("<script language='javascript'>alert('" + "Số lượng không hợp lệ" + "')</script>");
                return;
            }

            try
            {
                sp.ThemMoi_SuaSanPham( Convert.ToInt32(idsp),txtmasp.Text, txttensp.Text, txtgioithieu.Text, ckconten.Text, hinhanh, Convert.ToDouble(txtgiaban.Text), Convert.ToInt32(ddltrangthai.SelectedValue), Convert.ToInt32(ddldanhmuc.SelectedValue), 1, Convert.ToInt32(txtsoluong.Text));

                if (idsp == "0")
                {
                    Response.Write("<script language='javascript'>alert('" + "Thêm mới thành công" + "')</script>");
                    
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('" + "Cập nhật sản phẩm thành công" + "')</script>");
                    Showdata();
                }
            }
            catch
            {
                Response.Write("<script language='javascript'>alert('" + "Thêm mới thất bại" + "')</script>");
            }
        }

        protected void butquayve_Click(object sender, EventArgs e)
        {
            Response.Redirect("./QL_SanPham.aspx");
        }
    }
}