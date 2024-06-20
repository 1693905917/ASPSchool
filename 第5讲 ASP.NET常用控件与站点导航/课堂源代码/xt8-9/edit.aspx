<%@ Page Language="C#" AutoEventWireup="true" CodeFile="edit.aspx.cs" Inherits="edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 260px;
        }
        .style2
        {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FormView ID="FormView1" runat="server" DataKeyNames="uid" 
            DataSourceID="SqlDataSource1">
            <EditItemTemplate>
                <table border="1" class="style1">
                    <tr>
                        <td class="style2" colspan="2">
                            <b>修改记录</b></td>
                    </tr>
                    <tr>
                        <td>
                            编号</td>
                        <td>
                            <asp:Label ID="uidLabel1" runat="server" Text='<%# Eval("uid") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            姓名</td>
                        <td>
                            <asp:TextBox ID="unameTextBox" runat="server" Text='<%# Bind("uname") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            单位</td>
                        <td>
                            <asp:TextBox ID="uunitTextBox" runat="server" Text='<%# Bind("uunit") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            办公电话</td>
                        <td>
                            <asp:TextBox ID="officetelTextBox" runat="server" 
                                Text='<%# Bind("officetel") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            移动电话</td>
                        <td>
                            <asp:TextBox ID="mobilTextBox" runat="server" Text='<%# Bind("mobil") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            电子邮件</td>
                        <td>
                            <asp:TextBox ID="emailTextBox" runat="server" Text='<%# Bind("email") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                                CommandName="Update" Text="更新" />
                            &nbsp;
                            <asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" 
                                CommandName="Cancel" Text="取消" />
                        </td>
                    </tr>
                </table>
            </EditItemTemplate>
            <InsertItemTemplate>
                <table border="1" class="style1">
                    <tr>
                        <td class="style2" colspan="2">
                            <b>插入新记录</b></td>
                    </tr>
                    <tr>
                        <td>
                            编号</td>
                        <td>
                            <asp:TextBox ID="uidTextBox" runat="server" Text='<%# Bind("uid") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            姓名</td>
                        <td>
                            <asp:TextBox ID="unameTextBox" runat="server" Text='<%# Bind("uname") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            单位</td>
                        <td>
                            <asp:TextBox ID="uunitTextBox" runat="server" Text='<%# Bind("uunit") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            办公电话</td>
                        <td>
                            <asp:TextBox ID="officetelTextBox" runat="server" 
                                Text='<%# Bind("officetel") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            移动电话</td>
                        <td>
                            <asp:TextBox ID="mobilTextBox" runat="server" Text='<%# Bind("mobil") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            电子邮件</td>
                        <td>
                            <asp:TextBox ID="emailTextBox" runat="server" Text='<%# Bind("email") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            &nbsp;<asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                                CommandName="Insert" Text="插入" onclick="InsertButton_Click" />
                            &nbsp;
                            <asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" 
                                CommandName="Cancel" Text="取消" />
                        </td>
                    </tr>
                </table>
            </InsertItemTemplate>
            <ItemTemplate>
                <table border="1" class="style1">
                    <tr>
                        <td class="style2" colspan="2">
                            <b>查看记录</b></td>
                    </tr>
                    <tr>
                        <td>
                            编号</td>
                        <td>
                            <asp:Label ID="uidLabel" runat="server" Text='<%# Eval("uid") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            姓名</td>
                        <td>
                            <asp:Label ID="unameLabel" runat="server" Text='<%# Bind("uname") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            单位</td>
                        <td>
                            <asp:Label ID="uunitLabel" runat="server" Text='<%# Bind("uunit") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            办公电话</td>
                        <td>
                            <asp:Label ID="officeteleLabel" runat="server" Text='<%# Bind("officetel") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            移动电话</td>
                        <td>
                            <asp:Label ID="mobilLabel" runat="server" Text='<%# Bind("mobil") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            电子邮件</td>
                        <td>
                            <asp:Label ID="emailLabel" runat="server" Text='<%# Bind("email") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" 
                                CommandName="Edit" Text="编辑" onclick="EditButton_Click" />
                            &nbsp;
                            <asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" 
                                CommandName="Delete" Text="删除" onclick="DeleteButton_Click" />
                            &nbsp;
                            <asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" 
                                CommandName="New" Text="新建" onclick="NewButton_Click" />
                            &nbsp;
                            <asp:LinkButton ID="LinkBack" runat="server" onclick="LinkBack_Click">返回</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:FormView>
    
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConflictDetection="CompareAllValues" 
        ConnectionString="<%$ ConnectionStrings:addresslistConnectionString %>" 
        DeleteCommand="DELETE FROM [Tel] WHERE [uid] = @original_uid AND (([uname] = @original_uname) OR ([uname] IS NULL AND @original_uname IS NULL)) AND (([uunit] = @original_uunit) OR ([uunit] IS NULL AND @original_uunit IS NULL)) AND (([officetel] = @original_officetel) OR ([officetel] IS NULL AND @original_officetel IS NULL)) AND (([mobil] = @original_mobil) OR ([mobil] IS NULL AND @original_mobil IS NULL)) AND (([email] = @original_email) OR ([email] IS NULL AND @original_email IS NULL))" 
        InsertCommand="INSERT INTO [Tel] ([uid], [uname], [uunit], [officetel], [mobil], [email]) VALUES (@uid, @uname, @uunit, @officetel, @mobil, @email)" 
        OldValuesParameterFormatString="original_{0}" 
        SelectCommand="SELECT * FROM [Tel] WHERE ([uid] = @uid)" 
        
        UpdateCommand="UPDATE [Tel] SET [uname] = @uname, [uunit] = @uunit, [officetel] = @officetel, [mobil] = @mobil, [email] = @email WHERE [uid] = @original_uid AND (([uname] = @original_uname) OR ([uname] IS NULL AND @original_uname IS NULL)) AND (([uunit] = @original_uunit) OR ([uunit] IS NULL AND @original_uunit IS NULL)) AND (([officetel] = @original_officetel) OR ([officetel] IS NULL AND @original_officetel IS NULL)) AND (([mobil] = @original_mobil) OR ([mobil] IS NULL AND @original_mobil IS NULL)) AND (([email] = @original_email) OR ([email] IS NULL AND @original_email IS NULL))">
        <SelectParameters>
            <asp:QueryStringParameter Name="uid" QueryStringField="userid" Type="String" />
        </SelectParameters>
        <DeleteParameters>
            <asp:Parameter Name="original_uid" Type="String" />
            <asp:Parameter Name="original_uname" Type="String" />
            <asp:Parameter Name="original_uunit" Type="String" />
            <asp:Parameter Name="original_officetel" Type="String" />
            <asp:Parameter Name="original_mobil" Type="String" />
            <asp:Parameter Name="original_email" Type="String" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="uname" Type="String" />
            <asp:Parameter Name="uunit" Type="String" />
            <asp:Parameter Name="officetel" Type="String" />
            <asp:Parameter Name="mobil" Type="String" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="original_uid" Type="String" />
            <asp:Parameter Name="original_uname" Type="String" />
            <asp:Parameter Name="original_uunit" Type="String" />
            <asp:Parameter Name="original_officetel" Type="String" />
            <asp:Parameter Name="original_mobil" Type="String" />
            <asp:Parameter Name="original_email" Type="String" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="uid" Type="String" />
            <asp:Parameter Name="uname" Type="String" />
            <asp:Parameter Name="uunit" Type="String" />
            <asp:Parameter Name="officetel" Type="String" />
            <asp:Parameter Name="mobil" Type="String" />
            <asp:Parameter Name="email" Type="String" />
        </InsertParameters>
    </asp:SqlDataSource>
    </form>
</body>
</html>
