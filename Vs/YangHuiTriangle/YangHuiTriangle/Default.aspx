﻿<%@ Page Language="C#"AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="YangHuiTriangle._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Generate Pascal's Triangle</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>生成杨辉三角</h2>
            <asp:Label ID="lblInput" runat="server" Text="请输入行数:"></asp:Label>
            <asp:TextBox ID="txtRows" runat="server"></asp:TextBox>
            <asp:Button ID="btnGenerate" runat="server" Text="生成" OnClick="btnGenerate_Click" />
            <br /><br />
            <asp:Literal ID="litTriangle" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>

 