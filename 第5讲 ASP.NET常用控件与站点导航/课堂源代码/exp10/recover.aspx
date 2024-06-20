<%@ Page Language="C#" AutoEventWireup="true" CodeFile="recover.aspx.cs" Inherits="Recover" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1" style="width: 441px; height: 208px">
            <tr>
                <td colspan="3" style="text-align: center">
                    <strong>恢复遗忘的密码</strong></td>
            </tr>
            <tr>
                <td colspan="3" style="height: 28px">
                    你的用户名是：<asp:Label ID="UserNameLab" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="3">
                    请回答下列问题，该问题是你在注册时填写的：</td>
            </tr>
            <tr>
                <td colspan="3" style="height: 28px">
                    <asp:TextBox ID="Question" runat="server" Width="361px" ReadOnly="True"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="3" style="height: 28px">
                    该问题的答案是：</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:TextBox ID="Answer" runat="server" Width="245px"></asp:TextBox>
                    &nbsp;
                    <asp:Button ID="SubmitBtn" runat="server" OnClick="SubmitBtn_Click" Text="提 交" />&nbsp;<asp:Button
                        ID="BackBtn" runat="server" OnClick="BackBtn_Click" Text="返 回" /></td>
            </tr>
            <tr>
                <td colspan="3" style="height: 72px">
                    <asp:Panel ID="Panel1" runat="server" Height="50px" Width="125px">
                        <table style="width: 362px">
                            <tr>
                                <td style="width: 150px; height: 28px">
                                    请输入新密码：</td>
                                <td style="width: 100px; height: 28px; text-align: left;">
                                    确认新密码：</td>
                                <td style="width: 107px; height: 28px">
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 150px">
                                    <asp:TextBox ID="NewPwd" runat="server" TextMode="Password" Width="131px"></asp:TextBox></td>
                                <td style="width: 100px">
                                    <asp:TextBox ID="ReNewPwd" runat="server" TextMode="Password" Width="131px"></asp:TextBox></td>
                                <td style="width: 107px">
                                    <asp:Button ID="UpdateBtn" runat="server" OnClick="UpdateBtn_Click" Text="更新密码" /></td>
                            </tr>
                        </table>
                    </asp:Panel>
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
