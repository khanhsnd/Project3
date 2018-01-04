using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class cs_sanpham
{
    public cs_sanpham()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public DataSet laysptheodanhmuc(string madm, string page)
    {
        SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter("[dbo].[select_sanphamtheodanhmuc] " + madm +","+page, cn);
        DataSet ds = new DataSet();
        da.Fill(ds);

        cn.Close();
        return ds;
    }
    public DataSet laysptheoma(string ma)
    {
        SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter("[dbo].[select_sanpham_chitiet] " + ma, cn);
        DataSet ds = new DataSet();
        da.Fill(ds);

        cn.Close();
        return ds;
    }
      public DataSet laysptheoma_admin(string ma)
    {
        SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter("[dbo].[select_sanpham_chitiet_admin] " + ma, cn);
        DataSet ds = new DataSet();
        da.Fill(ds);

        cn.Close();
        return ds;
    }
    
    public DataSet laytoanbosp(int madm, int trangthai)
    {
        SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter("[dbo].[select_all_sp] " + madm + "," + trangthai, cn);
        DataSet ds = new DataSet();
        da.Fill(ds);

        cn.Close();
        return ds;
    }
    public void ThemMoi_SuaSanPham(int idsp, string MaSP ,string TenSP,string GioiThieu,string ChiTiet, string HinhAnh, double GiaBan , int TrangThai ,int MaDM, int NguoiTao, int SL )
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

            SqlCommand da = new SqlCommand("[dbo].[insert_update_sanpham]  "+ idsp+",N'" + MaSP + "',N'" + TenSP + "',N'" + GioiThieu + "',N'" + ChiTiet + "',N'" + HinhAnh + "'," + GiaBan + "," + TrangThai + "," + MaDM + "," + NguoiTao + "," + SL , cn);
            da.ExecuteNonQuery();
            cn.Close();
        }
        catch { cn.Close(); }
    }

    public void update_trangthai( string idsp ,int trangthai )
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

            SqlCommand da = new SqlCommand(" [dbo].[update_trangthai]'" + idsp + "'," + trangthai, cn);
            da.ExecuteNonQuery();
            cn.Close();
        }
        catch { cn.Close(); }
    }
      public void insert_spnoibat( string MaSP  )
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

            SqlCommand da = new SqlCommand(" [dbo].[insert_spnoibat]" + MaSP , cn);
            da.ExecuteNonQuery();
            cn.Close();
        }
        catch { cn.Close(); }
    }
   
}
