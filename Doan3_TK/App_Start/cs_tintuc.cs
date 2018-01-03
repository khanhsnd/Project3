using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class cs_tintuc
{
    public cs_tintuc()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public DataSet laytttheodanhmuc(string madm, int trang)
    {
        SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter("[dbo].[select_tintuctheodanhmuc] " + madm +","+trang, cn);
        DataSet ds = new DataSet();
        da.Fill(ds);

        cn.Close();
        return ds;
    }
    public DataSet laytttheoma(string ma)
    {
        SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter("[dbo].[select_tintuc_chitiet] " + ma, cn);
        DataSet ds = new DataSet();
        da.Fill(ds);

        cn.Close();
        return ds;
    }
    public DataSet laytttheoma_admin(string ma)
    {
        SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter("[dbo].[select_tintuc_chitiet_admin] " + ma, cn);
        DataSet ds = new DataSet();
        da.Fill(ds);

        cn.Close();
        return ds;
    }
    public DataSet laytoanbott(string madm, int trangthai)
    {
        SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter("[dbo].[select_all_tt] " + madm + "," + trangthai, cn);
        DataSet ds = new DataSet();
        da.Fill(ds);

        cn.Close();
        return ds;
    }

    public void ThemMoi_SuaTinTuc(int MaTin, int MaDM, string TieuDe, string MoTa, string NoiDung, string HinhAnh, string NgayXB, int TrangThai, int NguoiTao)            
    {
        SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
       
            SqlCommand da = new SqlCommand("[dbo].[insert_update_tintuc] " + MaTin + "," + MaDM + ",N'" + TieuDe + "',N'" + MoTa + "',N'" + NoiDung + "',N'" + HinhAnh + "',N'" + NgayXB + "'," + TrangThai + "," + NguoiTao , cn);
            da.ExecuteNonQuery();
            cn.Close();
      
    }

    public void update_trangthai(string MaTin, int trangthai)
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

            SqlCommand da = new SqlCommand(" [dbo].[update_trangthai_tt]'" + MaTin + "'," + trangthai, cn);
            da.ExecuteNonQuery();
            cn.Close();
        }
        catch { cn.Close(); }
    }
    public void insert_tinmoi(string MaTin)
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

            SqlCommand da = new SqlCommand(" [dbo].[insert_tinnoibat]" + MaTin, cn);
            da.ExecuteNonQuery();
            cn.Close();
        }
        catch { cn.Close(); }
    }
}
