<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        <span style="font-size: 16pt; font-family: 华文行楷;"><span style="font-size: 24pt">员工信息查询系统</span><br />
        </span>
        <table style="width: 461px" border="1">
            <tr>
                <td style="width: 43px; height: 23px;">
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="lbtnName_Click">张三</asp:LinkButton></td>
                <td style="width: 68px; text-align: center; height: 23px;">
                    <asp:Label ID="Label1" runat="server" Text="姓 名" Font-Bold="True"></asp:Label></td>
                <td style="text-align: left; height: 23px; width: 66px;">
                    <asp:Label ID="lblName" runat="server"></asp:Label>&nbsp;</td>
                <td style="width: 68px; text-align: center; height: 23px;">
                    <asp:Label ID="Label3" runat="server" Text="性 别" Font-Bold="True"></asp:Label></td>
                <td style="text-align: left; height: 23px; width: 101px;">
                    <asp:Label ID="lblSex" runat="server"></asp:Label>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 43px; height: 25px; text-align: center;">
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="lbtnName_Click" TabIndex="1">李四</asp:LinkButton></td>
                <td style="width: 68px; height: 25px;">
                    &nbsp;</td>
                <td style="height: 25px; width: 66px;">
                    &nbsp;</td>
                <td style="width: 68px; height: 25px;">
                    &nbsp;</td>
                <td style="height: 25px; width: 101px;">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 43px; height: 25px; text-align: center;">
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="lbtnName_Click" TabIndex="2">王五</asp:LinkButton></td>
                <td style="width: 68px; height: 25px; text-align: center">
                    <asp:Label ID="Label5" runat="server" Text="出生年月" Font-Bold="True" ></asp:Label></td>
                <td style="height: 25px; text-align: left; width: 66px;">
                    <asp:Label ID="lblBirthday" runat="server"></asp:Label>&nbsp;</td>
                <td style="width: 68px; height: 25px; text-align: center">
                    <asp:Label ID="Label7" runat="server" Text="所属部门" Font-Bold="True"></asp:Label></td>
                <td style="height: 25px; text-align: left; width: 101px;">
                    <asp:Label ID="lblBranch" runat="server"></asp:Label>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 43px; height: 25px; text-align: center;">
                    <asp:LinkButton ID="LinkButton4" runat="server" OnClick="lbtnName_Click" TabIndex="3">赵六</asp:LinkButton></td>
                <td style="width: 68px; height: 25px">
                    &nbsp;</td>
                <td style="height: 25px; width: 66px;">
                    &nbsp;</td>
                <td style="width: 68px; height: 25px">
                    &nbsp;</td>
                <td style="height: 25px; width: 101px;">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 43px; height: 25px; text-align: center;">
                    <asp:LinkButton ID="LinkButton5" runat="server" OnClick="lbtnName_Click" TabIndex="4">陈七</asp:LinkButton></td>
                <td style="width: 68px; height: 25px; text-align: center">
                    <asp:Label ID="Label9" runat="server" Text="职 务" Font-Bold="True"></asp:Label></td>
                <td style="height: 25px; text-align: left; width: 66px;">
                    <asp:Label ID="lblDuty" runat="server"></asp:Label>&nbsp;</td>
                <td style="width: 68px; height: 25px; text-align: center">
                    <asp:Label ID="Label11" runat="server" Text="电 话" Font-Bold="True"></asp:Label></td>
                <td style="height: 25px; text-align: left; width: 101px;">
                    <asp:Label ID="lblPhone" runat="server"></asp:Label>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 43px; height: 25px; text-align: center;">
                    <asp:LinkButton ID="LinkButton6" runat="server" OnClick="lbtnName_Click" TabIndex="5">刘八</asp:LinkButton></td>
                <td style="width: 68px; height: 25px">
                    &nbsp;</td>
                <td style="height: 25px; width: 66px;">
                    &nbsp;</td>
                <td style="width: 68px; height: 25px">
                    &nbsp;</td>
                <td style="height: 25px; width: 101px;">
                    &nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
