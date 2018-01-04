using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Doan3_TK
{
    public partial class QL_SanPham : System.Web.UI.Page
    {
        cs_sanpham sp = new cs_sanpham();
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
                foreach (RepeaterItem row in rptData.Items)
                {
                    CheckBox chk = (CheckBox)row.FindControl("chkBox");
                    if (chk != null)
                        chk.Checked = chkAll.Checked;
                }
            }
        }
        //protected void updatestt(int stt)
        //{
        //    int dem = 0;
        //    for (int i = 0; i < grvsanpham.Rows.Count; i++)
        //    {
        //        GridViewRow objDataRow = grvsanpham.Rows[i];
        //        bool isChecked = ((CheckBox)objDataRow.FindControl("chkBox")).Checked;


        //        if (isChecked)
        //        {
        //            dem++;

                  
        //            sp.update_trangthai(grvsanpham.Rows[i].Cells[1].Text, stt);
        //        }

        //    }
        //    if (dem == 0)
        //    {
        //        Response.Write("<script language='javascript'>alert('" + "Chưa trọn đối tượng" + "')</script>");

        //        return;
        //    }
        //    else
        //    {

        //        Response.Write("<script language='javascript'>alert('" + "Cập nhât thành công" + "')</script>");

        //    }

        //}

        protected void loadcontrol()
        {

            ddldanhmuc.DataSource = dm.danhmucsp();
            ddldanhmuc.DataValueField = "madm";
            ddldanhmuc.DataTextField = "tendm";
            ddldanhmuc.DataBind();
            ddldanhmuc.Items.Insert(0, new ListItem("Tất cả", "-1"));

            ddltrangthai.Items.Insert(0, new ListItem("Đã duyệt", "2"));
            ddltrangthai.Items.Insert(1, new ListItem("Chờ duyệt", "1"));
            ddltrangthai.Items.Insert(2, new ListItem("Đã xóa", "0"));
            ddltrangthai.SelectedValue = "2";
        }
        protected void loaddata()
        {
            rptData.DataSource = sp.laytoanbosp(int.Parse(ddldanhmuc.SelectedValue), int.Parse(ddltrangthai.SelectedValue)).Tables[0];
            rptData.DataBind();
        }
        protected void ddldanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {

            loaddata();
        }

        protected void butxoa_Click(object sender, EventArgs e)
        {
            //updatestt(0);
            loaddata();
        }

       

        //protected void grvsanpham_PageIndexChanging(object sender, GridViewPageEventArgs e)
        //{
        //    grvsanpham.PageIndex = e.NewPageIndex;
        //    loaddata();
        //}

        protected void butthemmoi_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Admin_ThemSanPham.aspx");
        }

      

        protected void butduyet_Click(object sender, EventArgs e)
        {
            //updatestt(2);
            loaddata();
        }

        protected void butchoduyet_Click(object sender, EventArgs e)
        {
            //updatestt(1);
            loaddata();
        }

        protected void butsettop_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < rptData.Items.Count; i++)
            {
                RepeaterItem objDataRow = rptData.Items[i];
                bool isChecked = ((CheckBox)objDataRow.FindControl("chkBox")).Checked;


                if (isChecked)
                {
                    dem++;
                        HiddenField idsp = (HiddenField)rptData.Items[i].FindControl("idsp");
                        sp.insert_spnoibat(idsp.Value);
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


    }
}