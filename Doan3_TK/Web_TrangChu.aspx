<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Web_TrangChu.aspx.cs" Inherits="Doan3_TK.Web_TrangChu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/common_bh.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">


    <div id="Div1" role="main ">
        <p class="title-category">Sản phẩm mới nhất</p>
        <div class="box-sp-post-category">
            <div id="body" style="margin: auto;">
                <div class="bh-show-list">
                    <asp:Repeater ID="rptsanpham" runat="server">
                        <ItemTemplate>
                            <div class="bh-show-item" style="min-height: 470px">
                                <h3 class="h3-bh-show">
                                    <a href="./Web_ChiTietSP.aspx?ma=<%# Eval("idsp").ToString() %>"><%#Catxau( Eval("TenSP").ToString(),50) %></a>
                                </h3>
                                <p class="p-bh-show">
                                    <%# Catxau(Eval("GioiThieu").ToString(),100) %>
                                </p>
                                <a class="lnk-bh-img" href="./Web_ChiTietSP.aspx?ma=<%# Eval("idsp").ToString() %>" style="border: thin solid #fc00b9">
                                    <img src="  <%# Eval("HinhAnh").ToString() %>" />
                                </a>
                                <div class="price-bh">
                                    <p class="p-price-bh">

                                        <strong>Giá&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <%# Eval("GiaBan").ToString() %> VNĐ</strong>
                                    </p>
                                    <a class="btn-buy-bh" href="./Web_ChiTietSP.aspx?ma=<%# Eval("idsp").ToString() %>">Mua ngay
                                    </a>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>

            </div>
        </div>
    </div>
    <div id="content" role="main ">
        <p class="title-category">Bài viết mới nhất</p>

        <div class="box-sp-post-category">
            <asp:Repeater ID="rpttintop" runat="server">

                <ItemTemplate>
                    <div class="category-style3">
                        <article id="post-11312" class="list_news_item clearfix">

                            <div class="img_thumb">
                                <a href="./Web_TinChiTiet.aspx?ma=<%#( Eval("MaTin").ToString()) %>" title="<%#Catxau( Eval("tieude").ToString(),50) %>">
                                    <img width="311" height="292" src="<%#Eval("HinhAnh").ToString() %>" class="attachment-post-thumbnail wp-post-image">
                                </a>
                                &nbsp;
                            </div>
                            <h3>
                                <a href="./Web_TinChiTiet.aspx?ma=<%#( Eval("MaTin").ToString()) %>" title="<%#Catxau( Eval("tieude").ToString(),50) %>"><%#Catxau( Eval("tieude").ToString(),50) %></a>
                            </h3>
                            <div class="clear"></div>
                        </article>
                    </div>

                </ItemTemplate>
            </asp:Repeater>


        </div>
    </div>
</asp:Content>

