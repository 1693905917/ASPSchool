<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        .style1
        {
            width: 67px;
            height: 17px;
        }
        .style2
        {
            width: 123px;
            height: 17px;
        }
        .style3
        {
            width: 197px;
            height: 17px;
        }
    </style>
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
            Display="Dynamic" ErrorMessage="RequiredFieldValidator">必须输入用户名</asp:RequiredFieldValidator>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 67px; text-align: right; height: 19px">
                    密 &nbsp;&nbsp; 码</td>
                    <td style="width: 123px; text-align: left; height: 19px">
                    <asp:TextBox ID="txtPassword" runat="server"
            Width="91px" TextMode="Password"></asp:TextBox></td>
                    <td style="width: 197px; text-align: left; height: 19px">
        <asp:RequiredFieldValidator ID="valrPassword" runat="server" ControlToValidate="txtPassword"
            ErrorMessage="RequiredFieldValidator" Display="Dynamic">密码不能为空！</asp:RequiredFieldValidator>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 67px; text-align: right; height: 15px">
        确认密码</td>
                    <td style="width: 123px; text-align: left; height: 15px">
        <asp:TextBox ID="txtRepassword" runat="server" Width="91px" TextMode="Password"></asp:TextBox></td>
                    <td style="width: 197px; text-align: left; height: 15px">
        <asp:CompareValidator ID="valcRepass" runat="server" ControlToCompare="txtPassword" 
                            ErrorMessage="CompareValidator" Width="165px" ControlToValidate="txtRepassword" 
                            Display="Dynamic">两次输入的密码不同！</asp:CompareValidator>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 67px; text-align: right; height: 7px">
        出生日期</td>
                    <td style="width: 123px; text-align: left; height: 7px">
        <asp:TextBox ID="txtBirthday" runat="server" Width="91px"></asp:TextBox></td>
                    <td style="width: 197px; text-align: left; height: 7px">
        <asp:CompareValidator ID="valcBirth" runat="server" ControlToValidate="txtBirthday"
            ErrorMessage="CompareValidator" Operator="DataTypeCheck" Type="Date" Width="182px" 
                            Display="Dynamic">日期格式应为：1983-4-23</asp:CompareValidator></td>
                </tr>
                <tr>
                    <td class="style1">
                        </td>
                    <td class="style2">
        <asp:Button ID="btnOK" runat="server" Text="提 交" OnClick="btnOK_Click" />
                        </td>
                    <td class="style3">
                        </td>
                </tr>
            </table>
            <br />
            &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
            <asp:Label ID="lblPass" runat="server" Text="Label"></asp:Label><br />
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
