<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>�ޱ���ҳ</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="smdsTree">
        </asp:TreeView>
        <asp:SiteMapDataSource ID="smdsTree" runat="server" />
    </div>
    </form>
</body>
</html>
