<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeBehind="QL_DonHang.aspx.cs" Inherits="Doan3_TK.QL_DonHang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 100%;">

        <div style="width: 100%; padding-top: 10px; padding-left: 10px; height: 30px">
            Trạng thái :
            <asp:DropDownList ID="ddltrangthai" runat="server" Height="24px" Width="173px" AutoPostBack="true" OnSelectedIndexChanged="ddltrangthai_SelectedIndexChanged">
            </asp:DropDownList>
        </div>
        <div style="width: 100%; padding-top: 10px; padding-left: 10px; height: 30px">
            &nbsp;&nbsp;
        </div>
        <div style="width: 99%; padding-top: 10px; padding-left: 10px">
            <asp:GridView ID="grvdonhang" runat="server" AutoGenerateColumns="False" Width="100%" CellPadding="4" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:CheckBox ID="chkAll" runat="server" AutoPostBack="true" />
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:CheckBox runat="server" ID="chkBox" />
                        </ItemTemplate>
                        <ItemStyle Width="3%" />
                    </asp:TemplateField>
                    <asp:BoundField DataField="MaGH" HeaderText="Mã giỏ hàng" />
                    <asp:BoundField DataField="NgayTao" HeaderText="Ngày tạo" />
                    <asp:BoundField DataField="HoTen" HeaderText="Khách hàng" />
                      <asp:BoundField DataField="SDT" HeaderText="SĐT" />
                      <asp:BoundField DataField="TongTien" HeaderText="Tổng tiền" />
                  
                    <asp:TemplateField>
                        <ItemTemplate>
                            <a href='./Admin_GioHangChitiet.aspx?ma=<%#Eval("MaGH")%>'>Chi tiết </a>

                        </ItemTemplate>
                        <HeaderStyle Width="5%" />
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
        </div>
        <div style="width: 100%; padding-top: 10px; padding-left: 10px; height: 30px">
            <asp:Button ID="butduyet" runat="server" Text="Duyệt" Width="100px" Style="height: 26px" OnClick="butduyet_Click" />
            &nbsp;&nbsp;&nbsp;
             &nbsp;&nbsp;&nbsp;
            
        </div>
    </div>
</asp:Content>
