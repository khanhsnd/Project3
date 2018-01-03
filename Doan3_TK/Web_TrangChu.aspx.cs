using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Doan3_TK
{
    public partial class Web_TrangChu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            cs_trangchu tc = new cs_trangchu();
            ds = tc.top8sp_top6tt();

            rptsanpham.DataSource = ds.Tables[0];
            rptsanpham.DataBind();

            rpttintop.DataSource = ds.Tables[1];
            rpttintop.DataBind();
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