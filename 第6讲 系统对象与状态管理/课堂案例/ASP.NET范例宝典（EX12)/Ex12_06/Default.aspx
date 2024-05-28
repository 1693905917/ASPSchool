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
                <td colspan="2" align="center">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="隶书" Font-Size="X-Large"
                        ForeColor="Red" Text="统计在线人数"></asp:Label></td>
               
            </tr>
            <tr>
                <td style="width: 158px; height: 21px">
        <asp:Label ID="Label1" runat="server" Text="当前在线人数为：" Width="187px" Font-Bold="True" Font-Names="隶书" ForeColor="Red"></asp:Label></td>
                <td style="height: 21px">
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
               
            </tr>
           
        </table>
    
    </div>
    </form>
</body>
</html>
