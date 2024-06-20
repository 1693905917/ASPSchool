<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
<div style="text-align: left">
    &nbsp;文件上传控件FileUpload使用示例<br />
    &nbsp;<table>
        <tr>
            <td style="width: 94px">
    <asp:Image ID="Image1" runat="server" /></td>
            <td colspan="2">
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td style="width: 94px">
<asp:FileUpload ID="FileUpload1" runat="server" Height="28px" /></td>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="上传" /></td>
        </tr>
        <tr>
            <td colspan="3">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
        </tr>
    </table>
</div>
        <br />
        <br />
        <br />
        <br />
        <br />
</form>

</body>
</html>
