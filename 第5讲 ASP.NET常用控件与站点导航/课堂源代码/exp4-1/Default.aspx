<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1">
            <tr>
                <td colspan="4">
                    <asp:Label ID="LabelInfo" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 100px; text-align: center">
                    <asp:Button ID="ButtonDateTime" runat="server" OnClick="ButtonDateTime_Click" 
                        Text="日期时间" /></td>
                <td style="width: 100px; text-align: center">
                    <asp:Button ID="ButtonMath" runat="server" OnClick="ButtonMath_Click" 
                        Text="数 学" /></td>
                <td style="width: 100px; text-align: center">
                    <asp:Button ID="ButtonString" runat="server" OnClick="ButtonString_Click" 
                        Text="字符串" /></td>
                <td style="width: 100px; text-align: center">
                    <asp:Button ID="ButtonRandom" runat="server" OnClick="ButtonRandom_Click" 
                        Text="随机数" /></td>
            </tr>
        </table>
        <br />
        <br />
        &nbsp;&nbsp;
    
    </div>
    </form>
</body>
</html>
