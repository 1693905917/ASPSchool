<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 22%;
        }
        .style2
        {
            width: 68px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table border="1" class="style1">
            <tr>
                <td colspan="2" style="text-align: center">
                    <b>用户登录</b></td>
            </tr>
            <tr>
                <td class="style2">
                    用户名</td>
                <td>
                    <asp:TextBox ID="TextName" runat="server" Width="123px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    密&nbsp;&nbsp;&nbsp; 码</td>
                <td>
                    <asp:TextBox ID="TextPwd" runat="server" TextMode="Password" width="123px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="ButtonOK" runat="server" onclick="ButtonOK_Click" Text="登 录" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
