<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeBehind="QL_NguoiDung.aspx.cs" Inherits="Doan3_TK.QL_NguoiDung" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 100%;">
        <div style="width: 100%; padding-top: 10px; padding-left: 10px; height: 30px">
            Danh sách người dùng
        </div>
        <div style="width: 100%; padding-top: 10px; padding-left: 10px; height: 30px">
          
            Trạng thái :
            <asp:DropDownList ID="ddltrangthai" runat="server" Height="24px" Width="173px" AutoPostBack="true" OnSelectedIndexChanged="ddltrangthai_SelectedIndexChanged1" >
            </asp:DropDownList>
        </div>
        <div style="width: 100%; padding-top: 10px; padding-left: 10px; height: 30px">
            <asp:Button ID="butthemmoi" runat="server" Text="Thêm mới" Width="159px" OnClick="butthemmoi_Click" />
            &nbsp;&nbsp;&nbsp;
        </div>
        <div style="width: 99%; padding-top: 10px; padding-left: 10px">
            <asp:GridView ID="grvnguoidung" runat="server" AutoGenerateColumns="False" Width="100%" CellPadding="4" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" AllowPaging="True">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:CheckBox ID="chkAll" runat="server" AutoPostBack="true" OnCheckedChanged="chkAll_CheckedChanged" />
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:CheckBox runat="server" ID="chkBox" />
                        </ItemTemplate>
                        <ItemStyle Width="3%" />
                    </asp:TemplateField>
                    <asp:BoundField DataField="MaNG" HeaderText="Mã người dùng" />
                    <asp:BoundField DataField="HoTen" HeaderText="Tên người dùng" />
                    <asp:BoundField DataField="GioiTinh" HeaderText="Giới tính" />
                    <asp:BoundField DataField="SDT" HeaderText="SĐT" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="DiaChi" HeaderText="Địa chỉ" />
                  
                
                    <asp:ImageField DataImageUrlField="Avatar" DataImageUrlFormatString="{0}" HeaderText="Avatar">
                        <ControlStyle Width="110px" />
                    </asp:ImageField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <a href='./Admin_ThemNguoiDung.aspx?mand=<%#Eval("MaNG")%>'>Sửa </a>

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
            <asp:Button ID="butduyet" runat="server" Text="Duyệt" Width="100px" OnClick="butduyet_Click" />
            &nbsp;&nbsp;&nbsp;
             <asp:Button ID="butchoduyet" runat="server" Text="Chờ duyệt" Width="100px" OnClick="butchoduyet_Click1"/>
            &nbsp;&nbsp;&nbsp;
             <asp:Button ID="butxoa2" runat="server" Text="Xóa" Width="100px" OnClick="butxoa2_Click" />

        </div>
    </div>
</asp:Content>
