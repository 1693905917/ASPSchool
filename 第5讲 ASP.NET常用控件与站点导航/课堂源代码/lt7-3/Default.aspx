<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 204px">
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="False" 
            UpdateMode="Conditional">
            <ContentTemplate>
            <fieldset style="width:173px">
            <legend>更新区域1</legend>
            
                <asp:ListBox ID="ListBox1" runat="server" Height="80px" Width="173px" >
                </asp:ListBox>
                </fieldset>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="ItemAdd" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="ItemDec" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
            <fieldset style="width:173px">
            <legend>更新区域2</legend>
                <br />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="ItemAdd" runat="server" Text="增 加" onclick="ItemAdd_Click" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="ItemDec" runat="server" Text="减 少" onclick="ItemDec_Click" />
                </fieldset> 
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
