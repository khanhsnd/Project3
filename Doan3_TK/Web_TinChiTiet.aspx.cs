using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Doan3_TK
{
    public partial class Web_TinChiTiet_aspx : System.Web.UI.Page
    {
        cs_tintuc sp = new cs_tintuc();

        protected string ma = "0";
        protected string MaTin = "";
        protected string TieuDe = "";
        protected string MoTa = "";
        protected string NoiDung = "";
        protected string HinhAnh = "";
        protected string NgayDang = "";

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
                DataSet ds = new DataSet();
                ds = sp.laytttheoma(ma);

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        try
                        {
                            //hien this sp chi ChiTietSP
                            MaTin = ds.Tables[0].Rows[0]["MaTin"].ToString();
                            TieuDe = ds.Tables[0].Rows[0]["TieuDe"].ToString();
                            MoTa = ds.Tables[0].Rows[0]["MoTa"].ToString();
                            NoiDung = ds.Tables[0].Rows[0]["NoiDung"].ToString();
                            HinhAnh = ds.Tables[0].Rows[0]["HinhAnh"].ToString();
                            NgayDang = ds.Tables[0].Rows[0]["NgayDang"].ToString();
                        }
                        catch { }
                    }

                    if (ds.Tables.Count > 1)
                    {
                        //hien this sp chi san pham moi
                        rpttin.DataSource = ds.Tables[1];
                        rpttin.DataBind();
                    }
                    if (ds.Tables.Count > 2)
                    {
                        //hien this sp chi san pham moi
                        rptspm.DataSource = ds.Tables[2];
                        rptspm.DataBind();
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
    }
}