<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body bgcolor ="#ffffcc">
    <form id="form1" runat="server">
    <div>
        <table  width =100% align =center >
            <tr>
                <td colspan="3" style="height: 63px">
                </td>
            </tr>
            <tr>
                <td align="center" colspan="3" valign="middle">
                    <table border="1" bordercolor="#330000" style="width: 281px">
                        <tr>
                            <td colspan="2">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="隶书" Font-Size="X-Large"
                        ForeColor="Red" Text="进入购物商城"></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="width: 483px; height: 32px">
                            </td>
                            <td align="center" style="width: 262px; height: 32px" valign="middle">
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Names="隶书" Font-Size="Medium"
                        ForeColor="Red" Text="ＧＯ" OnClick="Button1_Click" /></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
