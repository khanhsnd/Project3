<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeBehind="QL_SanPham.aspx.cs" Inherits="Doan3_TK.QL_SanPham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 100%;">
        <div style="width: 100%; padding-top: 10px; padding-left: 10px; height: 30px">
            Danh sách sản phẩm
        </div>
        <div style="width: 100%; padding-top: 10px; padding-left: 10px; height: 30px">
            Danh mục :
            <asp:DropDownList ID="ddldanhmuc" runat="server" Height="24px" Width="173px" AutoPostBack="true" OnSelectedIndexChanged="ddldanhmuc_SelectedIndexChanged">
            </asp:DropDownList>
            Trạng thái :
            <asp:DropDownList ID="ddltrangthai" runat="server" Height="24px" Width="173px" AutoPostBack="true" OnSelectedIndexChanged="ddldanhmuc_SelectedIndexChanged">
            </asp:DropDownList>
        </div>

        <div style="width: 100%; padding-top: 10px; padding-left: 10px; height: 30px">
            <asp:Button ID="butthemmoi" runat="server" Text="Thêm mới" Width="159px" OnClick="butthemmoi_Click" />
             &nbsp;&nbsp;&nbsp;
             </div>
        <div style="width: 99%; padding-top: 10px; padding-left: 10px">
            <asp:GridView ID="grvsanpham" runat="server" AutoGenerateColumns="False" Width="100%" CellPadding="4" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" AllowPaging="True" OnPageIndexChanging="grvsanpham_PageIndexChanging" >
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
                       <asp:BoundField DataField="idsp" HeaderText="ID sản phẩm" />
                    <asp:BoundField DataField="masp" HeaderText="Mã sản phẩm" />
                    <asp:BoundField DataField="TenSP" HeaderText="Tên sản phẩm" />
                    <asp:BoundField DataField="SL" HeaderText="Số lượng" />
                    <asp:BoundField DataField="GiaBan" HeaderText="Giá bán" />
                    <asp:BoundField DataField="tendm" HeaderText="Danh mục" />
                    <asp:ImageField DataImageUrlField="HinhAnh" DataImageUrlFormatString="{0}" HeaderText="Hình ảnh">
                        <ControlStyle Width="110px" />
                    </asp:ImageField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <a href='./Admin_ThemSanPham.aspx?masp=<%#Eval("idsp")%>'>Sửa </a>

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
             <asp:Button ID="butchoduyet" runat="server" Text="Chờ duyệt" Width="100px" OnClick="butchoduyet_Click" />
               &nbsp;&nbsp;&nbsp;
             <asp:Button ID="butxoa2" runat="server" Text="Xóa" Width="100px" OnClick="butxoa_Click" />
                &nbsp;&nbsp;&nbsp;
             <asp:Button ID="butsettop" runat="server" Text="Set top" Width="100px" OnClick="butsettop_Click"   />
        </div>
    </div>
</asp:Content>
