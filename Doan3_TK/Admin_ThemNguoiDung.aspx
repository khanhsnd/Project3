<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeBehind="Admin_ThemNguoiDung.aspx.cs" Inherits="Doan3_TK.Admin_ThemNguoiDung" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .name {
            width: 15%;
            float: left;
            text-align: right;
        }

        .content {
            width: 83%;
            float: right;
            text-align: left;
        }
    </style>
    <script src="ckfinder/ckfinder.js"></script>
    <script type="text/javascript">
        function BrowseServer() {
            var finder = new CKFinder();
            //finder.basePath = '../';
            finder.selectActionFunction = SetFileField;
            finder.popup();
        }
        function SetFileField(fileUrl) {
            document.getElementById('urlanh').value = fileUrl;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 100%;">
        <div style="width: 100%; padding-left: 15px; text-align: left; padding-top: 10px">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue" Text="Thêm mới người dùng"></asp:Label>

        </div>

        <div style="width: 100%;">
            <table style="width: 100%;">
                <%--<tr>
                    <td class="name">Mã người dùng
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" Text="(*)"></asp:Label></td>
                    <td class="content">
                        <asp:TextBox ID="txtmand" runat="server" Width="131px"></asp:TextBox>
                    </td>
                </tr>--%>
                <tr>
                    <td class="name">Tên người dùng
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="Red" Text="(*)"></asp:Label></td>
                    <td class="content">
                        <asp:TextBox ID="txttennd" runat="server" Width="287px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="name">Giới tính
                        </td>
                    <td class="content">
                        <asp:DropDownList ID="ddgioitinh" runat="server" Height="22px" Width="92px">
                            <asp:ListItem>Giới Tính</asp:ListItem>
                            <asp:ListItem>Nam</asp:ListItem>
                            <asp:ListItem>Nữ</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="name">SĐT
                        <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="Red" Text="(*)"></asp:Label></td>
                    <td class="content">
                        <asp:TextBox ID="txtsdt" runat="server" Width="290px"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td class="name">Email
                        <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="Red" Text="(*)"></asp:Label></td>
                    <td class="content">
                        <asp:TextBox ID="txtemail" runat="server" Width="293px"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td class="name">Địa Chỉ
                        <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="Red" Text="(*)"></asp:Label></td>
                    <td class="content">
                        <asp:TextBox ID="txtdiachi" runat="server" Width="595px"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td class="name">Ngày sinh
                        </td>
                    <td class="content">
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
                    <td class="name">Hình ảnh
                        <asp:Label ID="Label9" runat="server" Font-Bold="True" ForeColor="Red" Text="(*)"></asp:Label></td>
                    <td class="content">
                        <asp:Image ID="imghinhanh" runat="server" Height="113px" Width="240px" />
                        <br />
                        <br />
                        <input type="text" name="urlanh" id="urlanh" />

                        <input type="button" value="Chọn Ảnh ..." onclick="BrowseServer();" />

                    </td>
                </tr>
                <tr>
                    <td class="name">Trạng thái </td>
                    <td class="content">
                        <asp:DropDownList ID="ddltrangthai" runat="server" Height="30px" Width="254px">
                        </asp:DropDownList>

                    </td>
                </tr>
                <tr>
                    <td class="name">Nhóm Quyền
                        </td>
                    <td class="content">
                        <asp:DropDownList ID="ddlquyen" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td class="name"></td>
                    <td class="content" style="margin-top: 30px">
                        <asp:Button ID="butthem" runat="server" Text="Thêm mới" Width="186px" OnClick="butthem_Click" />

                        &nbsp;&nbsp;
                        <asp:Button ID="butquayve" runat="server" Text="Quay về" Width="186px" OnClick="butquayve_Click1" />

                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
