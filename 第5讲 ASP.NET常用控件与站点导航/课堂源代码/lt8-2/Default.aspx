<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 280px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FormView ID="FormView1" runat="server" DataKeyNames="StuNo" 
            DataSourceID="SqlDataSource1" AllowPaging="True">
            <EditItemTemplate>
                <center><b>修改记录</b><center><table class="style1" border="1">
                    <tr>
                        <td style="text-align: left">
                            学号</td>
                        <td>
                            <asp:Label ID="StuNoLabel1" runat="server" Text='<%# Eval("StuNo") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: left">
                            姓名</td>
                        <td>
                            <asp:TextBox ID="StuNameTextBox" runat="server" Text='<%# Bind("StuName") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: left">
                            性别</td>
                        <td>
                            <asp:TextBox ID="StuSexTextBox" runat="server" Text='<%# Bind("StuSex") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: left">
                            年龄</td>
                        <td>
                            <asp:TextBox ID="StuAgeTextBox" runat="server" Text='<%# Bind("StuAge") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: left">
                            政治面貌</td>
                        <td>
                            <asp:TextBox ID="StuPolityTextBox" runat="server" 
                                Text='<%# Bind("StuPolity") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: left">
                            籍贯</td>
                        <td>
                            <asp:TextBox ID="StuHomeTextBox" runat="server" Text='<%# Bind("StuHome") %>' />
                        </td>
                    </tr>
                </table>
                &nbsp;<br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                    CommandName="Update" Text="更新" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                    CausesValidation="False" CommandName="Cancel" Text="取消" />
            </EditItemTemplate>
            <InsertItemTemplate>
                <center><b>插入记录</b></center><table class="style1" border="1">
                    <tr>
                        <td>
                            学号</td>
                        <td>
                            <asp:TextBox ID="StuNoTextBox" runat="server" Text='<%# Bind("StuNo") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            姓名</td>
                        <td>
                            <asp:TextBox ID="StuNameTextBox" runat="server" Text='<%# Bind("StuName") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            性别</td>
                        <td>
                            <asp:TextBox ID="StuSexTextBox" runat="server" Text='<%# Bind("StuSex") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            年龄</td>
                        <td>
                            <asp:TextBox ID="StuAgeTextBox" runat="server" Text='<%# Bind("StuAge") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            政治面貌</td>
                        <td>
                            <asp:TextBox ID="StuPolityTextBox" runat="server" 
                                Text='<%# Bind("StuPolity") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            籍贯</td>
                        <td>
                            <asp:TextBox ID="StuHomeTextBox" runat="server" Text='<%# Bind("StuHome") %>' />
                        </td>
                    </tr>
                </table>
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                    CommandName="Insert" Text="插入" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
                    CausesValidation="False" CommandName="Cancel" Text="取消" />
            </InsertItemTemplate>
            <ItemTemplate>
                <center><b>学生基本情况</b></center><table class="style1" border="1">
                    <tr>
                        <td>
                            学号</td>
                        <td>
                            <asp:Label ID="StuNoLabel" runat="server" Text='<%# Eval("StuNo") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            姓名</td>
                        <td>
                            <asp:Label ID="StuNameLabel" runat="server" Text='<%# Bind("StuName") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            性别</td>
                        <td>
                            <asp:Label ID="StuSexLabel" runat="server" Text='<%# Bind("StuSex") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            年龄</td>
                        <td>
                            <asp:Label ID="StuAgeLabel" runat="server" Text='<%# Bind("StuAge") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            政治面貌</td>
                        <td>
                            <asp:Label ID="StuPolityLabel" runat="server" Text='<%# Bind("StuPolity") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            籍贯</td>
                        <td>
                            <asp:Label ID="StuHomeLabel" runat="server" Text='<%# Bind("StuHome") %>' />
                        </td>
                    </tr>
                </table>
                &nbsp;<br />
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" 
                    CommandName="Edit" Text="编辑" />
                &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" 
                    CommandName="Delete" Text="删除" />
                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" 
                    CommandName="New" Text="新建" />
            </ItemTemplate>
        </asp:FormView>
    
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConflictDetection="CompareAllValues" 
        ConnectionString="<%$ ConnectionStrings:stduentConnectionString %>" 
        DeleteCommand="DELETE FROM [StuInfo] WHERE [StuNo] = @original_StuNo AND [StuName] = @original_StuName AND (([StuSex] = @original_StuSex) OR ([StuSex] IS NULL AND @original_StuSex IS NULL)) AND (([StuAge] = @original_StuAge) OR ([StuAge] IS NULL AND @original_StuAge IS NULL)) AND (([StuPolity] = @original_StuPolity) OR ([StuPolity] IS NULL AND @original_StuPolity IS NULL)) AND (([StuHome] = @original_StuHome) OR ([StuHome] IS NULL AND @original_StuHome IS NULL))" 
        InsertCommand="INSERT INTO [StuInfo] ([StuNo], [StuName], [StuSex], [StuAge], [StuPolity], [StuHome]) VALUES (@StuNo, @StuName, @StuSex, @StuAge, @StuPolity, @StuHome)" 
        OldValuesParameterFormatString="original_{0}" 
        SelectCommand="SELECT * FROM [StuInfo]" 
        UpdateCommand="UPDATE [StuInfo] SET [StuName] = @StuName, [StuSex] = @StuSex, [StuAge] = @StuAge, [StuPolity] = @StuPolity, [StuHome] = @StuHome WHERE [StuNo] = @original_StuNo AND [StuName] = @original_StuName AND (([StuSex] = @original_StuSex) OR ([StuSex] IS NULL AND @original_StuSex IS NULL)) AND (([StuAge] = @original_StuAge) OR ([StuAge] IS NULL AND @original_StuAge IS NULL)) AND (([StuPolity] = @original_StuPolity) OR ([StuPolity] IS NULL AND @original_StuPolity IS NULL)) AND (([StuHome] = @original_StuHome) OR ([StuHome] IS NULL AND @original_StuHome IS NULL))">
        <DeleteParameters>
            <asp:Parameter Name="original_StuNo" Type="String" />
            <asp:Parameter Name="original_StuName" Type="String" />
            <asp:Parameter Name="original_StuSex" Type="String" />
            <asp:Parameter Name="original_StuAge" Type="Int32" />
            <asp:Parameter Name="original_StuPolity" Type="String" />
            <asp:Parameter Name="original_StuHome" Type="String" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="StuName" Type="String" />
            <asp:Parameter Name="StuSex" Type="String" />
            <asp:Parameter Name="StuAge" Type="Int32" />
            <asp:Parameter Name="StuPolity" Type="String" />
            <asp:Parameter Name="StuHome" Type="String" />
            <asp:Parameter Name="original_StuNo" Type="String" />
            <asp:Parameter Name="original_StuName" Type="String" />
            <asp:Parameter Name="original_StuSex" Type="String" />
            <asp:Parameter Name="original_StuAge" Type="Int32" />
            <asp:Parameter Name="original_StuPolity" Type="String" />
            <asp:Parameter Name="original_StuHome" Type="String" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="StuNo" Type="String" />
            <asp:Parameter Name="StuName" Type="String" />
            <asp:Parameter Name="StuSex" Type="String" />
            <asp:Parameter Name="StuAge" Type="Int32" />
            <asp:Parameter Name="StuPolity" Type="String" />
            <asp:Parameter Name="StuHome" Type="String" />
        </InsertParameters>
    </asp:SqlDataSource>
    </form>
</body>
</html>
