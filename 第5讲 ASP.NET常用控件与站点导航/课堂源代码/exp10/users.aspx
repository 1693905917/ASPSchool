<%@ Page Language="C#" AutoEventWireup="true" CodeFile="users.aspx.cs" Inherits="users" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 80%;
        }
        .style2
        {
            font-size: large;
            font-weight: bold;
            text-align: center;
        }
        .style3
        {
            width: 284px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 517px">
    
        <table border="1" class="style1">
            <tr>
                <td class="style2" colspan="2">
                    用户管理</td>
            </tr>
            <tr>
                <td>
                    用户名：</td>
                <td class="style3">
                    <asp:DropDownList ID="UserNameDrop" runat="server" 
                        DataSourceID="SqlDataSource1" DataTextField="u_name" DataValueField="u_name" 
                        Height="16px" Width="125px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    新密码：</td>
                <td class="style3">
                    <asp:TextBox ID="NewPassword" runat="server" TextMode="Password" Width="120px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    确认新密码：</td>
                <td class="style3">
                    <asp:TextBox ID="ReNewPassword" runat="server" 
                         TextMode="Password" Width="120px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="DelUser" runat="server" onclick="DelUser_Click" Text="执行删除" />
                </td>
                <td class="style3">
                    <asp:RadioButtonList ID="DelSelect" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True">仅删除用户</asp:ListItem>
                        <asp:ListItem>删除用户和留言</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: left">
                    <asp:Button ID="ChangePwd" runat="server" onclick="ChangePwd_Click" 
                        Text="修改密码" />
&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="BackHome" runat="server" onclick="BackHome_Click" Text="返回主页" />
                </td>
            </tr>
        </table>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:guestbookConnectionString2 %>" 
            SelectCommand="SELECT [u_name] FROM [userinfo]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
