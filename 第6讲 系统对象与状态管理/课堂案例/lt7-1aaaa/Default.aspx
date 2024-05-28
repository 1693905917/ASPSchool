<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong>&nbsp; &nbsp; &nbsp; &nbsp; Page对象的Load事件与Init事件的比较<br />
        </strong>&nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <br />
        <table style="width: 365px; height: 205px">
            <tr>
                <td>
                    在Page_Load事件中填充</td>
                <td>
                    在Page_Init事件中填充</td>
            </tr>
            <tr>
                <td>
                    <asp:ListBox ID="ListBox1" runat="server" Height="114px"></asp:ListBox></td>
                <td>
                    <asp:ListBox ID="ListBox2" runat="server" Height="114px"></asp:ListBox></td>
            </tr>
            <tr>
                <td>
        <asp:Button ID="Button1" runat="server"  Text="引起回发" OnInit="Button1_Init" /></td>
                <td>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<br />
        <br />
        &nbsp;
    </div>
    </form>
</body>
</html>
