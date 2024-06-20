<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="height: 131px; width: 318px;" border="1">
            <tr>
                <td colspan="2" style="text-align: left">
                    <strong style="text-align: center">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 用 户 登
                        录</strong></td>
            </tr>
            <tr>
                <td style="width: 188px">
                    用户名</td>
                <td style="width: 188px">
                    <asp:TextBox ID="Username" runat="server" Width="146px"></asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td style="width: 61px">
                    密 &nbsp;&nbsp; 码</td>
                <td style="width: 188px">
                    <asp:TextBox ID="UserPwd" runat="server" TextMode="Password" Width="146px"></asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td colspan="2" style="height: 26px">
                    &nbsp; &nbsp;
                    <asp:Button ID="Login" runat="server" OnClick="Login_Click" Text="登 录" />&nbsp;
                    <asp:Button ID="Register" runat="server" Text="注 册" OnClick="Register_Click" />&nbsp;
                    <asp:Button ID="Repassword" runat="server" Text="忘记密码" OnClick="Repassword_Click" />&nbsp;
                    <asp:Button ID="Memanger" runat="server" onclick="Memanger_Click" Text="用户管理" />
                </td>
            </tr>
        </table>
    
    </div>
        <br />
        <br />
        <br />
    </form>
</body>
</html>
