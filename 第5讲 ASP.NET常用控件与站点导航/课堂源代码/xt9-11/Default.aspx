<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 354px">
            <tr>
                <td colspan="3" style="text-align: center">
                    <strong><span style="font-size: 14pt">欢迎使用课表查询系统</span></strong></td>
            </tr>
            <tr>
                <td style="width: 240px">
                    请选择一个班级</td>
                <td style="width: 144px">
                    <asp:DropDownList ID="DropClass" runat="server" Width="119px">
                    </asp:DropDownList></td>
                <td style="width: 100px">
                    <asp:Button ID="ButtonOK" runat="server" OnClick="ButtonOK_Click" Text="确 定" /></td>
            </tr>
        </table>
    
    </div>
        <br />
        <br />
    </form>
</body>
</html>
