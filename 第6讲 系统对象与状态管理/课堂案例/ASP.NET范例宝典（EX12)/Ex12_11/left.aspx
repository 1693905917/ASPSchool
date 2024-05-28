<%@ Page Language="C#" AutoEventWireup="true" CodeFile="left.aspx.cs" Inherits="left" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

<head runat="server">
    <title>名单</title>
    <meta http-equiv ="refresh" content ="5;URL=left.aspx" />
</head>
<body bgcolor ="#ffff66">
    <form id="form1" runat="server">
    <table  border="0" width =100%>
  <tr>
    <td valign="top" style="font-weight: bolder; vertical-align: left; text-transform: uppercase; color: #ff6666; font-family: 隶书, Cursive; background-color: #ffffcc">【<span>欢迎</span>】<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> 
      <span style="font-weight: bolder; font-size: medium; color: #ff6666; font-family: 隶书, Cursive; background-color: #ffffcc; text-align: left" >进入聊天室</span></td>
  </tr>
  <tr>
    <td valign="top" style="font-weight: bolder; font-size: medium; color: #ff6666; font-family: 隶书, Cursive; background-color: #ffffcc; text-align: left" >
    【<span>当前在现人数为：</span>】<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
      
    </td>
 </tr>
        <tr>
            <td valign="top" style="font-weight: bolder; font-size: medium; color: #ff6666; font-family: 隶书, Cursive; background-color: #ffffcc; text-align: left; height: 458px;"  >
                <asp:ListBox ID="ListBox1" runat="server" Width="248px" BackColor="#FFFFC0" Font-Bold="True" Font-Names="隶书" Font-Size="Large" ForeColor="Red" Height="454px" ></asp:ListBox></td>
        </tr>
 
</table>
       
    </form>
</body>
</html>
