
<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LeaveMessage.aspx.cs" Inherits="LeaveMessage" Title="" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <asp:Panel ID="Panel1" runat="server" Width="761px">
        <div style="text-align: left; width: 756px;">
            <table>
                <tr>
                    <td class="style3" style="text-align: center">
                        发表帖子</td>
                </tr>
                <tr>
                    <td>
                        版面：<asp:DropDownList ID="ddlVersion" runat="server">
                        </asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    帖子标题：<asp:TextBox ID="txtTitle" runat="server" ValidationGroup="message" 
            Width="179px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtTitle"
            Display="Dynamic" ErrorMessage="必须填写标题（少于20个字符）" ValidationGroup="message"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtContent" runat="server" Height="383px" TextMode="MultiLine" 
            Width="754px" ValidationGroup="message"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="提交" OnClick="btnSubmit_Click"  
                        ValidationGroup="message" />
                        &nbsp;
                        <asp:Button ID="btnClear" runat="server" Text="清空" OnClick="btnClear_Click" 
                        ValidationGroup="message" />
                    </td>
                </tr>
            </table>
        </div>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style3
        {
            font-size: x-large;
            font-weight: bold;
        }
    </style>

</asp:Content>

