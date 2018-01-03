using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Doan3_TK
{
    public partial class QL_DonHang : System.Web.UI.Page
    {
        cs_GioHang gh = new cs_GioHang();

        protected int MaND = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (!IsPostBack)
            {
                loadcontrol();
                loaddata();
            }
        }
        protected void loadcontrol()
        {
            ddltrangthai.Items.Insert(0, new ListItem("Tất cả", "0"));
            ddltrangthai.Items.Insert(0, new ListItem("Đã duyệt", "2"));
            ddltrangthai.Items.Insert(1, new ListItem("Chờ duyệt", "1"));
            ddltrangthai.SelectedValue = "1";
        }
        protected void loaddata()
        {
            grvdonhang.DataSource = gh.laytoanbo(Convert.ToInt32(ddltrangthai.SelectedValue)).Tables[0];
            grvdonhang.DataBind();
        }

        protected void ddltrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddata();
        }

        protected void butduyet_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < grvdonhang.Rows.Count; i++)
            {
                GridViewRow objDataRow = grvdonhang.Rows[i];
                bool isChecked = ((CheckBox)objDataRow.FindControl("chkBox")).Checked;


                if (isChecked)
                {
                    dem++;
                    gh.insert_duyet_giohang(grvdonhang.Rows[i].Cells[1].Text, 1);
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
    }
}