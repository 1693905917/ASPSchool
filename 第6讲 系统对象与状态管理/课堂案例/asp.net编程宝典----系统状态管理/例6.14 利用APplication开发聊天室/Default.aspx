<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>聊天室</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="box2">
  <div id="a1"></div>
  <div id="a2"><table width="650" height="278" border="0">
  <tr>
    <td width="8" height="16">&nbsp;</td>
    <td width="430">&nbsp;</td>
    <td width="16">&nbsp;</td>
    <td width="165">&nbsp;</td>
    <td width="9">&nbsp;</td>
  </tr>
  <tr>
    <td height="244">&nbsp;</td>
    <td>
                <iframe id="I1" src="Content.aspx" runat="server" scrolling="no" 
            noresize="noResize" frameborder="0" style="width: 421px; height: 228px" 
            name="I1" ></iframe>
                        </td>
    <td>&nbsp;</td>
    <td>
                <iframe id="I2" src="List.aspx" runat="server" frameborder="no" 
            noresize="noResize" scrolling="no" style="width: 151px; height: 220px" 
            name="I2"></iframe>
                        </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td height="16">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table>
</div>
  <div id="a3"><table width="639" height="36" border="0">
  <tr>
    <td width="34" height="29">&nbsp;</td>
    <td width="420">
                    <asp:TextBox ID="txtMessage" runat="server" Width="316px"></asp:TextBox></td>
    <td width="171">　　<asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/images/2_06.gif" onclick="ImageButton1_Click" />
&nbsp;
        <asp:ImageButton ID="ImageButton2" runat="server" 
            ImageUrl="~/images/2_06-02.gif" onclick="ImageButton2_Click" />
                        </td>
  </tr>
</table>
</div>
</div>
    </form>
</body>
</html>
