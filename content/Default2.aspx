<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
    onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" 
    RepeatDirection="Horizontal" RepeatLayout="Flow" Width="448px">
    <asp:ListItem>aaa</asp:ListItem>
    <asp:ListItem>bbb</asp:ListItem>
    <asp:ListItem>ccc</asp:ListItem>
    <asp:ListItem>ddd</asp:ListItem>
</asp:RadioButtonList>
</asp:Content>

