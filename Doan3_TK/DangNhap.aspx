<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="Doan3_TK.DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 1024px; height: 530px; margin: auto">
                <tr>
                    <td style="width: 100%; height: 530px;">
                        <div style="width: 552px; height: 85px; margin: auto; text-align: center">

                            <asp:Label ID="Label1" runat="server" Text="HÃY ĐĂNG NHẬP ĐỂ TRUY CẬP TRANG QUẢNG TRỊ" Font-Size="Large" ForeColor="#000066" Font-Bold="True"></asp:Label>
                        </div>
                        <div style="width: 440px; height: 500px; margin: auto;">


                            <div style="width: 440px; height: 270px; margin: auto; margin-top: 50px;">
                                <div style="width: 440px; height: 270px; margin: auto; border: thin solid #ebe4e4; margin-top: 10px; background: url('./Images/1.jpg');">

                                    <div style="width: 100%; height: 24px; margin-top: 10px; text-align: center; margin-bottom: auto;">

                                        <asp:Label ID="TB" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>

                                    </div>

                                    <div style="width: 350px; height: 30px; margin: auto; margin-top: 20px; margin-right: 45px; margin-left: 45px">
                                        <div style="width: 75px; height: 27px; margin: auto; float: left; text-align: right">
                                            Tài khoản :
                                        </div>
                                        <div style="width: 240px; height: 27px; margin: auto; float: right; margin-right: 20px;">
                                            <asp:TextBox ID="txtDN" runat="server" Width="100%"></asp:TextBox>
                                        </div>
                                    </div>

                                    <div style="width: 350px; height: 30px; margin: auto; margin-top: 20px; margin-right: 45px; margin-left: 45px">
                                        <div style="width: 74px; height: 27px; margin: auto; float: left; text-align: right">
                                            Mật khẩu :
                                        </div>
                                        <div style="width: 240px; height: 27px; margin: auto; float: right; margin-right: 20px;">
                                            <asp:TextBox ID="txtMK" runat="server" Width="100%" TextMode="Password"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div style="width: 350px; height: 30px; margin: auto; margin-top: 20px; margin-right: 45px; margin-left: 45px">
                                        <div style="width: 300px; height: 27px; margin: auto; text-align: center">
                                            <asp:Button ID="butDangNhap" runat="server" Text="Đăng nhập" OnClick="butDangNhap_Click"  />
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>

                    </td>

                </tr>

            </table>
        </div>
    </form>
</body>
</html>
