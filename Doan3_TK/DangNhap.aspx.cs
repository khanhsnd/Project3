using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Doan3_TK
{
    public partial class DangNhap : System.Web.UI.Page
    {
        cs_taikhoan tk = new cs_taikhoan();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void butDangNhap_Click(object sender, EventArgs e)
        {

            if (txtDN.Text.Length < 1)
            {
                TB.Text = "Chưa có tên đăng nhập";
                goto END;
            }
            if (txtMK.Text.Length < 1)
            {
                TB.Text = "Chưa có mật khẩu đăng nhập";
                goto END;
            }

            DataSet ds = new DataSet();
            ds = tk.checktaikhoan(txtDN.Text, txtMK.Text);
            if (ds == null)
            {
                TB.Text = "Tên đăng nhạp hoặc mật khẩu không đúng!";
                goto END;
            }
            else
            {
                try
                {
                    Session["TenTK"] = txtDN.Text;
                    Session["TK"] = ds.Tables[0].Rows[0]["MaNG"].ToString();
                    Session["HoTen"] = ds.Tables[0].Rows[0]["HoTen"].ToString();
                    Session["Quyen"] = ds.Tables[0].Rows[0]["NhomQuyen"].ToString();
                    Response.Redirect("./QL_SanPham.aspx");
                }
                catch { }
            }


        END:
            { }
        }
    }
}