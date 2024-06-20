<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td style="width: 112px">
                    请输入x的值：</td>
                <td style="width: 38px">
                    <asp:TextBox ID="txtX" runat="server"></asp:TextBox></td>
                <td style="width: 50px">
                    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="确 定" /></td>
            </tr>
            <tr>
                <td style="width: 112px">
                </td>
                <td style="width: 38px">
                </td>
                <td style="width: 50px">
                </td>
            </tr>
            <tr>
                <td style="width: 112px">
                    函数y的值为：</td>
                <td style="width: 38px">
                    <asp:Label ID="lblY" runat="server" Width="155px"></asp:Label></td>
                <td style="width: 50px">
                </td>
            </tr>
        </table>
    
    </div>
        <br />
        <br />
    </form>
</body>
</html>
