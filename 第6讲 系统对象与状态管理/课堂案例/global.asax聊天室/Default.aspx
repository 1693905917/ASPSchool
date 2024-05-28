<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="height: 151px">
            <tr>
                <td colspan="3" style="text-align: center">
                    <strong><span style="font-size: 14pt">登录开心聊天室</span></strong></td>
            </tr>
            <tr>
                <td style="width: 64px">
                    用户名</td>
                <td colspan="2">
                    <asp:TextBox ID="TextUserName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 64px">
                    密 &nbsp;&nbsp; 码</td>
                <td colspan="2">
                    <asp:TextBox ID="TextPassword" runat="server" TextMode="Password" Width="149px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 64px">
                </td>
                <td style="width: 100px">
                    <asp:LinkButton ID="LinkLogin" runat="server" OnClick="LinkLogin_Click">进入聊天室</asp:LinkButton></td>
                <td style="width: 100px">
                </td>
            </tr>
        </table>
    
    </div>
        <br />
        <br />
    </form>
</body>
</html>
