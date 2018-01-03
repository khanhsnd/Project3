using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class cs_GioHang
{
    public cs_GioHang()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    // [dbo].[insert_giohang] 
    public string insert_giohang(string HoTen, string SDT, string CMT, string NgaySinh, string DiaChi, string NoiNhan, string Email, string GioiTinh, int SLSP, float TongTien)
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
            SqlDataAdapter da = new SqlDataAdapter("[dbo].[insert_giohang] N'" + HoTen + "',N'" + SDT + "',N'" + CMT + "',N'" + NgaySinh + "',N'" + DiaChi + "',N'" + NoiNhan + "',N'" + Email + "',N'" + GioiTinh + "'," + SLSP + "," + TongTien, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            cn.Close();

            try
            {
                if (ds != null)
                {

                    return ds.Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    return "0";
                }
            }
            catch
            {
                return "0";
            }
        }
        catch { cn.Close(); return "0"; }

    }
    
    public void insert_CT_giohang(int magh, int idsp, string tensp,int sl,float thanhtien)
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
            SqlCommand da = new SqlCommand("[dbo].[insert_ct_giohang] "+ magh+","+idsp+",N'"+tensp+"',"+sl+","+thanhtien, cn);
            da.ExecuteNonQuery();
            cn.Close();
        }
        catch { cn.Close();  }

    }
    public DataSet laytoanbo(int trangthai)
    {
        SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter("[dbo].[select_all_giohang] " + trangthai, cn);
        DataSet ds = new DataSet();
        da.Fill(ds);

        cn.Close();
        return ds;
    }
    public void insert_duyet_giohang(string magh, int MaND)
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
            SqlCommand da = new SqlCommand("[dbo].[insert_duyet_giohang] " + magh + "," + MaND, cn);
            da.ExecuteNonQuery();
            cn.Close();
        }
        catch { cn.Close(); }

    }


    public DataSet GioHangChiTiet(int magh)
    {
         SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter("[dbo].[select_giohang_chitiet] " + magh, cn);
        DataSet ds = new DataSet();
        da.Fill(ds);

        cn.Close();
        return ds;
    
    }
}
