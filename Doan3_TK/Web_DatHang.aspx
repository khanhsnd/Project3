<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Web_DatHang.aspx.cs" Inherits="Doan3_TK.Web_DatHang" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>

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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="auto-style1" style="min-height: 440px">
        <tr>
            <td class="auto-style48" style="vertical-align: middle; text-align: center; color: #FFFFFF; font-size: 15pt; background-color: #333333; font-weight: bold;">XÁC NHẬN GIỎ HÀNG VÀ THÔNG TIN NGƯỜI NHẬN HÀNG</td>
        </tr>
        <tr>
            <td class="auto-style37" style="padding:0px">
                <table class="auto-style1" style="height: 274px;width:100%; background-color: #CCCCCC">
                    <tr>
                        <td class="auto-style43" style="border-color: #990000; font-size: larger; padding:0px color: #800000; border-bottom-style: solid; font-weight: bold; background-color: #999999;" colspan="2">Thông tin người mua :</td>
                    </tr>
                    <tr>
                        <td class="auto-style38" style="vertical-align: middle; text-align: right; background-color: #CCCCCC;">Họ Tên</td>
                        <td style="background-color: #CCCCCC; text-indent: 10px;text-align:left">
                            <asp:TextBox ID="txtTen" runat="server" Width="225px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style39" style="vertical-align: middle; text-align: right; background-color: #CCCCCC;">Số CMT</td>
                        <td class="auto-style40" style="background-color: #CCCCCC; text-indent: 10px;text-align:left">
                            <asp:TextBox ID="txtCMT" runat="server" Width="225px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style41" style="vertical-align: middle; text-align: right; background-color: #CCCCCC;">Giới Tính</td>
                        <td style="background-color: #CCCCCC; text-indent: 10px; text-align:left" class="auto-style42">
                            <asp:DropDownList ID="ddGioiTinh" runat="server" Height="22px" Width="92px">
                                <asp:ListItem>Giới Tính</asp:ListItem>
                                <asp:ListItem>Nam</asp:ListItem>
                                <asp:ListItem>Nữ</asp:ListItem>
                                <asp:ListItem></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style38" style="vertical-align: middle; text-align: right; background-color: #CCCCCC;">Ngày Sinh</td>
                        <td style="background-color: #CCCCCC; text-indent: 10px;text-align:left">
                            <asp:DropDownList ID="ddNgay" runat="server">
                                <asp:ListItem>01</asp:ListItem>
                                <asp:ListItem>02</asp:ListItem>
                                <asp:ListItem>03</asp:ListItem>
                                <asp:ListItem>04</asp:ListItem>
                                <asp:ListItem>05</asp:ListItem>
                                <asp:ListItem>06</asp:ListItem>
                                <asp:ListItem>07</asp:ListItem>
                                <asp:ListItem>08</asp:ListItem>
                                <asp:ListItem>09</asp:ListItem>
                                <asp:ListItem>10</asp:ListItem>
                                <asp:ListItem>11</asp:ListItem>
                                <asp:ListItem>12</asp:ListItem>
                                <asp:ListItem>13</asp:ListItem>
                                <asp:ListItem>14</asp:ListItem>
                                <asp:ListItem>15</asp:ListItem>
                                <asp:ListItem>16</asp:ListItem>
                                <asp:ListItem>17</asp:ListItem>
                                <asp:ListItem>18</asp:ListItem>
                                <asp:ListItem>19</asp:ListItem>
                                <asp:ListItem>20</asp:ListItem>
                                <asp:ListItem>21</asp:ListItem>
                                <asp:ListItem>22</asp:ListItem>
                                <asp:ListItem>23</asp:ListItem>
                                <asp:ListItem>24</asp:ListItem>
                                <asp:ListItem>25</asp:ListItem>
                                <asp:ListItem>26</asp:ListItem>
                                <asp:ListItem>27</asp:ListItem>
                                <asp:ListItem>28</asp:ListItem>
                                <asp:ListItem>29</asp:ListItem>
                                <asp:ListItem>30</asp:ListItem>
                                <asp:ListItem>31</asp:ListItem>
                            </asp:DropDownList>
                            <asp:DropDownList ID="ddThang" runat="server">
                                <asp:ListItem>01</asp:ListItem>
                                <asp:ListItem>02</asp:ListItem>
                                <asp:ListItem>03</asp:ListItem>
                                <asp:ListItem>04</asp:ListItem>
                                <asp:ListItem>05</asp:ListItem>
                                <asp:ListItem>06</asp:ListItem>
                                <asp:ListItem>07</asp:ListItem>
                                <asp:ListItem>08</asp:ListItem>
                                <asp:ListItem>09</asp:ListItem>
                                <asp:ListItem>10</asp:ListItem>
                                <asp:ListItem>11</asp:ListItem>
                                <asp:ListItem>12</asp:ListItem>
                            </asp:DropDownList>
                            <asp:DropDownList ID="ddNam" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>

                    <tr>
                        <td class="auto-style38" style="vertical-align: middle; text-align: right; background-color: #CCCCCC;">SĐT</td>
                        <td style="background-color: #CCCCCC; text-indent: 10px;text-align:left">
                            <asp:TextBox ID="txtSDT" runat="server" Width="225px"></asp:TextBox>
                        </td>
                    </tr>
                     <tr>
                        <td class="auto-style38" style="vertical-align: middle; text-align: right; background-color: #CCCCCC;">Email</td>
                        <td style="background-color: #CCCCCC; text-indent: 10px;text-align:left">
                            <asp:TextBox ID="txtemail" runat="server" Width="225px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style44" style="vertical-align: middle; text-align: right; background-color: #CCCCCC;">Địa chỉ khách hàng </td>
                        <td style="background-color: #CCCCCC; text-indent: 10px;text-align:left" class="auto-style44">
                            <asp:TextBox ID="txtDiaChiKkhach" runat="server" Width="655px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style44" style="vertical-align: middle; text-align: right; background-color: #CCCCCC;">Địa chỉ nhận hàng </td>
                        <td style="background-color: #CCCCCC; text-indent: 10px;text-align:left" class="auto-style44">
                            <asp:TextBox ID="txtDiaChiNhan" runat="server" Width="655px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style47" style="vertical-align: middle; text-align: right; background-color: #CCCCCC;"></td>
                        <td style="background-color: #CCCCCC; text-indent: 10px; " class="auto-style47">

                            <asp:Button ID="butGuiDonHang" runat="server" Text="Gửi đơn hàng" Width="200px" Font-Bold="True" Font-Size="Large" ForeColor="White" Height="40px" OnClick="butGuiDonHang_Click"  />

                            <%-- <asp:ConfirmButtonExtender ID="ConfirmButtonExtender" ConfirmText="Bạn có muốn đặt hàng thật không ?" TargetControlID="butGuiDonHang" runat="server">
                             </asp:ConfirmButtonExtender>--%>
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
                            <%-- <table cellpadding="0" cellspacing="0" class="auto-style36" style="height: 33px; width: 100%;">
                                <tr>
                                    <td  style="text-align: right; vertical-align: bottom;" class="auto-style49">
                                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="White" Text="Tổng Tiền"></asp:Label>
                                    </td>
                                    <td  style="text-align: right; vertical-align: bottom;" class="auto-style48" >
                                        <asp:Label ID="lblTongTien" runat="server" Font-Size="Large" Text=""></asp:Label>
                                    </td>
                                    <td style="text-indent: 5px; font-size: large; color: #FF0000; vertical-align: bottom;">&nbsp;VNĐ</td>
                                </tr>
                            </table>--%>
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
