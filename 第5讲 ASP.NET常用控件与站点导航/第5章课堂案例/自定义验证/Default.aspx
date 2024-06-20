<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: left">
        <span ><strong><span style="font-size: 14pt">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 用 户 注 册</span></strong><br />
            <table style="width: 429px; height: 2px" border="1">
                <tr>
                    <td style="width: 67px; text-align: right; height: 22px">
                    用户名</td>
                    <td style="width: 123px; text-align: left; height: 22px">
                    <asp:TextBox ID="txtUsername" runat="server" Width="91px"></asp:TextBox></td>
                    <td style="width: 197px; text-align: left; height: 22px">
        <asp:RequiredFieldValidator ID="valrName" runat="server" ControlToValidate="txtUsername"
            Display="None" ErrorMessage="必须输入用户名"></asp:RequiredFieldValidator>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 67px; text-align: right; height: 19px">
                    密 &nbsp;&nbsp; 码</td>
                    <td style="width: 123px; text-align: left; height: 19px">
                    <asp:TextBox ID="txtPassword" runat="server"
            Width="91px" TextMode="Password"></asp:TextBox></td>
                    <td style="width: 197px; text-align: left; height: 19px">
        <asp:RequiredFieldValidator ID="valrPassword" runat="server" ControlToValidate="txtPassword"
            ErrorMessage="密码不能为空！" Display="None"></asp:RequiredFieldValidator>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 67px; text-align: right; height: 15px">
        确认密码</td>
                    <td style="width: 123px; text-align: left; height: 15px">
        <asp:TextBox ID="txtRepassword" runat="server" Width="91px" TextMode="Password"></asp:TextBox></td>
                    <td style="width: 197px; text-align: left; height: 15px">
        <asp:CompareValidator ID="valcRepass" runat="server" ControlToCompare="txtPassword" ErrorMessage="两次输入的密码不同！" Width="165px" ControlToValidate="txtRepassword" Display="None"></asp:CompareValidator>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 67px; text-align: right; height: 7px">
        出生日期</td>
                    <td style="width: 123px; text-align: left; height: 7px">
        <asp:TextBox ID="txtBirthday" runat="server" Width="91px"></asp:TextBox></td>
                    <td style="width: 197px; text-align: left; height: 7px">
        <asp:CompareValidator ID="valcBirth" runat="server" ControlToValidate="txtBirthday"
            ErrorMessage="日期格式应为：1983-4-23" Operator="DataTypeCheck" Type="Date" Width="182px" Display="None"></asp:CompareValidator>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 67px; height: 17px">
                        &nbsp;</td>
                    <td style="width: 123px; height: 17px">
        <asp:Button ID="btnOK" runat="server" Text="提 交" OnClick="btnOK_Click" />
                        </td>
                    <td style="width: 197px; height: 17px">
                        &nbsp;</td>
                </tr>
            </table>
            <br />
            &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
            <asp:Label ID="lblPass" runat="server" Text="Label"></asp:Label><br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="输入数据时发生了如下错误：" ShowMessageBox="True" ShowSummary="False" />
            <br />
        </span>
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;<br />
        &nbsp; &nbsp; &nbsp;
        <br />
        &nbsp;
        <br />
        &nbsp;
        <br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        </div>
    </form>
</body>
</html>
