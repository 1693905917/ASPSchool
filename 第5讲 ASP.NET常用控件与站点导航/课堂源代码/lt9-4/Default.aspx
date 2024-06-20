<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1">
            <tr>
                <td colspan="2" style="text-align: center">
                    <strong><span style="font-size: 14pt">登&nbsp; 录</span></strong></td>
            </tr>
            <tr>
                <td style="width: 100px; text-align: center">
                    用户名</td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextUsername" runat="server" Width="146px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px; text-align: center">
                    密 &nbsp; 码</td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextPassword" runat="server" TextMode="Password" Width="145px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    &nbsp;</td>
                <td style="width: 100px">
                    <asp:Button ID="ButtonLogin" runat="server" OnClick="ButtonLogin_Click" 
                        Text="登 录" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
