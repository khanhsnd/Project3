using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Doan3_TK
{
    public partial class QLBanner : System.Web.UI.Page
    {
        cs_banner bn = new cs_banner();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadcontrol();
                loaddata();
            }
        }
        protected void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkAll = (CheckBox)sender;
            if (chkAll != null)
            {
                foreach (GridViewRow row in grvbanner.Rows)
                {
                    CheckBox chk = (CheckBox)row.FindControl("chkBox");
                    if (chk != null)
                        chk.Checked = chkAll.Checked;
                }
            }
        }
        protected void updatestt(int stt)
        {
            int dem = 0;
            for (int i = 0; i < grvbanner.Rows.Count; i++)
            {
                GridViewRow objDataRow = grvbanner.Rows[i];
                bool isChecked = ((CheckBox)objDataRow.FindControl("chkBox")).Checked;


                if (isChecked)
                {
                    dem++;
                    bn.update_trangthai(grvbanner.Rows[i].Cells[1].Text, stt);
                }

            }
            if (dem == 0)
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa trọn đối tượng" + "')</script>");

                return;
            }
            else
            {

                Response.Write("<script language='javascript'>alert('" + "Cập nhât thành công" + "')</script>");
                loaddata();
            }

        }

        protected void loadcontrol()
        {

            ddltrangthai.Items.Insert(0, new ListItem("Đã duyệt", "2"));
            ddltrangthai.Items.Insert(1, new ListItem("Chờ duyệt", "1"));
            ddltrangthai.Items.Insert(2, new ListItem("Đã xóa", "0"));
            ddltrangthai.SelectedValue = "2";
        }
        protected void grvbanner_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvbanner.PageIndex = e.NewPageIndex;
            loaddata();
        }
        protected void loaddata()
        {
            grvbanner.DataSource = bn.laytoanbobn( Convert.ToInt32(ddltrangthai.SelectedValue)).Tables[0];
            grvbanner.DataBind();
        }

        protected void butthemmoi_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Admin_ThemBanner.aspx");
        }
        protected void butduyet_Click(object sender, EventArgs e)
        {
            updatestt(2);
            loaddata();
        }

        protected void butchoduyet_Click(object sender, EventArgs e)
        {
            updatestt(1);
            loaddata();
        }

        protected void butxoa2_Click(object sender, EventArgs e)
        {
            updatestt(0);
            loaddata();
        }

        protected void ddltrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddata();
        }

        
    }
}