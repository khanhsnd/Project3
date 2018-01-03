using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class CS_CongCu
{
    public CS_CongCu()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string FomatTienHT(string TT)
    {
        int svt = 1;
        TT = fomatTienTT(TT).ToString();
        string tt = TT.ToString();
        svt = (tt.Length) / 3;
        if (tt.Length == svt * 3)
            svt = svt - 1;
        for (int i = 1; i <= svt; i++)
        {
            tt = tt.Insert(TT.ToString().Length - (i * 3), " ");
        }
        return tt;
    }
    public float fomatTienTT(string TT)
    {
        return float.Parse(TT.Replace(" ", ""));
    }

}
