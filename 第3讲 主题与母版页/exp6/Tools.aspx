<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Tools.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style5
    {
        width: 100%;
    }
    .style6
    {
        height: 22px;        
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style5">
    <tr>
        <td class="style6">
            <b>工具软件类图书列表：</b></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBoxList ID="CheckBookName" runat="server">
                
            </asp:CheckBoxList>
        </td>
    </tr>
</table>
</asp:Content>

