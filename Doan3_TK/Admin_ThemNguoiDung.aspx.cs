using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Doan3_TK
{
    public partial class Admin_ThemNguoiDung : System.Web.UI.Page
    {
        cs_nguoidung nd = new cs_nguoidung();
        protected string mand = "0";
        protected void Page_Load(object sender, EventArgs e)
        {
            CKFinder.FileBrowser _FileBrowser = new CKFinder.FileBrowser();
            _FileBrowser.BasePath = "ckfinder";
            try
            {
                mand = Request.QueryString["mand"].ToString();

            }
            catch
            {
                mand = "0";
            }

            try
            {
                if (Convert.ToInt32(mand) > 0)
                {
                    Label1.Text = "Cập nhật người dùng";
                    butthem.Text = "Cập nhật người dùng";
                }
            }
            catch
            {
                mand = "0";
            }



            if (!IsPostBack)
            {
                loadcontrol();
                LayNam();
                if (mand != "0" && mand != null)
                {
                    loaddata();
                }
            }
        }
        protected void loadcontrol()
        {
            ddlquyen.Items.Insert(0, new ListItem("Biên tập", "3"));
            ddlquyen.Items.Insert(1, new ListItem("Quản lý", "2"));
            ddlquyen.Items.Insert(2, new ListItem("Admin", "1"));
            ddlquyen.SelectedValue = "3";



            ddltrangthai.Items.Insert(0, new ListItem("Đã duyệt", "2"));
            ddltrangthai.Items.Insert(1, new ListItem("Chờ duyệt", "1"));
            ddltrangthai.Items.Insert(2, new ListItem("Cấm", "0"));
            ddltrangthai.SelectedValue = "1";
        }
        //protected void LayNam()
        //{

        //    ddNam.Items.Clear();
        //    for (int i = 1940; i < (DateTime.Today.Year - 1); i++)
        //    {
        //        ddNam.Items.Add(i.ToString());
        //    }
        //}
        protected void LayNam()
        {

            ddNam.Items.Clear();
            for (int i = 1; i <= 31; i++)
            {
                string tmp = i.ToString();
                if (i < 10)
                {
                    tmp = "0" + i;
                }

                ddNgay.Items.Insert(0, new ListItem(tmp, tmp));
                if (i <= 12)
                {
                    ddThang.Items.Insert(0, new ListItem(tmp, tmp));
                }
               
            }
            for (int i = 1; i <= 100; i++)
            {

                ddNam.Items.Insert(0, new ListItem((DateTime.Now.Year - i).ToString(), (DateTime.Now.Year - i).ToString()));

            }
            ddNam.SelectedValue = DateTime.Now.Year.ToString();
            ddNgay.SelectedValue = DateTime.Now.Day.ToString();
            ddThang.SelectedValue = DateTime.Now.Month.ToString();

         
        }
        protected void loaddata()
        {

            DataSet ds = new DataSet();
            ds = nd.layndtheoma(mand);

            txttennd.Text = ds.Tables[0].Rows[0]["HoTen"].ToString();
            ddgioitinh.SelectedItem.Text = ds.Tables[0].Rows[0]["GioiTinh"].ToString();
            txtsdt.Text = ds.Tables[0].Rows[0]["SDT"].ToString();
            txtemail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
            txtdiachi.Text = ds.Tables[0].Rows[0]["DiaChi"].ToString();
            ddlquyen.SelectedValue = ds.Tables[0].Rows[0]["NhomQuyen"].ToString();
            ddltrangthai.SelectedValue = ds.Tables[0].Rows[0]["TrangThai"].ToString();
            //  txtngayxb.Text = ds.Tables[0].Rows[0]["NgayXB"].ToString();
            imghinhanh.ImageUrl = ds.Tables[0].Rows[0]["Avatar"].ToString();

            try
            {
                DateTime tm = Convert.ToDateTime(ds.Tables[0].Rows[0]["NgaySinh"].ToString());
                ddNgay.SelectedValue = tm.Day.ToString();
                ddThang.SelectedValue = tm.Month.ToString();
                ddNam.SelectedValue = tm.Year.ToString();
            }
            catch
            { }
        }

        protected void butthem_Click(object sender, EventArgs e)
        {
            if (txttennd.Text == "")
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có tên khách hàng" + "')</script>");
                return;
            }

            if (ddgioitinh.SelectedItem.Text == "Giới Tính")
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có trọn giới tính" + "')</script>");
                return;
            }
            if (ddgioitinh.SelectedItem.Text == "Giới Tính")
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có trọn giới tính" + "')</script>");
                return;
            }
            if (txtsdt.Text == "")
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có số điện thoại" + "')</script>");
                return;
            }
            try
            {

                double sl = double.Parse(txtsdt.Text);

            }

            catch
            {
                Response.Write("<script language='javascript'>alert('" + "Số điện thoại không đúng định dạng! chỉ được nhập số" + "')</script>");
                return;
            }
            string sdt = txtsdt.Text;

            if (sdt.Length != 11 && sdt.Length != 10)
            {
                Response.Write("<script language='javascript'>alert('" + "Số điện thoại không đúng ! phải có 10 hoăc 11 chữ số" + "')</script>");
                return;
            }
            sdt = sdt.Substring(0, 1);
            if (sdt != "0")
            {
                Response.Write("<script language='javascript'>alert('" + "Số điện thoại không đúng định dạng!phải bắt đầu bằng số 0" + "')</script>");
                return;
            }
            if (txtdiachi.Text == "")
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có địa chỉ khách hàng" + "')</script>");
                return;
                
            }
            if (txtdiachi.Text == "")
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có địa chỉ nhận hàng" + "')</script>");
                return;
                
            }
           

            string avatar = "";
            try
            {
                avatar = imghinhanh.ImageUrl;

                if (Request.Form["urlanh"] != "")
                {
                    avatar = Request.Form["urlanh"];
                }
            }
            catch
            { }

            if (avatar.Length < 1)
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có avatar người dùng" + "')</script>");
                return;
            }



            try
            {
                string Ngaysinh = ddNam.SelectedValue + "/" + ddThang.SelectedValue + "/" + ddNgay.SelectedValue;
                nd.ThemMoi_SuaNguoiDung(Convert.ToInt32(mand), txttennd.Text, ddgioitinh.SelectedItem.Text, txtsdt.Text, txtemail.Text, txtdiachi.Text, Ngaysinh, Convert.ToInt32(ddltrangthai.SelectedValue), avatar, Convert.ToInt32(ddlquyen.SelectedValue));
                if (mand == "0")
                {
                    Response.Write("<script language='javascript'>alert('" + "Thêm mới thành công" + "')</script>");

                }
                else
                {
                    Response.Write("<script language='javascript'>alert('" + "Cập nhật thành công" + "')</script>");
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
            Response.Redirect("./QL_NguoiDung.aspx");
        }
    }
}