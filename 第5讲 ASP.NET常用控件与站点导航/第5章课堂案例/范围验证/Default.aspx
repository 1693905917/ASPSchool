<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        输入学号：<asp:TextBox ID="txtNum" runat="server" Width="83px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNum"
            ErrorMessage="RequiredFieldValidator">必须输入学号！</asp:RequiredFieldValidator><br />
        <br />
        输入成绩：<asp:TextBox ID="txtScore" runat="server" Width="83px"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtScore"
            ErrorMessage="RangeValidator" MaximumValue="100" MinimumValue="0" Type="Integer">成绩值应在0～100之间</asp:RangeValidator><br />
        <br />
        <asp:Button ID="btmOK" runat="server" OnClick="btnOK_Click" Text="提 交" />
        &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Label ID="lblMsg" runat="server"></asp:Label><br />
        <br />
        <br />
        &nbsp;<br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
