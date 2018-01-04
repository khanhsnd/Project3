<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="Admin_ThemSanPham.aspx.cs" Inherits="Doan3_TK.Admin_ThemSanPham" %>


<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
      
        .lblName {
            font-size: 12px;
            margin-top: 6px;
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
        <div class="row">
            <div class="col-xs-12">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue" Text="Thêm mới sản phẩm"></asp:Label>

            </div>

            <div class="box">
                <div class="box-body ">
                    <div class="form-horizontal" style="margin-left: 30px; margin-right: 30px">
                        <div class="form-group">
                            <div class="col-xs-2">
                                <label class="lblName"><span>Mã sản phẩm <span class="text-red">(*)</span></span></label>
                            </div>
                            <div class="col-xs-4">
                                <asp:TextBox ID="txtmasp" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-xs-2">
                                <label class="lblName"><span>Tên sản phẩm<span class="text-red">(*)</span></span></label>
                            </div>
                            <div class="col-xs-4">
                                <asp:TextBox ID="txttensp" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-xs-2">
                                <label class="lblName">Danh mục</label>
                            </div>
                            <div class="col-xs-4">
                                <asp:DropDownList ID="ddldanhmuc" CssClass="form-control" runat="server"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-xs-2">
                                <label class="lblName">Giới thiệu ngắn</label>
                            </div>
                            <div class="col-xs-10">
                                <asp:TextBox ID="txtgioithieu" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="4"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-xs-2">
                            </div>
                            <div class="col-xs-10">
                                <CKEditor:CKEditorControl ID="ckconten" CssClass="form-control" runat="server" Height="300px">
                                </CKEditor:CKEditorControl>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-xs-2">
                                <label class="lblName">Hình ảnh</label>
                            </div>
                            <div class="col-xs-4">
                                <asp:Image ID="imghinhanh" runat="server" Height="113px" Width="100%" />
                                <br />
                                <br />
                                <input type="text" name="urlanh" id="urlanh" />

                                <input type="button" class="btn" value="Chọn Ảnh ..." onclick="BrowseServer();" />
                            </div>
                            <div class="col-xs-2">
                                <label class="lblName">Giá bán</label>
                            </div>
                            <div class="col-xs-4">
                                <asp:TextBox ID="txtgiaban" CssClass="form-control" runat="server" placeholder="VNĐ"></asp:TextBox>
                              
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-xs-2">
                                <label class="lblName">Trạng thái </label>
                            </div>
                            <div class="col-xs-4">
                        <asp:DropDownList ID="ddltrangthai" runat="server" CssClass="form-control">
                        </asp:DropDownList>
                            </div>
                            <div class="col-xs-2">
                                <label class="lblName">Số lượng</label>
                            </div>
                            <div class="col-xs-4">
                                <asp:TextBox ID="txtsoluong" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <asp:Button ID="butthem" runat="server" Text="Thêm mới" Width="186px" OnClick="butthem_Click" />
                        &nbsp;&nbsp;
                        <asp:Button ID="butquayve" runat="server" Text="Quay về" Width="186px" OnClick="butquayve_Click" />
                    </div>
                </div>
            </div>
        </div>
</asp:Content>

