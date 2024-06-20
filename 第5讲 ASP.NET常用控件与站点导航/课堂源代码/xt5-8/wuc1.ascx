<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wuc1.ascx.cs" Inherits="wuc1" %>
<table style="width: 453px">
    <tr>
        <td colspan="3" style="text-align: left">
            <span style="font-size: 14pt"><strong>&nbsp; &nbsp; &nbsp; &nbsp; 请输入注册信息</strong></span></td>
    </tr>
    <tr>
        <td>
            用户名</td>
        <td>
            <asp:TextBox ID="TextName" runat="server" Width="144px"></asp:TextBox></td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextName"
                ErrorMessage="用户名不能为空！"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td>
            密码</td>
        <td>
            <asp:TextBox ID="TextPassword" runat="server" TextMode="Password" Width="144px"></asp:TextBox></td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextPassword"
                ErrorMessage="密码不能为空！"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td>
            确认密码</td>
        <td>
            <asp:TextBox ID="TextRepassword" runat="server" TextMode="Password" 
                Width="144px"></asp:TextBox></td>
        <td>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextPassword"
                ControlToValidate="TextRepassword" ErrorMessage="两次输入的密码不同！"></asp:CompareValidator></td>
    </tr>
</table>
<p>
    &nbsp;</p>

