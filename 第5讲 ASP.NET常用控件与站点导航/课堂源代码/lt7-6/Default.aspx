<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default2" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <script type="text/javascript">
    
      function pageLoad() {
      }
    
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Button" />
        <cc1:ConfirmButtonExtender ID="Button1_ConfirmButtonExtender" runat="server" 
            ConfirmText="数据将被删除，请确认！" Enabled="True" TargetControlID="Button1">
        </cc1:ConfirmButtonExtender>
    </div>
    </form>
</body>
</html>
