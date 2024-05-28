<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align =center bgcolor="#ffffcc" border="1" bordercolor="#000000" >
            <tr>
                <td align="center" colspan="2">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="隶书" Font-Size="Large"
                        ForeColor="Red" Text="获取IP地址"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 145px; height: 26px;" align="center">
                    <asp:Label ID="Label1" runat="server" Text="显示客户端的IP地址" Font-Bold="True" Font-Names="隶书" ForeColor="Red" Width="228px"></asp:Label></td>
                <td style="width: 96px; height: 26px;">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="center" style="width: 145px; height: 26px">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="隶书" ForeColor="Red"
                        Text="显示服务器的IP地址" Width="225px"></asp:Label></td>
                <td style="width: 96px; height: 26px">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" style="height: 25px" align="left">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="点击" /></td>
                
            </tr>
          
        </table>
        &nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
