using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Doan3_TK
{
    public partial class DanhMucTin : System.Web.UI.Page
    {
        cs_tintuc sp = new cs_tintuc();

        protected string madm = "0";
        protected int page = 1;
        protected int TotalPage = 0;
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
                page = Convert.ToInt32(Request.QueryString["page"].ToString());
            }
            catch
            {
                page = 1;
            }
            if (!IsPostBack)
            {
                loaddata();
            }

        }

        protected void loaddata()
        {
            DataSet ds = sp.laytttheodanhmuc(madm, page);
            rpttintop.DataSource = ds.Tables[0];
            rpttintop.DataBind();

            try
            {
                TotalPage = Convert.ToInt32(ds.Tables[1].Rows[0][0]);
            }
            catch
            {
                TotalPage = 1;
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