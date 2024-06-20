<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UserLogin.aspx.cs" Inherits="UserLogin" Title="" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style2" style="width: 767px" border="1">
        <tr>
            <td colspan="4" class="style5">
    会员登录</td>
        </tr>
        <tr>
            <td class="style4">
    用户名：</td>
            <td class="style6" colspan="3">
                <asp:TextBox ID="txtUser" runat="server" ValidationGroup="login" Width="121px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUser"
        Display="Dynamic" ErrorMessage="*" ValidationGroup="login"></asp:RequiredFieldValidator>
            &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
    密 码：</td>
            <td class="style7" colspan="3">
    <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" ValidationGroup="login" 
                    width="121px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPwd"
        Display="Dynamic" ErrorMessage="*" ValidationGroup="login"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style10">
    验证码：</td>
            <td class="style8" colspan="3">
                <asp:TextBox ID="txtValid" runat="server" ValidationGroup="login" width="121px"></asp:TextBox>
    <asp:Image ID="imgValid" runat="server" ImageUrl="~/CreateImage.aspx" Height="40px" Width="77px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="lbtnChangeValid" runat="server" OnClick="lbtnChangeValid_Click">看不清换一张</asp:LinkButton>&nbsp;&nbsp;&nbsp; <asp:RequiredFieldValidator
        ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtValid" Display="Dynamic"
        ErrorMessage="验证码不能为空" ValidationGroup="login"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style10">
                &nbsp;</td>
            <td class="style8" colspan="3">
    <asp:Button ID="btnSubmit" runat="server" Text="提交" OnClick="btnSubmit_Click"  ValidationGroup="login" />
    <asp:Button ID="btnClear" runat="server" Text="清空" OnClick="btnClear_Click"  ValidationGroup="login" />
            </td>
        </tr>
        <tr>
            <td colspan="4" class="style9" style="text-align: left">
    忘记密码？</td>
        </tr>
        <tr>
            <td class="style10">
    用户名：</td>
            <td class="style8" colspan="3">
                <asp:TextBox ID="txtUserPwd" runat="server" ValidationGroup="pwd" width="121px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtUserPwd"
        Display="Dynamic" ErrorMessage="用户名不为空" ValidationGroup="pwd"></asp:RequiredFieldValidator>
    <asp:LinkButton ID="lbtnGetPwd" runat="server" OnClick="lbtnGetPwd_Click" ValidationGroup="pwd">显示安全问题</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style10">
    问 &nbsp;&nbsp; 题：</td>
            <td class="style8" colspan="3">
                &nbsp;<asp:Label ID="lblQuestion" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style10">
    答 &nbsp; &nbsp;案：</td>
            <td class="style8" colspan="3">
                <asp:TextBox ID="txtAnswer" runat="server" ValidationGroup="pwd" width="121px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
                &nbsp;</td>
            <td class="style8" colspan="3">
        <asp:Button ID="btnOK" runat="server" Text="找回密码" OnClick="btnOK_Click" />
            </td>
        </tr>
        <tr>
            <td class="style11" colspan="4">
                修改密码</td>
        </tr>
        <tr>
            <td class="style26">
                用户名：</td>
            <td class="style27">
                <asp:TextBox ID="TextName" runat="server" Width="121px"></asp:TextBox>
            </td>
            <td class="style28">
                原密码：</td>
            <td class="style29">
                <asp:TextBox ID="TextOldPwd" runat="server" TextMode="Password" width="121px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style22">
                新密码</td>
            <td class="style23">
                <asp:TextBox ID="TextNewPwd" runat="server" TextMode="Password" width="121px"></asp:TextBox>
            </td>
            <td class="style24">
                确认新密码：</td>
            <td class="style25">
                <asp:TextBox ID="TextReNewPwd" runat="server" TextMode="Password" width="121px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style22">
                &nbsp;</td>
            <td class="style23" colspan="3">
                <asp:Button ID="ButtonUpdate" runat="server" onclick="ButtonUpdate_Click" 
                    Text="修改" />
            </td>
        </tr>
    </table>
   
    </asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style3
        {
            height: 49px;
            text-align: left;
            width: 63px;
        }
        .style4
        {
            height: 46px;
            text-align: left;
            width: 63px;
        }
        .style5
        {
            font-size: x-large;
            font-weight: bold;
            text-align: left;
        }
        .style6
        {
            height: 46px;
            text-align: left;
            }
        .style7
        {
            height: 49px;
            text-align: left;
            }
        .style8
        {
            text-align: left;
            }
        .style9
        {
            text-align: left;
            font-size: x-large;
            font-weight: bold;
        }
        .style10
        {
            text-align: left;
            vertical-align:baseline;
        }
        .style11
        {
            text-align: left;
            vertical-align: baseline;
            font-weight: bold;
            font-size: x-large;
        }
        .style22
        {
            text-align: left;
            vertical-align: baseline;
            height: 17px;
        }
        .style23
        {
            text-align: left;
            height: 17px;
        }
        .style24
        {
            text-align: left;
            width: 80px;
            height: 17px;
        }
        .style25
        {
            height: 17px;
            text-align: left;
        }
    .style26
    {
        text-align: left;
        vertical-align: baseline;
        height: 19px;
    }
    .style27
    {
        text-align: left;
        width: 201px;
        height: 19px;
    }
    .style28
    {
        text-align: left;
        width: 80px;
        height: 19px;
    }
    .style29
    {
        height: 19px;
        text-align: left;
    }
    </style>

</asp:Content>


