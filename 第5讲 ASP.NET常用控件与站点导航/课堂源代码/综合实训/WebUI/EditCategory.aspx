<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EditCategory.aspx.cs" Inherits="ShowCategory" Title="" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <span style="font-size:x-large;"><b>版块维护</b></span>
    <asp:DataList ID="DataList1" runat="server" BackColor="#CCCCCC" Width="762px" 
        OnItemDataBound="DataList1_ItemDataBound1" style="text-align: left" 
        Height="159px" >        
        <ItemTemplate>
            <table  class="style2">
                <tr>
                    <td class="style3">
                        版块：<%#Eval("Category")%>
                    </td>
                    <td class="style4">
                        版主：<%#Eval("CategoryOwner") %> 
                    </td>
                    <td class="style5">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:LinkButton ID="lbtnDel" runat="server" CommandArgument='<%#Eval("ID")%>' 
                            OnCommand="lbtnDel_Command">删除版块</asp:LinkButton>
                    </td>
                </tr>
            </table>           
        </ItemTemplate>
        <AlternatingItemStyle BackColor="#FFFBD6" />        
    </asp:DataList>
    <asp:Panel ID="Panel1" runat="server" style="width:758px; margin-left: 0px;" 
        Height="144px">
        <table style="width:758px; height: 140px;" border="1">
            <tr>
                <td style="text-align: left">
                    添加版块&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td style="text-align: left">
                    &nbsp; 版块名：<asp:TextBox ID="txtVersionName" runat="server" 
                    ValidationGroup="versionname"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtVersionName"
        Display="Dynamic" ErrorMessage="*" ValidationGroup="versionname"></asp:RequiredFieldValidator>
                    &nbsp;<asp:Button ID="btnAdd" runat="server"  Text="添加" 
                        OnClick="btnAdd_Click" />
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: left">
                    修改版块名称 
                </td>
                <td style="text-align: left">
                    将版块&nbsp;
                    <asp:DropDownList ID="ddlCate" runat="server">
                    </asp:DropDownList>
                    &nbsp; 修改为&nbsp;&nbsp;<asp:TextBox ID="txtCategoryTitle" runat="server" 
                        ValidationGroup="category"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtCategoryTitle" Display="Dynamic" ErrorMessage="*" 
                        ValidationGroup="category"></asp:RequiredFieldValidator>
                    &nbsp;<asp:Button ID="btnChangeTitle" runat="server" OnClick="btnChangeTitle_Click" 
                    Text="确定" />
                </td>
            </tr>
            <tr>
                <td style="text-align: left">
                    修改版主 
                </td>
                <td style="text-align: left">
                    将版块&nbsp;
                    <asp:DropDownList ID="ddlCategory" runat="server">
                    </asp:DropDownList>
                    &nbsp; 修改版主为 
                    <asp:DropDownList ID="ddlUser" runat="server">
                    </asp:DropDownList>
                    &nbsp;<asp:Button ID="btnChangeOwner" runat="server" OnClick="btnChangeOwner_Click" 
                    Text="确定"  />
                </td>
            </tr>
        </table>
    </asp:Panel>
    
       
    </asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
    .style3
    {
        width: 425px;
    }
    .style4
    {
        width: 159px;
    }
    .style5
    {
        width: 293px;
        text-align: center;
    }
</style>


</asp:Content>


