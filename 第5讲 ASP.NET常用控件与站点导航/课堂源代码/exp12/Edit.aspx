<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Edit.aspx.cs" Inherits="_Default" %>

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
            font-size: large;
            font-weight: bold;
        }
        .style3
        {
            text-align: right;
            width: 110px;
        }
        .style4
        {
            width: 110px;
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
                <td class="style3">
                    用户名</td>
                <td>
                    <asp:DropDownList ID="DropName" runat="server" Height="19px" Width="157px" 
                        AutoPostBack="True" onselectedindexchanged="DropName_SelectedIndexChanged" >
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    密码</td>
                <td>
                    <asp:TextBox ID="TextPwd" runat="server" Width="150px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    新密码</td>
                <td>
                    <asp:TextBox ID="TextNewPwd" runat="server" Width="150px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    确认新密码</td>
                <td>
                    <asp:TextBox ID="TextReNewPwd" runat="server" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    电子邮件</td>
                <td>
                    <asp:TextBox ID="TextEmail" runat="server" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    安全问题</td>
                <td>
                    <asp:TextBox ID="TextQuestion" runat="server" Width="150px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    安全问题答案</td>
                <td>
                    <asp:TextBox ID="TextAnswer" runat="server" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    用户角色</td>
                <td>
                    <asp:DropDownList ID="DropRoles" runat="server" width="157px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="ButtonEdit" runat="server" onclick="ButtonEdit_Click" 
                        Text="更 新" />
                    &nbsp;
                    <asp:Button ID="Button1" runat="server" PostBackUrl="~/Default.aspx" 
                        Text="返 回" />
                </td>
            </tr>
        </table>
    
    </div>
    <br />
    </form>
</body>
</html>
