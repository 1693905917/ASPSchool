<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 266px">
            <tr>
                <td colspan="2" style="text-align: center">
                    <strong><span style="font-size: 14pt">请登录本系统</span></strong></td>
            </tr>
            <tr>
                <td style="width: 68px">
                    用户名</td>
                <td style="width: 103px">
                    <asp:TextBox ID="TextUsername" runat="server" Width="148px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 68px">
                    密 &nbsp;&nbsp; 码</td>
                <td style="width: 103px">
                    <asp:TextBox ID="TextPassword" runat="server" TextMode="Password" Width="148px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 68px">
                </td>
                <td style="width: 153px">
                    <asp:Button ID="ButtonLogin" runat="server" OnClick="ButtonLogin_Click" 
                        Text="登 录" />
                </td>
            </tr>
        </table>
    
    </div>
        <br />
    </form>
</body>
</html>
