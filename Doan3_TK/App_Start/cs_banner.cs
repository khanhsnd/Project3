using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

    public class cs_banner
    {
        public cs_banner()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public DataSet laybntheoma(string ma)
        {
            SqlConnection cn = new SqlConnection();
            string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
            cn.ConnectionString = strconnect;
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter("[dbo].[select_banner_chitiet] " + ma, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            cn.Close();
            return ds;
        }
        public DataSet laytoanbobn( int trangthai)
        {
            SqlConnection cn = new SqlConnection();
            string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
            cn.ConnectionString = strconnect;
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter("[dbo].[select_all_bn] " + trangthai, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            cn.Close();
            return ds;
        }


        public void ThemMoi_SuaBanner(int Ma, string TieuDe, string Link, string HinhAnh, int TrangThai)
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

                SqlCommand da = new SqlCommand("[dbo].[insert_update_banner] " + Ma + ",N'" + TieuDe + "',N'" + Link + "',N'" + HinhAnh + "'," + TrangThai, cn);
                da.ExecuteNonQuery();
                cn.Close();
            }
            catch { cn.Close(); }
        }

        public void update_trangthai(string ma, int trangthai)
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

                SqlCommand da = new SqlCommand(" [dbo].[update_trangthai_bn]'" + ma + "'," + trangthai, cn);
                da.ExecuteNonQuery();
                cn.Close();
            }
            catch { cn.Close(); }
        }
    }
