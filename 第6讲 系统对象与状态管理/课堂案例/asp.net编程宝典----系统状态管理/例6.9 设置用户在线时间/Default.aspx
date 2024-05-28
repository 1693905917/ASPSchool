<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>登录界面</title>
    <style type="text/css">
        .style1
        {
            width: 97%;
            float: left;
            height: 101px;
        }
        .style2
        {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 104px; width: 244px">
    
        <table align="left" cellpadding="0" cellspacing="0" class="style1" 
            style="font-size: small">
            <tr>
                <td class="style2">
                    用户名：</td>
                <td>
                    <asp:TextBox ID="txtname" runat="server" Width="120px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    密&nbsp;&nbsp;&nbsp; 码：</td>
                <td>
                    <asp:TextBox ID="txtpwd" runat="server" TextMode="Password" Width="120px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2" colspan="2">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="登录" />
&nbsp;
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="重置" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
