<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckOut.aspx.cs" Inherits="ClearGoods" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body bgcolor ="#ffffcc">
    <form id="form1" runat="server">
    <div>
        &nbsp;<table width =100% >
            <tr>
                <td style="height: 87px" valign="top">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="隶书"
                        Font-Overline="True" Font-Size="Large" Font-Strikeout="False" Font-Underline="True"
                        ForeColor="Red" Text="结账完毕"></asp:Label></td>
            </tr>
            <tr>
                <td style="height: 4px" align="center">
                    <asp:Label ID="Label2" runat="server" Font-Bold="False" Font-Names="隶书" ForeColor="Red"
                        Text="欢迎您下次光临,再见!" Font-Size="X-Large"></asp:Label></td>
            </tr>
            <tr>
                <td style="height: 72px" align="center">
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Names="隶书" ForeColor="Red"
                        OnClick="Button1_Click" Text="我要继续购买商品" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
