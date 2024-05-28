<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bottom.aspx.cs" Inherits="bottom" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body bgcolor ="#ffff66">
    <form id="form1" runat="server">
     <table width="963" height="65" border="0">
   <tr>
     <td width="953" style="height: 61px; font-size: medium; color: #ff6666; font-family: 隶书, Cursive; background-color: #ffffcc; text-align: left;">
         <asp:CheckBox ID="CheckBox1" runat="server" Text="私聊" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />&nbsp; 对<asp:DropDownList
             ID="DropDownList1" runat="server">
         </asp:DropDownList>&nbsp; 说:
         <asp:TextBox ID="TextBox2" runat="server" Width="381px"></asp:TextBox>
         &nbsp;&nbsp;
         <asp:Button ID="Button1" runat="server" Text="我要发言" OnClick="Button1_Click" />
         <asp:Button ID="Button2" runat="server" Text="退出聊天室" OnClick="Button2_Click" /></td>
   </tr>
 </table>
    </form>
</body>
</html>
