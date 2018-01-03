using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Doan3_TK
{
    public partial class Home : System.Web.UI.MasterPage
    {
        cs_danhmuc _dm = new cs_danhmuc();
        protected void Page_Load(object sender, EventArgs e)
        {
            rptdmcha.DataSource = _dm.danhmuccha();
            rptdmcha.DataBind();
        }

        protected DataTable danhmuccon(string macha)
        {
            return _dm.danhmuccom(macha);
        }

        protected string genkdanhmuc(string tmp)
        {

            if (tmp == "2")
            {
                return "Web_DanhMucSP.aspx?ma=";
            }
            else
            {
                return "Web_DanhMucTin.aspx?ma=";
            }
        }
    }
}