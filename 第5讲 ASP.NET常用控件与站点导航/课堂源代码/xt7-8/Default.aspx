<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="False" 
            UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="按钮1" />
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="按钮2" />
                <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="按钮3" />
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="Button2" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
        <br />
    
    </div>
    </form>
</body>
</html>
