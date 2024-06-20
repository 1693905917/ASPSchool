<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="border:solid silver">
    <p>这是内容页</p>
<p>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p></div>
</asp:Content>


