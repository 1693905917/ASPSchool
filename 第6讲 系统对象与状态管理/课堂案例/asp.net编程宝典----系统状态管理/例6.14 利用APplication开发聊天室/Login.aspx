<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>登录</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="box">
  <table width="254" height="66" border="0">
    <tr>
      <td width="46" height="32" align="center">昵称：</td>
      <td width="198">
                    <asp:TextBox ID="TextBox1" runat="server" Width="113px"></asp:TextBox></td>
    </tr>
    <tr>
      <td height="32" colspan="2" align="center">
          <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/1_03.gif" 
              onclick="ImageButton1_Click" />
        </td>
    </tr>
  </table>
</div>
    </form>
</body>
</html>
