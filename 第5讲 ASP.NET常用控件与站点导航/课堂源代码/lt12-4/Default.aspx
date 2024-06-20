<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 44%;
        }
        .style2
        {
            font-size: large;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table border="1" class="style1">
            <tr>
                <td class="style2" colspan="2" style="text-align: center">
                    修改用户信息</td>
            </tr>
            <tr>
                <td>
                    用户名：</td>
                <td>
                    <asp:DropDownList ID="UsernameDrop" runat="server" Height="19px" Width="157px" 
                        AutoPostBack="True" 
                        onselectedindexchanged="UsernameDrop_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    密码：</td>
                <td>
                    <asp:TextBox ID="PasswordTextBox" runat="server" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    新密码：</td>
                <td>
                    <asp:TextBox ID="NewPasswordTextBox" runat="server" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    确认新密码：</td>
                <td>
                    <asp:TextBox ID="ReNewPasswordTextBox" runat="server" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    电子邮件：</td>
                <td>
                    <asp:TextBox ID="EmailTextBox" runat="server" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    安全问题：</td>
                <td>
                    <asp:TextBox ID="QuestionTextBox" runat="server" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    安全问题答案：</td>
                <td>
                    <asp:TextBox ID="AnswerTextBox" runat="server" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="UpdateUser" runat="server" onclick="UpdateUser_Click" 
                        Text="更新密码和邮箱" />
                    </td>
                <td>
                    <asp:Button ID="UpdatQuestion" runat="server" onclick="UpdatQuestion_Click" 
                        Text="更新安全问题及答案" />
                </td>
            </tr>
        </table>
    
    </div>
    <br />
    </form>
</body>
</html>
