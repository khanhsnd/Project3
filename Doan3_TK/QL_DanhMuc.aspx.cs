using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Doan3_TK
{
    public partial class QL_DanhMuc : System.Web.UI.Page
    {
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
                foreach (GridViewRow row in grvdanhmuc.Rows)
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
            for (int i = 0; i < grvdanhmuc.Rows.Count; i++)
            {
                GridViewRow objDataRow = grvdanhmuc.Rows[i];
                bool isChecked = ((CheckBox)objDataRow.FindControl("chkBox")).Checked;


                if (isChecked)
                {
                    dem++;

                    // updatestt ss
                    //      paras[0].Value = Convert.ToInt32(dgvlisttintuc.Rows[i].Cells[1].Text);
                    dm.update_trangthai(grvdanhmuc.Rows[i].Cells[1].Text, stt);
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



            ddltrangthai1.Items.Insert(0, new ListItem("Đã duyệt", "2"));
            ddltrangthai1.Items.Insert(1, new ListItem("Chờ duyệt", "1"));
            ddltrangthai1.Items.Insert(2, new ListItem("Cấm", "0"));
            ddltrangthai1.SelectedValue = "2";
        }
        protected void loaddata()
        {
            grvdanhmuc.DataSource = dm.laytoanbodm(ddltrangthai1.SelectedValue).Tables[0];
            grvdanhmuc.DataBind();
        }
        protected void ddltrangthai1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddata();
        }
        protected void grvdanhmuc_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvdanhmuc.PageIndex = e.NewPageIndex;
            loaddata();
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

        //protected void butsettop_Click(object sender, EventArgs e)
        //{
        //    int dem = 0;
        //    for (int i = 0; i < grvdanhmuc.Rows.Count; i++)
        //    {
        //        GridViewRow objDataRow = grvdanhmuc.Rows[i];
        //        bool isChecked = ((CheckBox)objDataRow.FindControl("chkBox")).Checked;


        //        if (isChecked)
        //        {
        //            dem++;

        //            // updatestt ss

        //            dm.insert_dmnoibat(grvdanhmuc.Rows[i].Cells[1].Text);
        //        }

        //    }
        //    if (dem == 0)
        //    {
        //        Response.Write("<script language='javascript'>alert('" + "Chưa trọn đối tượng" + "')</script>");

        //        return;
        //    }
        //    else
        //    {

        //        Response.Write("<script language='javascript'>alert('" + "Set top thành công" + "')</script>");

        //    }

        //    loaddata();
        //}

        protected void butxoa2_Click(object sender, EventArgs e)
        {
            updatestt(0);
            loaddata();
        }

        protected void butthemmoi_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Admin_ThemDanhMuc.aspx");
        }
    }
}