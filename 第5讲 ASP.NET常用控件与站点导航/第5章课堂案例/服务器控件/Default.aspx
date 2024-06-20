<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        TextBox 服务器控件在三种不同设置下的自动转换<br />
        <br />
        <br />
        <table>
            <tr>
                <td colspan="2" style="height: 33px; text-align: center; color: #ff0066;">
                    留言本</td>
            </tr>
            <tr>
                <td style="text-align: right">
                    用户名</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style=" text-align: right">
                    密码</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: right">
                    留言</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtContent" runat="server" Height="92px" TextMode="MultiLine" Width="176px"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan=2 style=" text-align: center">
                    <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td>
                
            </tr>
            <tr>
                <td colspan=2 style="text-align: center">
                    <asp:Label ID="lblShow" runat="server" Width="386px"></asp:Label></td>
            </tr>
        </table>
    </div>    
    </form>
</body>
</html>
