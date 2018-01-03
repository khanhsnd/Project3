using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Doan3_TK
{
    public partial class Admin_GioHangChitiet : System.Web.UI.Page
    {

        cs_GioHang gh = new cs_GioHang();
        CS_CongCu cc = new CS_CongCu();
        float TT = 0;
        protected string magh = "0";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                magh = Request.QueryString["ma"].ToString();
            }
            catch
            {
                magh = "0";
            }
            if (!IsPostBack)
            {
                loaddata();
            }

        }
        protected void loaddata()
        {

            DataSet ds = gh.GioHangChiTiet(Convert.ToInt32(magh));

            txtTen.Text = ds.Tables[0].Rows[0]["HoTen"].ToString();
            txtSDT.Text = ds.Tables[0].Rows[0]["SDT"].ToString();
            txtCMT.Text = ds.Tables[0].Rows[0]["CMT"].ToString();
            txtngaysinh.Text = ds.Tables[0].Rows[0]["NgaySinh"].ToString();
            txtDiaChiKkhach.Text = ds.Tables[0].Rows[0]["DiaChi"].ToString();
            txtDiaChiNhan.Text = ds.Tables[0].Rows[0]["NoiNhan"].ToString();
            txtemail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
            txtgioitinh.Text = ds.Tables[0].Rows[0]["GioiTinh"].ToString();
          

            grvGioHang.DataSource = ds.Tables[1];
            grvGioHang.DataBind();
            for (int i = 0; i < grvGioHang.Rows.Count; i++)
            {

                TT = TT + cc.fomatTienTT(grvGioHang.Rows[i].Cells[4].Text);

            }
            lblTongTien.Text = cc.FomatTienHT(TT.ToString());

        }

        protected void butquayve_Click(object sender, EventArgs e)
        {
            Response.Redirect("./QL_DonHang.aspx");
        }
    }
}