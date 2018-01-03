<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Web_DanhMucSP.aspx.cs" Inherits="Doan3_TK.DanhMucSP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/common_bh.css" rel="stylesheet" />
    <style>
        .fRight, .pull-right {
            float: inherit;
        }

        .pagination {
            margin: 10px 0;
        }

            .pagination ul {
                display: inline-block;
                *display: inline;
                margin-bottom: 0;
                margin-left: 0;
                padding: 0px;
                -webkit-border-radius: 4px;
                -moz-border-radius: 4px;
                border-radius: 4px;
                *zoom: 1;
                -webkit-box-shadow: 0 1px 2px rgba(0, 0, 0, 0.05);
                -moz-box-shadow: 0 1px 2px rgba(0, 0, 0, 0.05);
                box-shadow: 0 1px 2px rgba(0, 0, 0, 0.05);
            }

                .pagination ul > li {
                    display: inline;
                }

                    .pagination ul > li > a,
                    .pagination ul > li > span {
                        float: left;
                        padding: 4px 12px;
                        line-height: 20px;
                        text-decoration: none;
                        background-color: #ffffff;
                        border: 1px solid #dddddd;
                        border-left-width: 0;
                    }

                        .pagination ul > li > a:hover,
                        .pagination ul > li > a:focus,
                        .pagination ul > .active > a,
                        .pagination ul > .active > span {
                            background-color: #f5f5f5;
                        }

                .pagination ul > .active > a,
                .pagination ul > .active > span {
                    color: #999999;
                    cursor: default;
                }

                .pagination ul > .disabled > span,
                .pagination ul > .disabled > a,
                .pagination ul > .disabled > a:hover,
                .pagination ul > .disabled > a:focus {
                    color: #999999;
                    cursor: default;
                    background-color: transparent;
                }

                .pagination ul > li:first-child > a,
                .pagination ul > li:first-child > span {
                    border-left-width: 1px;
                    -webkit-border-bottom-left-radius: 4px;
                    border-bottom-left-radius: 4px;
                    -webkit-border-top-left-radius: 4px;
                    border-top-left-radius: 4px;
                    -moz-border-radius-bottomleft: 4px;
                    -moz-border-radius-topleft: 4px;
                }

                .pagination ul > li:last-child > a,
                .pagination ul > li:last-child > span {
                    -webkit-border-top-right-radius: 4px;
                    border-top-right-radius: 4px;
                    -webkit-border-bottom-right-radius: 4px;
                    border-bottom-right-radius: 4px;
                    -moz-border-radius-topright: 4px;
                    -moz-border-radius-bottomright: 4px;
                }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">


    <div id="Div1" role="main ">
        <p class="title-category">Sản phẩm mới nhất</p>
        <div class="box-sp-post-category">
            <div id="body" style="margin: auto;">

                <div class="bh-show-list">
                    <asp:Repeater ID="rptsp" runat="server">
                        <ItemTemplate>
                            <div class="bh-show-item" style="min-height: 470px">
                                <h3 class="h3-bh-show">
                                    <a href="./Web_ChiTietSP.aspx?ma=<%#Eval("idsp").ToString() %>"><%#catxau(Eval("TenSP").ToString(),50) %></a>
                                </h3>
                                <p class="p-bh-show">
                                    <%#catxau(Eval("GioiThieu").ToString(),100) %>
                                </p>
                                <a class="lnk-bh-img" href="./Web_ChiTietSP.aspx?ma=<%#Eval("idsp").ToString() %>" style="border: thin solid #fc00b9">
                                    <img src="<%#Eval("HinhAnh").ToString() %>" />
                                </a>
                                <div class="price-bh">
                                    <p class="p-price-bh">

                                        <strong>Giá&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<%#Eval("GiaBan").ToString() %> VNĐ</strong>
                                    </p>
                                    <a class="btn-buy-bh" href="./Web_ChiTietSP.aspx?ma=<%#Eval("idsp").ToString() %>">Mua ngay
                                    </a>
                                </div>

                            </div>
                        </ItemTemplate>
                    </asp:Repeater>



                </div>
                <div class="pagination " style="width: 100%">
                    <ul class="fRight">


                        <%if (page > 1)
                          {%>
                        <li><a rel="nofollow" href="./Web_DanhMucSP.aspx?ma=<%=madm %>&page=<%=page-1 %>">«Trước</a></li>
                        <%} %>
                        <%
                            if (TotalPage > 1)
                            {
                                int frompage = 1; int topage = 6;
                                if (page - 1 > 3)
                                    frompage = page - 2;
                                else
                                    frompage = 1;
                                topage = frompage + 4;

                                if (topage > TotalPage)
                                    topage = TotalPage;

                                for (int i = frompage; i <= topage; i++)
                                {%>
                        <% string s = "";
                           if (i == page)
                           {%>
                        <li class="active"><a rel="nofollow" href="./Web_DanhMucSP.aspx?ma=<%=madm %>&page=<%=i%>">
                            <%=Server.HtmlEncode(i.ToString())%></a></li>
                        <%}
                           else
                           { %>
                        <li><a rel="nofollow" href="./Web_DanhMucSP.aspx?ma=<%=madm %>&page=<%=i %>">
                            <%=Server.HtmlEncode(i.ToString())%></a></li>
                        <%} %>
                        <%} %>
                        <%if (TotalPage - page > 1)
                          {%>
                        <li><a rel="nofollow" title="" href="./Web_DanhMucSP.aspx?ma=<%=madm %>&page=<%=page+1 %>">Sau»</a></li>
                        <%} %>
                        <%}%>
                    </ul>
                    <div class="clearfix">
                    </div>
                </div>


            </div>
        </div>
    </div>
</asp:Content>

