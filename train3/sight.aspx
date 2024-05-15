<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="sight.aspx.cs" Inherits="sight" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height: 150px; text-align:center; padding-top:2px;">    
        <asp:Image ID="Image1" runat="server" Height="147px" Width="170px" 
            ImageUrl="~/images/1.jpg" />
        &nbsp;<asp:Image ID="Image2" runat="server" Height="147px" Width="170px" 
            ImageUrl="~/images/2.jpg" />
        &nbsp;<asp:Image ID="Image3" runat="server" Height="147px" Width="170px" 
            ImageUrl="~/images/3.jpg" />
    </div>
    
</asp:Content>

