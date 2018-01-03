using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Doan3_TK
{
    public partial class Web_GioiHang : System.Web.UI.Page
    {
        CS_CongCu cc = new CS_CongCu();
        protected string butname = "";
        protected string link = "";
        protected string Thongbao = "";
        protected string lblTongTien = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    loaddata();
                }
            }
            catch (Exception)
            {

            }
        }
        protected void loaddata()
        {

            float TT = 0;
            DataTable dt = (DataTable)Session["giohang"];
            if (dt == null)
            {
                Thongbao = " Bạn chưa chọn sản phẩm nào";
                butname = "";
                butmuahang.Visible=false;
                butCapNhap.Visible = false;
                buthuy.Visible = false;
                link = "~/web_trangchu.aspx";
            }
            else
            {
                Thongbao = "Bạn đã chọn mua: " + dt.Rows.Count + " sản phẩm";
                butmuahang.Text = "Đặt hàng";
                link = "~/web_trangchu.aspx";
            }
            grvGioHang.DataSource = (DataTable)Session["giohang"];
            grvGioHang.DataBind();
            for (int i = 0; i < grvGioHang.Rows.Count; i++)
            {

                TT = TT + cc.fomatTienTT(grvGioHang.Rows[i].Cells[4].Text);

            }
            if (TT > 0)
            {
                lblTongTien = "Tổng chi phí: " + cc.FomatTienHT(TT.ToString()) + " VNĐ";
            }
        }
        protected void grvGioHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void butCapNhap_Click(object sender, EventArgs e)
        {
            float TT = 0;
            DataTable dt = (DataTable)Session["giohang"];
            for (int i = 0; i < grvGioHang.Rows.Count; i++)
            {
                int sl = int.Parse(((TextBox)grvGioHang.Rows[i].FindControl("txtSL")).Text);
                float GiaB = cc.fomatTienTT(grvGioHang.Rows[i].Cells[2].Text);
                dt.Rows[i][3] = sl;
                dt.Rows[i][4] = cc.FomatTienHT((sl * GiaB).ToString());
                if (sl == 0)
                {
                    dt.Rows.RemoveAt(i);
                }

            }
            grvGioHang.DataSource = dt;
            grvGioHang.DataBind();
            for (int i = 0; i < grvGioHang.Rows.Count; i++)
            {

                TT = TT + cc.fomatTienTT(grvGioHang.Rows[i].Cells[4].Text);

            }
            lblTongTien = "Tổng chi phí: " + cc.FomatTienHT(TT.ToString()) + " VNĐ";


            Session["giohang"] = dt;
            loaddata();
        }
        protected void butHuy_Click(object sender, EventArgs e)
        {
            //Session["giohang"] = null;
            //lblTongTien.Text = "0";
            //grvGioHang.DataSource = (DataTable)Session["giohang"];
            //grvGioHang.DataBind();

            //butDatHang.Text = "Mua Hàng";
            //butDatHang.PostBackUrl = "~/TrangNgoai/Default.aspx";
        }

        protected void butmuahang_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Web_DatHang.aspx");
        }
    }
}