<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="header.ascx" TagName="header" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1" style="width: 472px">
            <tr>
                <td colspan="3">
                    <uc1:header ID="Header1" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center">
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
            </table>
    
    </div>
    </form>
</body>
</html>
