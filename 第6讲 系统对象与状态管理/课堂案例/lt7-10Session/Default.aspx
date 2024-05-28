<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 319px">
            <tr>
                <td colspan="3" style="text-align: center">
                    <span style="font-size: 14pt"><strong>请登录</strong></span></td>
            </tr>
            <tr>
                <td style="width: 72px">
        用户名：</td>
                <td colspan="2">
                    <asp:TextBox ID="txtUsername" runat="server" Width="138px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 72px">
        密 &nbsp; 码：</td>
                <td colspan="2">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 72px; height: 40px">
                </td>
                <td colspan="2" style="height: 40px">
                    <asp:Button ID="btnLogin"
            runat="server" OnClick="btnLogin_Click" Text="登 录" /></td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        &nbsp;&nbsp;<br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</div>
    </form>
</body>
</html>
