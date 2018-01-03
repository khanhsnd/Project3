using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class cs_danhmuc
{
    public cs_danhmuc()
    {

    }
    // lay bang : select
    public DataTable danhmuccha()
    {
        SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter("[dbo].[select_danhmucha]", cn);


        DataSet ds = new DataSet();
        da.Fill(ds);
        DataTable dt = new DataTable();
        dt = ds.Tables[0];
        cn.Close();
        return dt;
    }
    public DataTable danhmuccom(string ma)
    {
        SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter("[dbo].[select_danhmucon] " + ma + "", cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DataTable dt = new DataTable();
        dt = ds.Tables[0];
        cn.Close();
        return dt;
    }
    public DataTable danhmuctt()
    {
        SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter("[select_danhmuctt]", cn);


        DataSet ds = new DataSet();
        da.Fill(ds);
        DataTable dt = new DataTable();
        dt = ds.Tables[0];
        cn.Close();
        return dt;
    }
    public DataTable danhmucsp()
    {
        SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter("[select_danhmucsp]", cn);


        DataSet ds = new DataSet();
        da.Fill(ds);
        DataTable dt = new DataTable();
        dt = ds.Tables[0];
        cn.Close();
        return dt;
    }
 
    public DataSet laytoanbodm(string madm)
    {
        SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter("[dbo].[select_all_dm] " + madm, cn);
        DataSet ds = new DataSet();
        da.Fill(ds);

        cn.Close();
        return ds;
    }
    public DataSet laydmtheoma(string ma)
    {
        SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter("[dbo].[select_danhmuc_chitiet] " + ma, cn);
        DataSet ds = new DataSet();
        da.Fill(ds);

        cn.Close();
        return ds;
    }
    public void update_trangthai(string MaDM, int trangthai)
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

            SqlCommand da = new SqlCommand(" [dbo].[update_trangthai_dm]'" + MaDM + "'," + trangthai, cn);
            da.ExecuteNonQuery();
            cn.Close();
        }
        catch { cn.Close(); }
    }
    public void ThemMoi_SuaDanhMuc(int MaDM, int DMcha, string TenDM, string MoTa, int LoaiDM, int TrangThai)
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

            SqlCommand da = new SqlCommand("[dbo].[insert_update_danhmuc] " + MaDM + "," + DMcha + ",N'" + TenDM + "',N'" + MoTa + "'," + LoaiDM + "," + TrangThai , cn);
            da.ExecuteNonQuery();
            cn.Close();
        }
        catch { cn.Close(); }
    }

   
}