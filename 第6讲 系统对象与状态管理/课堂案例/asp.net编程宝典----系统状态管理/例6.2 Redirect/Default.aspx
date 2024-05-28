<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>注册界面</title>
    <style type="text/css">
        .style1
        {
            width: 106%;
            float: left;
            height: 87px;
        }
        .style2
        {
            height: 24px;
        }
        .style3
        {
            height: 27px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-size: small; height: 93px; width: 187px; margin-bottom: 0px;">
    
        <table align="left" cellpadding="0" cellspacing="0" class="style1">
            <tr>
                <td class="style3">
                    姓名：</td>
                <td class="style3">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    性别：</td>
                <td class="style2">
                    <asp:RadioButtonList ID="rblsex" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True">男</asp:ListItem>
                        <asp:ListItem>女</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: left">
                    <asp:Button ID="Button1" runat="server" Text="确定" onclick="Button1_Click1" />
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
