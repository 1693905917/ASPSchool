<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        .style1
        {
            width: 79px;
            height: 26px;
        }
        .style2
        {
            width: 160px;
            height: 26px;
        }
        .style3
        {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <table style="width: 482px; font-weight: bold;">
                <tr>
                    <td colspan="3" style="text-align: left; height: 33px;">
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                        输入用户数据</td>
                </tr>
                <tr>
                    <td style="width: 79px">
                        用户名</td>
                    <td style="width: 160px">
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></td>
                    <td>
        <asp:CustomValidator ID="valxUsername" runat="server" ErrorMessage="CustomValidator"
            OnServerValidate="valxUsername_ServerValidate"></asp:CustomValidator></td>
                </tr>
                <tr>
                    <td class="style1">
                        密 &nbsp;&nbsp; 码</td>
                    <td class="style2">
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="148px"></asp:TextBox></td>
                    <td class="style3">
        <asp:CustomValidator ID="valxPassword" runat="server" ErrorMessage="CustomValidator"
            OnServerValidate="valxPassword_ServerValidate"></asp:CustomValidator></td>
                </tr>
                <tr>
                    <td style="width: 79px">
                        电子邮件</td>
                    <td style="width: 160px">
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                    <td>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEmail"
            ErrorMessage="RegularExpressionValidator" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">电子邮件格式不正确！</asp:RegularExpressionValidator></td>
                </tr>
                <tr>
                    <td style="width: 79px">
                    </td>
                    <td style="width: 160px">
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="提 交" /></td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td style="height: 34px;" colspan="3">
        <asp:Label ID="lblMsg" runat="server" Font-Bold="True"></asp:Label></td>
                </tr>
            </table>
        <br />
        <br />
        <br />
            <br />
        <strong>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</strong>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
