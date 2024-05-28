<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="vertical-align: middle; text-align: center">
            <tr>
                <td colspan="2" style="background-color: silver; text-align: center">
                    登录窗口</td>
            </tr>
            <tr>
                <td style="width: 78px; height: 26px">
                    <asp:Label ID="lblLoginId" runat="server" Text="用户名"></asp:Label></td>
                <td style="width: 146px; height: 26px">
                    <asp:TextBox ID="txtloginId" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 78px">
                    <asp:Label ID="lblLoginPwd" runat="server" Text="密码"></asp:Label></td>
                <td style="width: 146px">
                    <asp:TextBox ID="txtLoginPwd" runat="server" TextMode="Password" Width="146px"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" style="height: 26px; text-align: center">
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="登录" />&nbsp;
                </td>
            </tr>
        </table>
    
    </div>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </form>
</body>
</html>
