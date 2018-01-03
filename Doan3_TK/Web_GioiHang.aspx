<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Web_GioiHang.aspx.cs" Inherits="Doan3_TK.Web_GioiHang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <style type="text/css">
                .bg-popup-bh {
                    background: rgba(0, 0, 0, 0.5) none repeat scroll 0 0;
                    height: 100%;
                    left: 0;
                    top: 0;
                    width: 100%;
                    z-index: 9999;
                }

                .popup-bh-content {
                    background: #ffffff none repeat scroll 0 0;
                    position: relative;
                    z-index: 99999;
                    color: #303030;
                    font-size: 18px;
                    padding: 10px 0;
                    width: 100%;
                    position: relative;
                    min-height:500px;
                }

                .popup-bh-title {
                    color: #1abc9c;
                    font-size: 18px;
                    font-weight: normal;
                    padding-left: 15px;
                }

                .wrap-bh-content {
                    border: 1px solid #e1e1e1;
                    margin: 10px;
                    
                }

                .tab-header-bh {
                    border-bottom: 1px solid #e1e1e1;
                    color: #303030;
                    font-size: 18px;
                    margin-bottom: 15px;
                    overflow: hidden;
                    padding: 10px 0;
                }

                .sp-bh-column1 {
                    float: left;
                    padding-left: 10px;
                    width: 400px;
                }

                .sp-bh-column2 {
                    float: left;
                    margin-left: 15px;
                    text-align: center;
                    width: 135px;
                }

                .sp-bh-column3 {
                    float: left;
                    width: 100px;
                }

                .sp-bh-column4 {
                    float: left;
                    text-align: center;
                    width: 110px;
                }

                .bh-content-item {
                    margin-bottom: 15px;
                    overflow: hidden;
                }

                .bh-column1 {
                    float: left;
                    width: 410px;
                }

                .img-bh-item {
                    float: left;
                    height: 87px;
                    margin-left: 10px;
                    width: 155px;
                }

                .bh-column1-right {
                    margin-left: 180px;
                }

                .bh-column1-content {
                }

                .bh-column1-delete a {
                    border: 1px solid #e1e1e1;
                    color: #303030;
                    float: right;
                    padding: 3px 14px;
                }

                .bh-column1-delete span {
                }

                .bh-column1-delete {
                    margin-top: 10px;
                    overflow: hidden;
                }

                .bh-column2 {
                    float: left;
                    line-height: 25px;
                    margin-left: 15px;
                    text-align: center;
                    width: 135px;
                }

                .bh-price-new {
                    color: #ed5a19;
                    display: block;
                    font-size: 21px;
                    font-weight: normal;
                }

                .bh-price-old {
                    display: block;
                    text-decoration: line-through;
                }

                .bh-price-sale {
                    display: block;
                }

                .bh-column3 {
                    float: left;
                    margin-left: 15px;
                    width: 100px;
                }

                    .bh-column3 select {
                        width: 50px;
                    }

                .bh-column4 {
                    float: left;
                    width: 150px;
                }

                .sp-price-total {
                    color: #ed5a19;
                    display: block;
                    font-size: 21px;
                    font-weight: normal;
                }

                .p-total-price-vat {
                    color: #9e9e9e;
                    font-size: 16px;
                    padding-right: 20px;
                    text-align: right;
                }

                    .p-total-price-vat strong {
                        color: #ed5a19;
                        font-size: 21px;
                        font-weight: normal;
                    }

                .bh-bottom-btn {
                    margin-top: 20px;
                    overflow: hidden;
                    padding: 0 20px;
                }

                    .bh-bottom-btn .bh-lnk-other {
                        background: rgba(0, 0, 0, 0) url("../images/bh_new_other.png") no-repeat scroll left center;
                        color: #1abc9c;
                        float: left;
                        padding-left: 17px;
                    }

                    .bh-bottom-btn .bh-lnk-btn {
                        background: #1abc9c none repeat scroll 0 0;
                        border-radius: 8px;
                        color: #ffffff;
                        float: right;
                        padding: 5px 15px;
                    }

                .wrap-bh-item {
                    height: 275px;
                    overflow: auto;
                }

                .wrap-bh-hospital {
                    overflow: hidden;
                    margin-top: 10px;
                }

                .img-bh-hospital {
                    float: left;
                    height: 87px;
                    margin-left: 10px;
                    width: 155px;
                }

                .bh-hospital-right {
                    margin-left: 180px;
                    padding-right: 15px;
                }

                .hospital-right-item {
                    border-bottom: 1px solid #e1e1e1;
                    margin-bottom: 10px;
                    padding-bottom: 10px;
                }

                    .hospital-right-item h3 {
                        font-size: 18px;
                        font-weight: normal;
                        margin-bottom: 5px;
                    }

                    .hospital-right-item p {
                        color: #303030;
                        font-size: 16px;
                        line-height: 20px;
                    }

                .close-bh-popup {
                    position: absolute;
                    right: 10px;
                    top: 6px;
                }
            </style>
            <div class="popup-bh-content" >
                <h2 class="popup-bh-title"><%=Thongbao %>
                </h2>
                <div class="wrap-bh-content">
                    <asp:GridView ID="grvGioHang" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" OnSelectedIndexChanged="grvGioHang_SelectedIndexChanged" Style="margin-right: 0px">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="IdSP" HeaderText="Mã sản phẩm">

                                <FooterStyle Width="50px" />
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle BorderStyle="None" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>
                            <asp:BoundField DataField="TenSP" HeaderText="Tên sản phẩm">
                                <FooterStyle Width="300px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="GiaBan" HeaderText="Giá bán">
                                <FooterStyle Width="150px" />
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="Số Lượng">

                                <ItemTemplate>
                                    <asp:TextBox ID="txtSL" runat="server" Height="17px" Text='<%# Eval("SL") %>' TextMode="SingleLine" Width="115px" AutoPostBack="false"></asp:TextBox>
                                </ItemTemplate>
                                <FooterStyle Width="50px" />
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="Thành tiền" DataField="ThanhTien" />
                        </Columns>
                        <HeaderStyle HorizontalAlign="Left" />
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#800080" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                        <SortedAscendingCellStyle BackColor="#FDF5AC" />
                        <SortedAscendingHeaderStyle BackColor="#4D0000" />
                        <SortedDescendingCellStyle BackColor="#FCF6C0" />
                        <SortedDescendingHeaderStyle BackColor="#820000" />
                    </asp:GridView>
                </div>
                <p class="p-total-price-vat">
                    <strong><%=lblTongTien %></strong>
                </p>

                <div style="height: 28px; margin-top: 0px; vertical-align: middle; text-align: right;">
                    <asp:Button ID="butCapNhap" runat="server" Text="Cập nhập" OnClick="butCapNhap_Click" />
                    
                    <asp:Button ID="butmuahang" runat="server" Text="Đặt hàng" OnClick="butmuahang_Click" />
                    <asp:Button ID="buthuy" runat="server" Text="Hủy" />
                </div>
                <div class="bh-bottom-btn">
                    <a class="bh-lnk-other" href="./web_trangchu.aspx">Thêm sản phẩm
                    khác vào giỏ hàng</a>
                    <div>

                        <%-- <a class="bh-lnk-btn" href="./thanh-toan-goi-kham-chua-benh.html"><%=butname %></a>--%>
                    </div>

                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
