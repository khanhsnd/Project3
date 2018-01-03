using System;
using System.Data;

namespace Doan3_TK
{
    public partial class Web_TrangChu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            var tc = new cs_trangchu();
            ds = tc.top8sp_top6tt();

            rptsanpham.DataSource = ds.Tables[0];
            rptsanpham.DataBind();

            rpttintop.DataSource = ds.Tables[1];
            rpttintop.DataBind();
        }
        protected string Catxau(string tmp, int x)
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