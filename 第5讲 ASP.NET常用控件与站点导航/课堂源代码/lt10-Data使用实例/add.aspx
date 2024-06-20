<%@ Page Language="C#" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        .style1
        {
            width: 79px;
        }
        .style2
        {
            width: 138px;
        }
        .style3
        {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1" style="width: 291px">
            <tr>
                <td colspan="2" style="text-align: center" class="style3">
                    <strong>添加新记录</strong></td>
            </tr>
            <tr>
                <td style="text-align: center" class="style1">
                    学号</td>
                <td class="style2">
                    <asp:TextBox ID="StuNo" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: center" class="style1">
                    姓名</td>
                <td class="style2">
                    <asp:TextBox ID="StuName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: center" class="style1">
                    性别</td>
                <td class="style2">
                    <asp:TextBox ID="StuSex" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: center" class="style1">
                    出生日期</td>
                <td class="style2">
                    <asp:TextBox ID="StuBirthday" runat="server" ></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: center" class="style1">
                    专业</td>
                <td class="style2">
                    <asp:TextBox ID="StuSpecialty" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align: center" class="style1">
                    电子邮件</td>
                <td class="style2">
                    <asp:TextBox ID="StuEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2">
                    <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="提 交" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="BackHome" runat="server" OnClick="BackHome_Click" Text="返 回" /></td>
            </tr>
        </table>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
