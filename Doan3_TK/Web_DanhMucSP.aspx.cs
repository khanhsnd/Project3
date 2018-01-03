using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Doan3_TK
{
    public partial class DanhMucSP : System.Web.UI.Page
    {
        cs_sanpham sp = new cs_sanpham();

        protected  string madm = "0";
        protected int page = 1;
        protected int TotalPage = 0;

        protected int cout = 0;
        protected int couttt()
        {
            cout = cout + 1;
            return cout;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                madm = Request.QueryString["ma"].ToString();
            }
            catch
            {
                madm = "0";
            }
            try
            {
                page = Convert.ToInt32( Request.QueryString["page"].ToString());
            }
            catch
            {
                page = 1;
            }
            DataSet ds = sp.laysptheodanhmuc(madm, page.ToString());
            try
            {
                
                rptsp.DataSource = ds.Tables[0];
                rptsp.DataBind();

            }
            catch
            { }
            try
            {
                TotalPage = Convert.ToInt32(ds.Tables[1].Rows[0][0]);
            }
            catch
            { }
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