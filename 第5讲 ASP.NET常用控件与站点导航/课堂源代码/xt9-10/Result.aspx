<%@ Page Language="C#" AutoEventWireup="true" CodeFile="result.aspx.cs" Inherits="result" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LabelTitle" runat="server"></asp:Label><br />
        <br />
        <table border="1" style="height: 97px">
            <tr>
                <td style="width: 63px">
                    姓名</td>
                <td style="width: 87px">
                    <asp:Label ID="LabelName" runat="server"></asp:Label>&nbsp;</td>
                <td style="width: 63px">
                    数学</td>
                <td style="width: 87px">
                    <asp:Label ID="LabelMath" runat="server"></asp:Label>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 63px">
                    性别</td>
                <td style="width: 87px">
                    <asp:Label ID="LabelSex" runat="server"></asp:Label>&nbsp;</td>
                <td style="width: 63px">
                    语文</td>
                <td style="width: 87px">
                    <asp:Label ID="LabelChs" runat="server"></asp:Label>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 63px">
                    班级</td>
                <td style="width: 87px">
                    <asp:Label ID="LabelClass" runat="server"></asp:Label>&nbsp;</td>
                <td style="width: 63px">
                    英语</td>
                <td style="width: 87px">
                    <asp:Label ID="LabelEn" runat="server"></asp:Label>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
        <asp:Label ID="LabelTotal" runat="server"></asp:Label><br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
