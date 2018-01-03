using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Doan3_TK
{
    public partial class Web_ChiTietSP : System.Web.UI.Page
    {
        cs_sanpham sp = new cs_sanpham();
        CS_CongCu cc = new CS_CongCu();
        protected string ma = "0";
        protected string IdSP = "";
        protected string MaSP = "";
        protected string TenSP = "";
        protected string GioiThieu = "";
        protected string ChiTiet = "";
        protected string HinhAnh = "";
        protected string GiaBan = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ma = Request.QueryString["ma"].ToString();
            }
            catch
            { }
            if (!IsPostBack)
            {
                loaddata();
            }
        }

        protected void loaddata()
        {

            DataSet ds = new DataSet();
            ds = sp.laysptheoma(ma);

            if (ds != null)
            {
                if (ds.Tables.Count > 0)
                {
                    try
                    {
                        //hien this sp chi ChiTietSP
                        MaSP = ds.Tables[0].Rows[0]["MaSP"].ToString();
                        TenSP = ds.Tables[0].Rows[0]["TenSP"].ToString();
                        GioiThieu = ds.Tables[0].Rows[0]["GioiThieu"].ToString();
                        ChiTiet = ds.Tables[0].Rows[0]["ChiTiet"].ToString();
                        HinhAnh = ds.Tables[0].Rows[0]["HinhAnh"].ToString();
                        GiaBan = ds.Tables[0].Rows[0]["GiaBan"].ToString();
                    }
                    catch { }
                }

                if (ds.Tables.Count > 1)
                {
                    //hien this sp chi san pham moi
                    rptmoi.DataSource = ds.Tables[1];
                    rptmoi.DataBind();
                }
                if (ds.Tables.Count > 2)
                {
                    //hien this sp chi san pham moi
                    rpttinmoi.DataSource = ds.Tables[2];
                    rpttinmoi.DataBind();
                }

                if (ds.Tables.Count > 4)
                {
                    //hien thi tin lien quan
                    rpttinlienquan.DataSource = ds.Tables[4];
                    rpttinlienquan.DataBind();
                }
                if (ds.Tables.Count > 5)
                {
                    //hien thi tin xem nhieu
                    rpttixemnhieu.DataSource = ds.Tables[5];
                    rpttixemnhieu.DataBind();
                }
            }
        }
        protected string catxau(string tmp, int x)
        {
            if (tmp.Length > x)
            {
                return tmp.Substring(0, x) + "...";
            }
            else
                return tmp;
        }

        protected void butmua_Click(object sender, EventArgs e)
        {
            // kiem tra xem gio hang ton tai chua
            if (Session["giohang"] == null)
            {

                DataTable giohang = new DataTable();
                giohang.Columns.Add("IdSP");
                giohang.Columns.Add("TenSP");
                giohang.Columns.Add("GiaBan");
                giohang.Columns.Add("SL");
                giohang.Columns.Add("ThanhTien");
                Session["giohang"] = giohang;

            }


            // lay ra sp chit iet
            DataTable dtlay = sp.laysptheoma(ma).Tables[0];
            DataRow dr;
            dr = dtlay.Rows[0];
            string IdSP = dr["IdSP"].ToString();
            string TenSP = dr["TenSP"].ToString();
            string GiaB = cc.FomatTienHT(dr["GiaBan"].ToString());



            DataTable dt = (DataTable)Session["giohang"];
            bool kt = true;
            int dem = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == IdSP)
                {
                    kt = false;
                    dem = i;
                    break;
                }
            }
            if (kt)
            {
                dt.Rows.Add(new string[] { IdSP, TenSP, GiaB, "1", GiaB });
            }
            else
            {
                dt.Rows[dem][3] = int.Parse(dt.Rows[dem][3].ToString()) + 1;
                dt.Rows[dem][4] = cc.FomatTienHT((cc.fomatTienTT(dt.Rows[dem][4].ToString()) + cc.fomatTienTT(GiaB)).ToString());
            }

            // gan lai vao gio hang
            Session["giohang"] = dt;
            Response.Write("<script language='javascript'>alert('" + "Thêm thành công" + "')</script>");
            loaddata();
        }
    }
}