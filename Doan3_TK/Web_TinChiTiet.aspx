<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Web_TinChiTiet.aspx.cs" Inherits="Doan3_TK.Web_TinChiTiet_aspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/not_home.css" rel="stylesheet" />
    <link href="css/common_bh.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div id="content" role="main" style="max-width: 650px; float: left">
        <%--   style="max-width: 68%; margin: auto; float: left"--%>
        <article id="post-9852" class="post-9852 post type-post status-publish format-standard hentry category-khuyen-mai tag-cach-tri-mun-tai-nha">
            <header class="entry-header">
                <h1 class="entry-title"><span class="border-inner"></span><span class="icon-title"><%=TieuDe %></span></h1>
            </header>
            <div class="clear"></div>
            <div class="entry-content">

                <h2 style="text-align: justify;"><strong><em><%=MoTa %></em></strong></h2>
                <%=NoiDung %>
            </div>

        </article>

        <script src="./Images/process.js" type="text/javascript"></script>


        <div class="clear"></div>

        <div class="tab-related-post">
            <div class="related-post-item">
                <p>Tin liên quan</p>
                <ul>
                    <asp:Repeater ID="rpttinlienquan" runat="server">
                        <ItemTemplate>
                            <li><a href="./Web_TinChiTiet.aspx?ma=<%# Eval("MaTin").ToString() %>"><%#catxau( Eval("TieuDe").ToString(),50) %></a></li>
                        </ItemTemplate>
                    </asp:Repeater>


                </ul>
            </div>
            <div class="related-post-item">
                <p>Xem nhiều nhất</p>
                <ul>
                    <asp:Repeater ID="rpttixemnhieu" runat="server">
                        <ItemTemplate>
                            <li><a href="./Web_TinChiTiet.aspx?ma=<%# Eval("MaTin").ToString() %>"><%#catxau( Eval("TieuDe").ToString(),50) %></a></li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>
            <div class="clear"></div>
        </div>
    </div>
    <div id="secondary" class="widget-area" role="complementary">
        <div class="clear"></div>
        <aside class="widget widget_text dich-vu-noi-bat-sidebar dich-vu-tam-trang-sidebar">
            <div class="textwidget">
                <ul>
                    <li class="the-post-id-11097"><a class="info" href="">Tin tức nổi bật</a></li>
                </ul>
            </div>
        </aside>
        <div class="clear"></div>
        <aside class="widget widget_text tin-tuc-lam-dep-sidebar">
            <div class="textwidget" style="margin-top: -25px;">
                <ul>
                    <asp:Repeater ID="rpttin" runat="server">
                        <ItemTemplate>
                            <div class="line-y-kien">
                                <a class="left-y-kien" href="./Web_TinChiTiet.aspx?ma=<%# Eval("MaTin").ToString() %>" title="<%#catxau( Eval("TieuDe").ToString(),50) %>">
                                    <img width="311" height="292" src="<%# Eval("HinhAnh").ToString() %>" class="attachment-post-thumbnail wp-post-image" alt="<%#catxau( Eval("TieuDe").ToString(),50) %>"></a>
                                <div class="right-y-kien">
                                    <a href="./Web_TinChiTiet.aspx?ma=<%# Eval("MaTin").ToString() %>">
                                        <h3><%#catxau( Eval("TieuDe").ToString(),50) %></h3>
                                    </a>
                                    <p>B<%#catxau( Eval("MoTa").ToString(),50) %></p>
                                    <a class="readmore" href="./Web_TinChiTiet.aspx?ma=<%# Eval("MaTin").ToString() %>">Xem thêm</a>
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
                    <li class="the-post-id-11097"><a class="info">Sản phẩm mới</a></li>
                </ul>
            </div>
        </aside>

        <aside class="widget widget_text tin-tuc-lam-dep-sidebar">
            <div class="textwidget" style="margin-top: -25px">
                <ul>
                    <asp:Repeater ID="rptspm" runat="server">
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
        <div class="clear"></div>
    </div>


</asp:Content>

