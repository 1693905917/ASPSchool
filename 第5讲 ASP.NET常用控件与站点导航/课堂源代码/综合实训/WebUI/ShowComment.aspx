<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShowComment.aspx.cs" Inherits="ShowComment" Title="曙光大学BBS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <div style="text-align:left; line-height:20px">
        <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label><br/>
        <asp:DataList ID="DataList1" runat="server" Height="100%" Width="761px" 
            OnItemDataBound="DataList1_ItemDataBound" CellPadding="4" 
            ForeColor="#333333" style="text-align: left">
            <ItemTemplate>
                <table class="style2">
                    <tr>
                        <td class="style4">
                            <asp:Label ID="lblNumber" runat="server" Text="<%# GetNumber() %>"></asp:Label>.&nbsp;<%#Eval("Content")%>
                        </td>
                        <td class="style3">
                            <asp:Label ID="lblUser" runat="server" Text='<%# Eval("User") %>'></asp:Label>&nbsp;&nbsp;[<%#Eval("Time")%>]
                        </td>
                        <td>
                            <asp:LinkButton ID="lbtnReply" runat="server" 
                                CommandArgument='<%# Eval("User")%>' OnCommand="lbtnReply_Command">回复</asp:LinkButton>
                            &nbsp;
                            <asp:LinkButton ID="lbtnDelComment" runat="server" 
                                CommandArgument='<%#Eval("ID")%>' OnCommand="lbtnDelComment_Command" 
                                Visible="False">删除</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
            <SeparatorTemplate>
                <hr style="height: 1px" />
            </SeparatorTemplate>
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <AlternatingItemStyle BackColor="White" />
            <ItemStyle BackColor="#EFF3FB" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderTemplate>
                评论信息
            </HeaderTemplate>
        </asp:DataList>
        <br />
        <asp:LinkButton ID="lbtnFirst" runat="server" OnClick="lbtnFirst_Click">首页</asp:LinkButton>&nbsp; <asp:LinkButton
            ID="lbtnPre" runat="server" OnClick="lbtnPre_Click">上一页</asp:LinkButton>&nbsp; <asp:LinkButton
                ID="lbtnNext" runat="server" OnClick="lbtnNext_Click">下一页</asp:LinkButton>&nbsp; <asp:LinkButton
                    ID="lbtnEnd" runat="server" OnClick="lbtnEnd_Click">尾页</asp:LinkButton>&nbsp; 当前为第<asp:Label
                        ID="lblCur" runat="server"></asp:Label>页&nbsp;&nbsp; 共
        <asp:Label ID="lblTotal" runat="server"></asp:Label>页<br />
        <table style="width:761px">
            <tr>
                <td>
                    发表评论&nbsp; <asp:TextBox ID="txtNumber" runat="server" ReadOnly="True" BorderWidth="0px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
    <asp:TextBox ID="txtComment" runat="server" Rows="8" TextMode="MultiLine" 
        Width="641px" ValidationGroup="comment" Height="77px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtComment"
        Display="Dynamic" ErrorMessage="*" ValidationGroup="comment"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="提交" />
    <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="清空"/>
   
                </td>
            </tr>
        </table>
    </div>
   
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style3
        {
            width: 192px;
        }
        .style4
        {
            width: 472px;
        }
    </style>

</asp:Content>

