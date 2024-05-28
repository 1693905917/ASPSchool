<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body bgcolor ="#ffffcc">
    <form id="form1" runat="server">
    <div>
        <table align="center" border="1" bordercolor="#000000" >
            <tr>
                <td style="width: 258px" align="center">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="隶书" Font-Size="X-Large"
                        ForeColor="Red" Text="网站调查"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 258px">
                    <asp:Label ID="Label2" runat="server" Text="您对本公司的售后服务是否满意？" Font-Bold="True" Font-Names="隶书" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr>
                <td height="100%">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" Font-Bold="True" Font-Names="隶书"
                        ForeColor="Red" Height="100%" AutoPostBack="True">
                        <asp:ListItem Selected="True">非常满意</asp:ListItem>
                        <asp:ListItem>基本满意</asp:ListItem>
                        <asp:ListItem>不满意</asp:ListItem>
                    </asp:RadioButtonList></td>
            </tr>
            <tr>
                <td style="width: 258px">
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Names="隶书" ForeColor="Red"
                        OnClick="Button1_Click" Text="我要投票" />
                    <asp:Button ID="Button2" runat="server" Font-Bold="True" Font-Names="隶书" ForeColor="Red"
                        Text="查看投票结果" OnClick="Button2_Click" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
