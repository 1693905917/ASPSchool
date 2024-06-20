<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width:95%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" 
            DataKeyNames="userid" DataSourceID="LinqDataSource1" Width="317px" 
            oniteminserted="FormView1_ItemInserted" >
            <EditItemTemplate>
                <table border="1" class="style1">
                    <tr>
                        <td colspan="2" style="text-align: center">
                            <b>修改记录</b></td>
                    </tr>
                    <tr>
                        <td>
                            编号</td>
                        <td>
                            <asp:Label ID="useridLabel1" runat="server" Text='<%# Eval("userid") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            用户名</td>
                        <td>
                            <asp:TextBox ID="usernameTextBox" runat="server" 
                                Text='<%# Bind("username") %>' Width="137px" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            密码</td>
                        <td>
                            <asp:TextBox ID="userpasswordTextBox" runat="server" 
                                
                                Text='<%# Bind("userpassword") %>' TextMode="Password" width="137px" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                                CommandName="Update" Text="更新"  />
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
                        <td colspan="2" style="text-align: center">
                            <b>添加新用户</b></td>
                    </tr>
                    <tr>
                        <td>
                            编号</td>
                        <td>
                            <asp:TextBox ID="TextUID" runat="server" 
                                Text='<%# Bind("userid") %>' Width="131px" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            用户名</td>
                        <td>
                            <asp:TextBox ID="TextUName" runat="server"
                                Text='<%# Bind("username") %>' width="131px" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            密码</td>
                        <td>
                            <asp:TextBox ID="TextUPwd" runat="server"
                                Text='<%# Bind("userpassword") %>' TextMode="Password" width="131px" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            确认密码</td>
                        <td>
                            <asp:TextBox ID="TextReUPwd" runat="server" TextMode="Password" 
                                width="131px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                                CommandName="Insert" Text="插入"  />
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
                        <td colspan="2" style="text-align: center">
                            <b>浏览记录</b></td>
                    </tr>
                    <tr>
                        <td>
                            编号</td>
                        <td>
                            <asp:Label ID="useridLabel" runat="server" Text='<%# Eval("userid") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            用户名</td>
                        <td>
                            <asp:Label ID="usernameLabel" runat="server" Text='<%# Bind("username") %>' />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            密码</td>
                        <td>
                            **********</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" 
                                CommandName="Edit" Text="编辑" />
                            &nbsp;
                            <asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" 
                                CommandName="Delete" Text="删除" />
                            &nbsp;
                            <asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" 
                                CommandName="New" Text="新建" />
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:FormView>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
            ContextTypeName="DataClassesDataContext" EnableDelete="True" 
            EnableInsert="True" EnableUpdate="True" TableName="user" 
            oninserting="LinqDataSource1_Inserting">
        </asp:LinqDataSource>
    
    </div>
    </form>
</body>
</html>
