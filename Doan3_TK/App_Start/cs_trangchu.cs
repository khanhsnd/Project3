using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

    public class cs_trangchu
    {
        public cs_trangchu()
        {

        }
        public DataSet top8sp_top6tt()
        {
            SqlConnection cn = new SqlConnection();
            string strconnect = ConfigurationManager.ConnectionStrings["strconnect"].ConnectionString;
            cn.ConnectionString = strconnect;
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter("[dbo].[select_top_trangchu]", cn);


            DataSet ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            return ds;
        }
    }
