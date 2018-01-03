<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeBehind="Admin_ThemTinTuc.aspx.cs" Inherits="Doan3_TK.Admin_ThemTinTuc" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="width: 100%;">
        <div style="width: 100%; padding-left: 15px; text-align: left; padding-top: 10px">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue" Text="Thêm mới tin tức"></asp:Label>

        </div>

        <div style="width: 100%;">
            <table style="width: 100%;">

                <tr>
                    <td class="name">Tiêu đề
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="Red" Text="(*)"></asp:Label></td>
                    <td class="content">
                        <asp:TextBox ID="txttieude" runat="server" Width="60%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="name">Danh mục
                        <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="Red" Text="(*)"></asp:Label></td>
                    <td class="content">
                        <asp:DropDownList ID="ddldanhmuc" runat="server" Height="19px" Width="264px">
                        </asp:DropDownList>

                    </td>
                </tr>
                <tr>
                    <td class="name">Mô tả
                        <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="Red" Text="(*)"></asp:Label></td>
                    <td class="content">
                        <asp:TextBox ID="txtmota" runat="server" Height="102px" TextMode="MultiLine" Width="90%"></asp:TextBox>

                    </td>
                </tr>

                <tr>
                    <td class="name">Nội Dung</td>
                    <td class="content">
                        <CKEditor:CKEditorControl ID="ckconten" runat="server" Width="90%" Height="500px">
                        </CKEditor:CKEditorControl>
                    </td>
                </tr>

                <tr>
                    <td class="name">Hình ảnh
                        <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="Red" Text="(*)"></asp:Label></td>
                    <td class="content">
                        <asp:Image ID="imghinhanh" runat="server" Height="113px" Width="240px" />
                        <br />
                        <br />
                        <input type="text" name="urlanh" id="urlanh" />

                        <input type="button" value="Chọn Ảnh ..." onclick="BrowseServer();" />

                    </td>
                </tr>


                <tr>
                    <td class="name">Ngày xuất bản:
                    </td>
                    <td class="content">
                        <asp:DropDownList ID="ddNgay" runat="server">
                        </asp:DropDownList>
                        <asp:DropDownList ID="ddThang" runat="server">
                        </asp:DropDownList>
                        <asp:DropDownList ID="ddNam" runat="server">
                        </asp:DropDownList>

                    </td>

                </tr>
                <tr>
                    <td class="name">Trạng thái </td>
                    <td class="content">
                        <asp:DropDownList ID="ddltrangthai" runat="server" Height="19px" Width="264px">
                        </asp:DropDownList>

                    </td>
                </tr>
                <tr>
                    <td class="name"></td>
                    <td class="content"></td>
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

