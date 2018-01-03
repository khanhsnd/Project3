using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Doan3_TK.control
{
    public partial class banner : System.Web.UI.UserControl
    {
        cs_banner cs = new cs_banner();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = cs.laytoanbobn(2);

            rptbanner.DataSource = ds.Tables[0];
            rptbanner.DataBind();
        }
    }
}