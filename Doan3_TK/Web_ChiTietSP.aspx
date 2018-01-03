<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Web_ChiTietSP.aspx.cs" Inherits="Doan3_TK.Web_ChiTietSP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <link href="css/not_home.css" rel="stylesheet" />
    <link href="css/common_bh.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <div id="content" class="site-content" role="main">
        <header class="archive-header">
            <h1 class="archive-title">Danh mục : <span>Sản phẩm</span></h1>

        </header>
        <div class="box-normal-post-category">
            <div class="body-bh-left">
                <h3 class="h3-detail-bh"><%= TenSP %>
                </h3>

                <div style="width: 100%">

                    <div style="width: 50%; float: left">
                        <img src="<%= HinhAnh %>" width="100%" />
                    </div>
                </div>
                <div style="width: 48%; float: right">
                    <p>

                        <strong>Giá : <%=GiaBan %> vnđ</strong>
                    </p>
                    <br />

                    <p style="font-style: italic">
                        <%= GioiThieu %>
                    </p>

                    <br />
                    <asp:Button ID="butmua" runat="server" Text="Thêm vào giỏ hàng" Height="51px" Width="280px" OnClick="butmua_Click" />

                </div>
                <div style="clear: both"></div>
                <p class="p-title-content">
                    Chi tiết
                </p>
                <div class="saleof-content">
                    <%=ChiTiet %>
                </div>
            </div>

            <div class="clear"></div>

            <div class="tab-related-post">
                <div class="related-post-item">
                    <p>Sản phẩm liên quan</p>
                    <ul>
                        <asp:Repeater ID="rpttinlienquan" runat="server">
                            <ItemTemplate>
                                <li><a href="./Web_ChiTietSP.aspx?ma=<%# Eval("idsp").ToString() %>"><%#catxau( Eval("tensp").ToString(),50) %></a></li>
                            </ItemTemplate>
                        </asp:Repeater>

                    </ul>
                </div>
                <div class="related-post-item">
                    <p>Mua nhiều nhất</p>
                    <ul>
                        <asp:Repeater ID="rpttixemnhieu" runat="server">
                            <ItemTemplate>
                                <li><a href="./Web_ChiTietSP.aspx?ma=<%# Eval("idsp").ToString() %>"><%#catxau( Eval("tensp").ToString(),50) %></a></li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
                <div class="clear"></div>
            </div>
        </div>


    </div>

    <div id="secondary" class="widget-area" role="complementary">
        <div class="clear"></div>
        <aside class="widget widget_text dich-vu-noi-bat-sidebar dich-vu-tam-trang-sidebar">
            <div class="textwidget">
                <ul>
                    <li class="the-post-id-11097"><a class="info" href="">Sản phẩm nổi bật</a></li>
                </ul>
            </div>
        </aside>
        <div class="clear"></div>
        <aside class="widget widget_text tin-tuc-lam-dep-sidebar">
            <div class="textwidget" style="margin-top: -25px;">
                <ul>
                    <asp:Repeater ID="rptmoi" runat="server">
                        <ItemTemplate>

                            <div class="bh-show-item" style="margin-top: 5px; width: 100%">
                                <h3 class="h3-bh-show">
                                    <a href="./Web_ChiTietSP.aspx?ma=<%# Eval("idsp").ToString() %>"><%# Eval("TenSP").ToString() %></a>
                                </h3>

                                <a href="./Web_ChiTietSP.aspx?ma=<%# Eval("idsp").ToString() %>" style="border: thin solid #fc00b9; width: 200px; height: 100px">
                                    <img src="  <%# Eval("HinhAnh").ToString() %>" style="border: thin solid #fc00b9; width: 300px; height: 200px" />
                                </a>
                                <div class="price-bh">
                                    <p class="p-price-bh">

                                        <strong>Giá&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<%# Eval("GiaBan").ToString() %>VNĐ</strong>
                                    </p>
                                    <a class="btn-buy-bh" href="./Web_ChiTietSP.aspx?ma=<%# Eval("idsp").ToString() %>">Mua ngay
                                    </a>
                                </div>

                            </div>
                        </ItemTemplate>
                    </asp:Repeater>

                </ul>
            </div>
        </aside>



        <div class="clear" style="padding-top: 30px"></div>


        <aside class="widget widget_text dich-vu-noi-bat-sidebar dich-vu-tam-trang-sidebar">
            <div class="textwidget">
                <ul>
                    <li class="the-post-id-11097"><a class="info">Tin tức mới</a></li>
                </ul>
            </div>
        </aside>

        <aside class="widget widget_text tin-tuc-lam-dep-sidebar">
            <div class="textwidget" style="margin-top: -25px">
                <ul>
                    <asp:Repeater ID="rpttinmoi" runat="server">
                        <ItemTemplate>
                            <div class="line-y-kien">
                                <a class="left-y-kien" href="./Web_TinChiTiet.aspx?ma=<%#catxau( Eval("MaTin").ToString(),50) %>" title="<%#catxau( Eval("TieuDe").ToString(),50) %>">
                                    <img width="311" height="292" src="<%#Eval("HinhAnh").ToString() %>" class="attachment-post-thumbnail wp-post-image" alt="<%#catxau( Eval("TieuDe").ToString(),50) %>"></a>
                                <div class="right-y-kien">
                                    <a href="./Web_TinChiTiet.aspx">
                                        <h3><%#catxau( Eval("TieuDe").ToString(),50) %></h3>
                                    </a>
                                    <p>B<%#catxau( Eval("MoTa").ToString(),50) %></p>
                                    <a class="readmore" href="./Web_TinChiTiet.aspx?ma=<%#catxau( Eval("MaTin").ToString(),50) %>">Xem thêm</a>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>


                </ul>
            </div>
        </aside>
        <div class="clear"></div>
    </div>
</asp:Content>

