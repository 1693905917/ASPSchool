<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NavigatePage.aspx.cs" Inherits="NavigatePage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
   <table   bgcolor="#ffffcc" border="1" bordercolor="#000000">
            <tr>
                <td colspan="2" >
        <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="True" Font-Names="隶书" ForeColor="Red"></asp:Label>
                   <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="隶书" ForeColor="Red"
                        Text="Label"></asp:Label></td>
               
            </tr>
       <tr>
           <td colspan="2">
               <asp:Label ID="Label2" runat="server" Text="欢迎您登录明日网站" Font-Bold="True" Font-Names="隶书" ForeColor="Red"></asp:Label></td>
       </tr>
            
        </table>
        &nbsp;&nbsp;
    
    </form>
</body>
</html>
