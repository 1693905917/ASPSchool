<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body bgcolor ="#ffffcc">
    <form id="form1" runat="server">
   
        <table style="width: 267px; height: 58px" align =center  border =1 bordercolor ="#000000">
            <tr>
                <td align="center" colspan="2">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="隶书" ForeColor="Red"
                        Text="新用户注册"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="用户名：" Font-Bold="True" Font-Names="隶书" ForeColor="Red"></asp:Label></td>
                <td style="width: 158px">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="密码：" Font-Bold="True" Font-Names="隶书" ForeColor="Red"></asp:Label></td>
                <td style="width: 158px">
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="注册" Font-Bold="True" Font-Names="隶书" ForeColor="Red" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="返回" Font-Bold="True" Font-Names="隶书" ForeColor="Red" OnClick="Button2_Click" /></td>
            </tr>
        </table>
        &nbsp;
    </form>
</body>
</html>
