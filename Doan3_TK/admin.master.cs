using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Doan3_TK
{
    public partial class admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string MaTK = Session["TenTK"].ToString();
                    if (MaTK != null && MaTK != "")
                    {

                    }
                    else
                    {
                        Response.Redirect("DangNhap.aspx");
                    }
                }
                catch
                {
                    Response.Redirect("DangNhap.aspx");
                }
            }
        }

        protected void butdangxuat_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            
            Response.Redirect("DangNhap.aspx");
        }
    }
}