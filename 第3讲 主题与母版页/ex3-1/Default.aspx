<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Theme="NewTheme"  %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>使用主题和外观文件</title>
   
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <asp:Panel ID="Panel1" runat="server" Height="184px" Width="400px">Panel1
            <br /> <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />   
                <br />
            
                <asp:Panel ID="Panel2" runat="server" Height="80px" Width="220px" 
                SkinID="BgPanel">
                    <br />
                    Panel2
                </asp:Panel>
            
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
