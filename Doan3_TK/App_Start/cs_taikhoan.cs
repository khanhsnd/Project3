using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class cs_taikhoan
{

    // [dbo].[kiemtra_taikhoan] 'admin','123456'
    public cs_taikhoan()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public DataSet checktaikhoan(string tendn, string mk)
    {
        SqlConnection cn = new SqlConnection();
        string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
        cn.ConnectionString = strconnect;
        if (cn.State != ConnectionState.Open)
        {
            cn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter(" [dbo].[kiemtra_taikhoan] N'" + tendn+"',N'"+mk+"'", cn);
        DataSet ds = new DataSet();
        da.Fill(ds);

        cn.Close();
        return ds;
    }
}