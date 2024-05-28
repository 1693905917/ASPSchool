<%@ Page Language="C#" AutoEventWireup="true" CodeFile="right.aspx.cs" Inherits="right" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>聊天室</title>
<meta http-equiv="refresh" content="1">

<%--<object id ="webBrowser" width =0 height =0 classid="CLSID:8856F961-340A-11D0-A96B-00C04FD705A2" >
  webBrowser.ExecWB(22,1)   
</object>--%>
</head>
<body bgcolor ="#ffff66"> 
<form id="form1" runat="server">
<table width="100%" border="0">
      <tr height =20>
        <td   valign="top" align="center" style="font-weight: bolder; font-size: x-large; vertical-align: middle; text-transform: uppercase; color: #ff6666; font-family: 隶书, Cursive; background-color: #ffffcc; text-align: center" bgcolor="#ffff66" bordercolor="#ff00ff">
            明日聊天室欢迎您！</td>
        </tr>
    <tr>
        <td  valign="top" style="height: 178px">
            <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="100%" AutoPostBack="True" BackColor="#FFFFC0" BorderColor="Fuchsia" BorderStyle="Outset" BorderWidth="1px" Font-Bold="True" Font-Names="隶书" ForeColor="Red" Height="247px" ToolTip="公聊显示框" Rows="40" Font-Size="X-Large"></asp:TextBox></td>
    </tr>
      <tr>
        <td  valign="top" style="height: 210px">
            <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Width="100%" AutoPostBack="True" BackColor="#FFFFC0" BorderColor="Fuchsia" BorderStyle="Outset" BorderWidth="1px" Font-Bold="True" Font-Names="隶书" ForeColor="Red" Height="202px" ReadOnly="True" Rows="40" ToolTip="私聊显示框" Font-Size="X-Large" ></asp:TextBox></td>
      </tr>
    </table> 
    </form>
</body>

</html>
