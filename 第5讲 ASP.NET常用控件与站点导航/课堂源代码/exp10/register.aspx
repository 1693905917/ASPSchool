<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: left">
        <strong><span style="font-size: 14pt">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 新用户注册</span></strong><br />
        <table border="1" style="width: 467px; height: 226px; text-align: left">
            <tr>
                <td style="width: 486px; height: 34px;">
                    输入用户名</td>
                <td style="width: 452px; text-align: left; height: 34px;">
                    <asp:TextBox ID="UserName" runat="server" Width="148px"></asp:TextBox>&nbsp;
                    <asp:LinkButton ID="CheckName" runat="server" Font-Bold="True" 
                        OnClick="CheckName_Click">检查用户名</asp:LinkButton></td>
            </tr>
            <tr>
                <td style="width: 486px">
                    输入密码</td>
                <td style="width: 452px; text-align: left">
                    <asp:TextBox ID="UserPwd" runat="server" TextMode="Password" Width="148px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 486px">
                    确认密码</td>
                <td style="width: 452px; text-align: left">
                    <asp:TextBox ID="ReUserPwd" runat="server" TextMode="Password" Width="148px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 486px">
                    密码提示的问题</td>
                <td style="width: 452px; text-align: left">
                    <asp:TextBox ID="SecQuestion" runat="server" Width="282px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 486px; height: 26px">
                    提示问题的答案</td>
                <td style="width: 452px; height: 26px; text-align: left">
                    <asp:TextBox ID="SecAnswer" runat="server" 
                        Width="281px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 486px">
                    &nbsp;</td>
                <td style="width: 452px; text-align: left">
                    <asp:Button ID="SubmitBtn" runat="server" OnClick="SubmitBtn_Click" 
                        Text="提 交" />
                    <asp:Button ID="BackBtn" runat="server" Text="返 回" OnClick="BackBtn_Click" /></td>
            </tr>
        </table>
    
    </div>
        <br />
        <br />
    </form>
</body>
</html>
