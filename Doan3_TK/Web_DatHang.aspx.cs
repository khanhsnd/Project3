using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace Doan3_TK
{
    public partial class Web_DatHang : System.Web.UI.Page
    {
        cs_GioHang gh = new cs_GioHang();
        CS_CongCu cc = new CS_CongCu();
        float TT = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        protected void LayNam()
        {

            ddNam.Items.Clear();
            for (int i = 1940; i < (DateTime.Today.Year - 1); i++)
            {
                ddNam.Items.Add(i.ToString());
            }
        }
        protected void loaddata()
        {
            try
            {
                if (!IsPostBack)
                {
                    LayNam();


                    grvGioHang.DataSource = (DataTable)Session["giohang"];
                    grvGioHang.DataBind();
                    for (int i = 0; i < grvGioHang.Rows.Count; i++)
                    {

                        TT = TT + cc.fomatTienTT(grvGioHang.Rows[i].Cells[4].Text);

                    }
                    if (TT == 0)
                    {
                        butGuiDonHang.Enabled = false;
                        butGuiDonHang.Text = "Chưa có sản phẩm";

                    }
                    lblTongTien.Text = cc.FomatTienHT(TT.ToString());
                }
            }
            catch (Exception)
            {

            }
        }

        protected void butGuiDonHang_Click(object sender, EventArgs e)
        {
            int TSL = 0;

            for (int i = 0; i < grvGioHang.Rows.Count; i++)
            {

                TSL = TSL + int.Parse(grvGioHang.Rows[i].Cells[3].Text);

            }
            string NgaySinh = ddNam.SelectedItem.Text + "/" + ddThang.SelectedItem.Text + "/" + ddNgay.SelectedItem.Text;

            if (KiemTra())
            {

                string magh = gh.insert_giohang(txtTen.Text, txtSDT.Text, txtCMT.Text, NgaySinh, txtDiaChiKkhach.Text, txtDiaChiNhan.Text, txtemail.Text, ddGioiTinh.SelectedValue, TSL, cc.fomatTienTT(lblTongTien.Text));

                GhiChiTiet(magh);
                Response.Write("<script language='javascript'>alert('" + "Đặt hàng thành công" + "')</script>");
                Session["giohang"] = null;
                lblTongTien.Text = "0";
                grvGioHang.DataSource = (DataTable)Session["giohang"];
                grvGioHang.DataBind();

                butGuiDonHang.Text = "Về trang chủ";
                butGuiDonHang.PostBackUrl = "./web_trangchu.aspx";

            }
        }
        protected bool KiemTra()
        {

            if (txtTen.Text == "")
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có tên khách hàng" + "')</script>");
                return false;
            }
            try
            {

                double sl = double.Parse(txtCMT.Text);

            }
            catch
            {
                Response.Write("<script language='javascript'>alert('" + "Số CMT không đúng định dạng! chỉ được nhập số" + "')</script>");
                return false;
            }
            if (txtCMT.Text.Length != 9)
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có Số CMT không đúng" + "')</script>");
                return false;
            }
            if (txtCMT.Text == "")
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có Số CMT khách hàng" + "')</script>");
                return false;
            }
            if (ddGioiTinh.SelectedItem.Text == "Giới Tính")
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có trọn giới tính" + "')</script>");
                return false;
            }
            if (ddGioiTinh.SelectedItem.Text == "Giới Tính")
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có trọn giới tính" + "')</script>");
                return false;
            }

            if (txtSDT.Text == "")
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có số ddienj thoại" + "')</script>");
                return false;
            }
            try
            {

                double sl = double.Parse(txtSDT.Text);

            }

            catch
            {
                Response.Write("<script language='javascript'>alert('" + "Số điện thoại không đúng định dạng! chỉ được nhập số" + "')</script>");
                return false;
            }
            string sdt = txtSDT.Text;

            if (sdt.Length != 11 && sdt.Length != 10)
            {
                Response.Write("<script language='javascript'>alert('" + "Số điện thoại không đúng ! phải có 10 hoăc 11 chữ số" + "')</script>");
                return false;
            }
            sdt = sdt.Substring(0, 1);
            if (sdt != "0")
            {
                Response.Write("<script language='javascript'>alert('" + "Số điện thoại không đúng định dạng!phải bắt đầu bằng số 0" + "')</script>");
                return false;
            }
            if (txtDiaChiKkhach.Text == "")
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có địa chỉ khách hàng" + "')</script>");
                return false;
            }
            if (txtDiaChiNhan.Text == "")
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa có địa chỉ nhận hàng" + "')</script>");
                return false;
            }
            return true;
        }
        protected void GhiChiTiet(string magh)
        {
            try
            {
                for (int i = 0; i < grvGioHang.Rows.Count; i++)
                {

                    gh.insert_CT_giohang(Convert.ToInt32(magh), Convert.ToInt32(grvGioHang.Rows[i].Cells[0].Text), grvGioHang.Rows[i].Cells[1].Text, Convert.ToInt32(cc.fomatTienTT(grvGioHang.Rows[i].Cells[3].Text)), cc.fomatTienTT(grvGioHang.Rows[i].Cells[4].Text));

                }
                Response.Write("<script language='javascript'>alert('" + "Đặt hàng thành công" + "')</script>");

            }
            catch
            {
                Response.Write("<script language='javascript'>alert('" + "Đặt hàng không thành công" + "')</script>");
            }

        }
    }
}