<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 48%;
        }
        .style2
        {
            text-align: right;
        }
        .style3
        {
            text-align: right;
            width: 139px;
        }
        .style4
        {
            width: 384px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style2" colspan="2">
                    <b>创建新用户&nbsp;&nbsp;&nbsp; </b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td class="style3">
                    用户名：</td>
                <td class="style4">
    
        <asp:TextBox ID="UsernameTextBox" runat="server" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    密码：</td>
                <td class="style4">
                    <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" 
                        Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    确认密码：</td>
                <td class="style4">
                    <asp:TextBox ID="RePasswordTextBox" runat="server" TextMode="Password" 
                        Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    电子邮件：</td>
                <td class="style4">
                    <asp:TextBox ID="EmailTextBox" runat="server" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    安全问题：</td>
                <td class="style4">
                    <asp:TextBox ID="QuestionTextBox" runat="server" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    安全问题的答案：</td>
                <td class="style4">
                    <asp:TextBox ID="AnswerTextBox" runat="server" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
        <asp:Button ID="CreateUser" runat="server" onclick="CreateUser_Click" Text="创建用户" />
    
                </td>
                <td class="style4">
    
    &nbsp;
                    <asp:Label ID="Msg" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
