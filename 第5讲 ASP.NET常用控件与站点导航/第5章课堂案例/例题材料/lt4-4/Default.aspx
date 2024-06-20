<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        <table style="text-align: center">
            <tr>
                <td style="width: 72px">
                    用户名：</td>
                <td style="width: 158px">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 72px">
                    密 &nbsp; 码：</td>
                <td style="width: 158px">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="149px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 72px">
                </td>
                <td style="width: 158px; text-align: center">
                    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="登 录" />
                    &nbsp; &nbsp;
                    <asp:Button ID="btnReset" runat="server" Text="重 置" OnClick="btnReset_Click" /></td>
            </tr>
        </table>
    
    </div>
        <br />
    </form>
</body>
</html>
