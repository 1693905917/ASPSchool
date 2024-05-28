<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>登录界面</title>
    <style type="text/css">
        .style1
        {
            width: 99%;
            float: left;
            height: 80px;
        }
        .style2
        {
            text-align: center;
        }
        .style3
        {
            text-align: center;
            width: 87px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 88px; width: 212px">
    
        <table align="left" cellpadding="0" cellspacing="0" class="style1" 
            style="font-size: small">
            <tr>
                <td class="style3">
                    用户名：</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" Width="120px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    密&nbsp;&nbsp;&nbsp; 码：</td>
                <td>
                    <asp:TextBox ID="txtpwd" runat="server" TextMode="Password" Width="120px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2" colspan="2">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="登录" />
&nbsp;<asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="重置" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
