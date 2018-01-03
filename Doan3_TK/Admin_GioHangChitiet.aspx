<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeBehind="Admin_GioHangChitiet.aspx.cs" Inherits="Doan3_TK.Admin_GioHangChitiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style36 {
            height: 20px;
        }

        .auto-style37 {
            height: 77px;
        }

        .auto-style40 {
            height: 32px;
        }

        .auto-style42 {
            height: 26px;
        }

        .auto-style43 {
            height: 42px;
        }

        .auto-style44 {
            height: 30px;
        }

        .auto-style45 {
            width: 50%;
            height: 26px;
        }

        .auto-style46 {
            width: 506px;
            height: 26px;
        }

        .auto-style47 {
            height: 51px;
        }

        .auto-style48 {
            height: 34px;
        }
        .auto-style49 {
            width: 113px;
        }
        .auto-style50 {
            height: 30px;
            width: 113px;
        }
        .auto-style51 {
            height: 51px;
            width: 113px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1" style="min-height: 440px; width:80%">
        <tr>
            <td class="auto-style48" style="vertical-align: middle; text-align: center; color: #FFFFFF; font-size: 15pt; background-color: #333333; font-weight: bold;">&nbsp;THÔNG TIN NGƯỜI NHẬN HÀNG</td>
        </tr>
        <tr>
            <td class="auto-style37" style="padding: 0px">
                <table class="auto-style1" style="height: 274px; width: 100%; background-color: #CCCCCC">
                    <tr>
                        <td class="auto-style43" style="border-color: #990000; font-size: larger; padding: 0px color: #800000; border-bottom-style: solid; font-weight: bold; background-color: #999999;" colspan="2">Thông tin người mua :</td>
                    </tr>
                    <tr>
                        <td class="auto-style49" style="vertical-align: middle; text-align: right; background-color: #CCCCCC;">Họ Tên</td>
                        <td style="background-color: #CCCCCC; text-indent: 10px; text-align: left">
                            <asp:TextBox ID="txtTen" runat="server" Width="225px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style49" style="vertical-align: middle; text-align: right; background-color: #CCCCCC;">Số CMT</td>
                        <td class="auto-style40" style="background-color: #CCCCCC; text-indent: 10px; text-align: left">
                            <asp:TextBox ID="txtCMT" runat="server" Width="225px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style49" style="vertical-align: middle; text-align: right; background-color: #CCCCCC;">Giới Tính</td>
                        <td style="background-color: #CCCCCC; text-indent: 10px; text-align: left" class="auto-style42">
                            <asp:TextBox ID="txtgioitinh" runat="server" Width="225px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style49" style="vertical-align: middle; text-align: right; background-color: #CCCCCC;">Ngày Sinh</td>
                        <td style="background-color: #CCCCCC; text-indent: 10px; text-align: left">
                            <asp:TextBox ID="txtngaysinh" runat="server" Width="225px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td class="auto-style49" style="vertical-align: middle; text-align: right; background-color: #CCCCCC;">SĐT</td>
                        <td style="background-color: #CCCCCC; text-indent: 10px; text-align: left">
                            <asp:TextBox ID="txtSDT" runat="server" Width="225px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style49" style="vertical-align: middle; text-align: right; background-color: #CCCCCC;">Email</td>
                        <td style="background-color: #CCCCCC; text-indent: 10px; text-align: left">
                            <asp:TextBox ID="txtemail" runat="server" Width="225px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style50" style="vertical-align: middle; text-align: right; background-color: #CCCCCC;">Địa chỉ khách hàng </td>
                        <td style="background-color: #CCCCCC; text-indent: 10px; text-align: left" class="auto-style44">
                            <asp:TextBox ID="txtDiaChiKkhach" runat="server" Width="655px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style50" style="vertical-align: middle; text-align: right; background-color: #CCCCCC;">Địa chỉ nhận hàng </td>
                        <td style="background-color: #CCCCCC; text-indent: 10px; text-align: left" class="auto-style44">
                            <asp:TextBox ID="txtDiaChiNhan" runat="server" Width="655px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style51" style="vertical-align: middle; text-align: right; background-color: #CCCCCC;"></td>
                        <td style="background-color: #CCCCCC; text-indent: 10px;" class="auto-style47">

                            <asp:Button ID="butquayve" runat="server" Text="Quay về" Width="200px" Font-Bold="True" Font-Size="Large"  BackColor="Blue" ForeColor="White" Height="40px" OnClick="butquayve_Click"   />

                        </td>

                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td style="color: #FFFFFF">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            Chi tiết Giỏ hàng
                            :</td>
        </tr>
        <tr>
            <td>
                <table cellpadding="0" cellspacing="0" class="auto-style1" style="border: thin solid #FFFF00; margin: auto; height: 32px; width: 100%;">

                    <tr>
                        <td>
                            <asp:GridView ID="grvGioHang" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="IdSP" HeaderText="Mã sản phẩm">
                                        <FooterStyle Width="50px" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="TenSP" HeaderText="Tên sản phẩm">
                                        <FooterStyle Width="300px" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="GiaBan" HeaderText="Giá bán">
                                        <FooterStyle Width="150px" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="SL" HeaderText="Số lượng" />
                                    <asp:BoundField DataField="ThanhTien" HeaderText="Thành tiền" />
                                </Columns>
                                <HeaderStyle HorizontalAlign="Left" />
                                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                                <SortedDescendingHeaderStyle BackColor="#820000" />
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style36" style="color: #FFFFFF; background-color: #666666;">
                          
                            <table cellpadding="0" cellspacing="0" class="auto-style1">
                                <tr>
                                    <td class="auto-style45" style="text-align: right">
                                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="White" Text="Tổng Tiền"></asp:Label>
                                    </td>
                                    <td class="auto-style46" style="text-align: right">
                                        <asp:Label ID="lblTongTien" runat="server" Font-Size="Large" ForeColor="White"></asp:Label>
                                    </td>
                                    <td class="auto-style42" style="color: #FF0000">&nbsp;VNĐ</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
