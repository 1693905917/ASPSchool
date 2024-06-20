<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="wuc1.ascx" TagName="wuc1" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:wuc1 ID="Login" runat="server" />
        <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="提 交" /><br />
        <br />
        <asp:Label ID="LabelMsg" runat="server"></asp:Label><br />
        <br />
        <br />
        &nbsp;</div>
    </form>
</body>
</html>
