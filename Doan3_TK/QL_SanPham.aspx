<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeBehind="QL_SanPham.aspx.cs" Inherits="Doan3_TK.QL_SanPham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-xs-12" style="margin-left: 15px">
            <h4>Danh sách sản phẩm</h4>
        </div>
        <div class="form-group" style="margin-left: 15px">
            <div class="col-xs-1">Danh mục</div>
            <div class="col-xs-4">
                <asp:DropDownList ID="ddldanhmuc" runat="server" Height="24px" Width="173px" AutoPostBack="true" OnSelectedIndexChanged="ddldanhmuc_SelectedIndexChanged">
                </asp:DropDownList>
            </div>
            <div class="col-xs-1">Trạng thái</div>
            <div class="col-xs-4">
                <asp:DropDownList ID="ddltrangthai" runat="server" Height="24px" Width="173px" AutoPostBack="true" OnSelectedIndexChanged="ddldanhmuc_SelectedIndexChanged">
                </asp:DropDownList>
            </div>
        </div>
        <div class="form-group col-xs-12" style="margin-top: 15px">
            <div class="col-xs-2">
                <asp:Button ID="butthemmoi" runat="server" Text="Thêm mới" CssClass="btn btn-primary" OnClick="butthemmoi_Click" />
            </div>
            <div class="col-xs-2">
                <asp:Button ID="butsettop" runat="server" Text="Set top" CssClass="btn btn-primary" OnClick="butsettop_Click" />
            </div>
            <div class="col-xs-2">
                <asp:Button ID="butduyet" runat="server" Text="Duyệt" CssClass="btn btn-primary" OnClick="butduyet_Click" />
            </div>
            <div class="col-xs-2">
                <asp:Button ID="butchoduyet" runat="server" Text="Chờ duyệt" CssClass="btn btn-primary" OnClick="butchoduyet_Click" />
            </div>
        </div>
        <div style="width: 99%; padding-top: 10px; padding-left: 10px">
            <table class="table table-mstyle table-data">
                <tr>
                    <th>
                        <asp:CheckBox ID="chkAll" runat="server" AutoPostBack="true" OnCheckedChanged="chkAll_CheckedChanged" />
                    </th>
                    <th>ID</th>
                    <th>Mã</th>
                    <th>Tên</th>
                    <th class="text-center">Số lượng</th>
                    <th>Giá bán</th>
                    <th>Danh mục</th>
                    <th>Ảnh</th>
                    <th>Chức năng</th>
                </tr>
                <asp:Repeater runat="server" ID="rptData">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <asp:CheckBox runat="server" ID="chkBox" /></td>
                            <td>
                                <%#Eval("idsp") %>
                                <asp:HiddenField runat="server" ID="idsp" Value='<%# Eval("idsp") %>'></asp:HiddenField>
                            </td>
                            <td><%# Eval("masp")%></td>
                            <td><%# Eval("TenSP")%></td>
                            <td class="text-center"><%# Eval("SL")%></td>
                            <td><%# Eval("GiaBan")%></td>
                            <td><%# Eval("tendm")%></td>
                            <td>
                                <img src="<%# Eval("HinhAnh")%>" width="50px" height="50px" /></td>
                            <td>
                                <div class="btn-group mr15">
                                    <button data-toggle="dropdown" class="btn btn-default btn-sm dropdown-toggle gexport" type="button" aria-expanded="false">
                                        <i class="fa fa-gear"></i>
                                        &nbsp;<span class="caret"></span>
                                        <span class="sr-only">Toggle Dropdown</span>
                                    </button>
                                    <ul role="menu" class="dropdown-menu dropdown-menu-right">
                                        <li>
                                            <a href='./Admin_ThemSanPham.aspx?masp=<%#Eval("idsp")%>'>Sửa 
                                            </a>
                                        </li>
                                        <li>
                                            <asp:LinkButton ID="butxoa2" OnClientClick="var cf = confirm('Bạn có chắc chắn muốn xóa dữ liệu ?'); if(cf == true){return true;} else{return false;}" runat="server" ToolTip="Xóa dữ liệu">
                                               Xóa
                                            </asp:LinkButton>
                                        </li>
                                        <li>
                                            <asp:LinkButton runat="server" ID="btnIn" OnClientClick="window.print();return false;">In </asp:LinkButton>
                                        </li>
                                    </ul>
                                </div>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>

        </div>

        <div style="width: 100%; padding-top: 10px; padding-left: 10px; height: 30px">
        </div>
    </div>
</asp:Content>
