<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width:765px;
            height: 32px;
            border-color: Silver;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td>
                这是内容页区域</td>
        </tr>
        <tr>
            <td style="height:74px; border: solid 1px silver;">
                内容页的具体内容文本、图片等</td>
        </tr>
    </table>
</asp:Content>

