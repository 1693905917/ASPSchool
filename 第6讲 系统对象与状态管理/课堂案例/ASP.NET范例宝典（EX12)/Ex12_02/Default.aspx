<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body bgcolor ="#ffffcc">
    <form id="form1" runat="server">
    <div>
        <table style="width: 395px; height: 80px" align =center  border =1 bordercolor ="#000000">
            <tr>
                <td align="center" colspan="2">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="隶书" ForeColor="Red"
                        Text="登录"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="用户名：" Font-Bold="True" Font-Names="隶书" ForeColor="Red"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server" Font-Bold="True" Font-Names="隶书"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="密码：" Font-Bold="True" Font-Names="隶书" ForeColor="Red"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtPassWord" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnLoad" runat="server" Text="登录" Font-Bold="True" Font-Names="隶书" ForeColor="Red" OnClick="btnLoad_Click" />
                    <asp:Button ID="btnRegister" runat="server" Text="新用户注册" Font-Bold="True" Font-Names="隶书" ForeColor="Red" OnClick="btnRegister_Click" /></td>
            </tr>
        </table>
    
    </div>
        &nbsp; &nbsp;&nbsp;
    </form>
</body>
</html>
