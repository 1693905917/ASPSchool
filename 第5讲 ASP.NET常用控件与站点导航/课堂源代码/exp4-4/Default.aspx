<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong><span style="font-size: 16pt">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; 商场收款程序<br />
        </span></strong>
        <br />
        商品编号：<asp:TextBox ID="TextSerial" runat="server" Width="52px"></asp:TextBox>&nbsp;
        数量：<asp:TextBox ID="TextAmount" runat="server" Width="52px"></asp:TextBox>&nbsp;
        <asp:Button ID="ButtonOK" runat="server" OnClick="ButtonOK_Click" Text="确 定" />
        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="返 回" /><br />
        <br />
        <asp:Label ID="LabelBill" runat="server"></asp:Label><br />
        <br />
    
    </div>
    </form>
</body>
</html>
