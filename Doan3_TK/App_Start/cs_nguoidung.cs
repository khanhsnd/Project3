using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class cs_nguoidung
{
    public cs_nguoidung()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public DataSet layndtheoma(string ma)
    {
        SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter("[dbo].[select_nguoidung_chitiet] " + ma, cn);
        DataSet ds = new DataSet();
        da.Fill(ds);

        cn.Close();
        return ds;
    }
    public DataSet laytoanbond(string mand)
    {
        SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter("[dbo].[select_all_nd] " + mand, cn);
        DataSet ds = new DataSet();
        da.Fill(ds);

        cn.Close();
        return ds;
    }
    public void update_trangthai(string MaND, int trangthai)
    {
        SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
        try
        {

            SqlCommand da = new SqlCommand(" [dbo].[update_trangthai_nd]'" + MaND + "'," + trangthai, cn);
            da.ExecuteNonQuery();
            cn.Close();
        }
        catch { cn.Close(); }
    }
    public void ThemMoi_SuaNguoiDung(int MaND, string TenND, string GioiTinh, string SDT, string Email, string DiaChi, string NgaySinh, int TrangThai, string Avatar, int NhomQuyen)
    {
        SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
        try
        {

            SqlCommand da = new SqlCommand("[dbo].[insert_update_nguoidung] " + MaND + ", N'" + TenND + "',N'" + GioiTinh + "','" + SDT + "',N'" + Email + "',N'" + DiaChi + "',N'" + NgaySinh + "',N'" + Avatar + "'," + TrangThai + "," + NhomQuyen, cn);
            da.ExecuteNonQuery();
            cn.Close();
        }
        catch { cn.Close(); }
    }

}
