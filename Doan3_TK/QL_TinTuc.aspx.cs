using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Doan3_TK
{
    public partial class QL_TinTuc : System.Web.UI.Page
    {
        cs_tintuc tt = new cs_tintuc();
        cs_danhmuc dm = new cs_danhmuc();
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
                foreach (GridViewRow row in grvtintuc.Rows)
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
            for (int i = 0; i < grvtintuc.Rows.Count; i++)
            {
                GridViewRow objDataRow = grvtintuc.Rows[i];
                bool isChecked = ((CheckBox)objDataRow.FindControl("chkBox")).Checked;


                if (isChecked)
                {
                    dem++;

                    // updatestt ss
                    //      paras[0].Value = Convert.ToInt32(dgvlisttintuc.Rows[i].Cells[1].Text);
                    tt.update_trangthai(grvtintuc.Rows[i].Cells[1].Text, stt);
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

            }

        }
        protected void loadcontrol()
        {

            ddldanhmuc.DataSource = dm.danhmuctt();
            ddldanhmuc.DataValueField = "madm";
            ddldanhmuc.DataTextField = "tendm";
            ddldanhmuc.DataBind();
            ddldanhmuc.Items.Insert(0, new ListItem("Tất cả", "-1"));

            ddltrangthai.Items.Insert(0, new ListItem("Đã duyệt", "2"));
            ddltrangthai.Items.Insert(1, new ListItem("Chờ duyệt", "1"));
            ddltrangthai.Items.Insert(2, new ListItem("Cấm", "0"));
            ddltrangthai.SelectedValue = "2";
        }
        protected void loaddata()
        {
            grvtintuc.DataSource = tt.laytoanbott(ddldanhmuc.SelectedValue, Convert.ToInt32(ddltrangthai.SelectedValue)).Tables[0];
            grvtintuc.DataBind();
        }
        protected void ddldanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddata();
        }

        protected void grvtintuc_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvtintuc.PageIndex = e.NewPageIndex;
            loaddata();
        }

        protected void butthemmoi_Click1(object sender, EventArgs e)
        {
            Response.Redirect("./Admin_ThemTinTuc.aspx");
        }


        protected void butxoa2_Click(object sender, EventArgs e)
        {
            updatestt(0);
            loaddata();
        }

        protected void butsettop_Click1(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < grvtintuc.Rows.Count; i++)
            {
                GridViewRow objDataRow = grvtintuc.Rows[i];
                bool isChecked = ((CheckBox)objDataRow.FindControl("chkBox")).Checked;


                if (isChecked)
                {
                    dem++;

                    // updatestt ss

                    tt.insert_tinmoi(grvtintuc.Rows[i].Cells[1].Text);
                }

            }
            if (dem == 0)
            {
                Response.Write("<script language='javascript'>alert('" + "Chưa trọn đối tượng" + "')</script>");

                return;
            }
            else
            {

                Response.Write("<script language='javascript'>alert('" + "Set top thành công" + "')</script>");

            }

            loaddata();
        }

        protected void butchoduyet_Click1(object sender, EventArgs e)
        {
            updatestt(1);
            loaddata();
        }

        protected void butduyet_Click1(object sender, EventArgs e)
        {
            updatestt(2);
            loaddata();
        }

        protected void grvtintuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}