<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>在线投票系统</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            font-size: small;
            color: #0066CC;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<div id="box">
  <table width="370" border="0">
    <tr>
      <td width="364" height="37" class="style1">您对本公司的售后服务是否满意？</td>
    </tr>
    <tr>
      <td height="106">
          <asp:RadioButtonList ID="RadioButtonList1" runat="server" Font-Size="9pt">
              <asp:ListItem Selected="True">非常满意</asp:ListItem>
              <asp:ListItem>基本满意</asp:ListItem>
              <asp:ListItem>不满意</asp:ListItem>
          </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
      <td height="30" align="center">
          <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/dc_03.gif" 
              onclick="ImageButton1_Click" />
          　　　　　　<img src="images/dc_05.gif" width="82" height="33" onclick="window.location.replace('result.aspx')"  style="cursor:pointer"/></td>
    </tr>
  </table>
</div>

    </form>
</body>
</html>
