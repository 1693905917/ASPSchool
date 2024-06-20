<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 423px">
            <tr>
                <td colspan="2" style="height: 36px; text-align: center">
                    <strong><span style="font-size: 14pt">学生成绩查询系统</span></strong></td>
                <td style="height: 36px">
                </td>
            </tr>
            <tr>
                <td style="width: 98px">
                    请输入学号：</td>
                <td style="width: 164px">
                    <asp:TextBox ID="txtNo" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="查 询" /></td>
            </tr>
            <tr>
                <td style="width: 98px">
                    请输入姓名：</td>
                <td style="width: 164px">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Button ID="btnReset" runat="server" Text="重 置" OnClick="btnReset_Click" /></td>
            </tr>
            <tr>
                <td colspan="3" style="height: 15px">
                    <br />
                    <asp:Label ID="lblTitle" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td  valign ="top" colspan="3" style="height: 41px">
                    <asp:Label ID="lblResult" runat="server"></asp:Label></td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
