<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddUser.aspx.cs" Inherits="AddUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 300px;
        }
        .style2
        {
            width: 112px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table border="1" class="style1">
            <tr>
                <td colspan="2" style="text-align: center">
                    <b>添加新用户</b></td>
            </tr>
            <tr>
                <td class="style2">
                    用户名</td>
                <td>
                    <asp:TextBox ID="TextName" runat="server" Width="135px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    密码</td>
                <td>
                    <asp:TextBox ID="TextPwd" runat="server"  
                        width="135px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    确认密码</td>
                <td>
                    <asp:TextBox ID="TextRePwd" runat="server"  width="135px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    电子邮件</td>
                <td>
                    <asp:TextBox ID="TextEmail" runat="server" width="135px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    安全问题</td>
                <td>
                    <asp:TextBox ID="TextQuestion" runat="server" width="135px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    安全问题答案</td>
                <td>
                    <asp:TextBox ID="TextAnswer" runat="server"  width="135px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    用户角色</td>
                <td>
                    <asp:DropDownList ID="DropRoles" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="ButtonOK" runat="server" Text="确 定" onclick="ButtonOK_Click" />
                &nbsp;
                    <asp:Button ID="ButtonBack" runat="server"  
                        PostBackUrl="~/Default.aspx" Text="返 回" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
