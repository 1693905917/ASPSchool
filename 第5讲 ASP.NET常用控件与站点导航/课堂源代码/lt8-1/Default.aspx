<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            ConflictDetection="CompareAllValues" DataFile="~/App_Data/employee.mdb" 
            DeleteCommand="DELETE FROM [employee] WHERE (([eid] = ?) OR ([eid] IS NULL AND ? IS NULL)) AND (([ename] = ?) OR ([ename] IS NULL AND ? IS NULL)) AND (([esex] = ?) OR ([esex] IS NULL AND ? IS NULL)) AND (([eage] = ?) OR ([eage] IS NULL AND ? IS NULL)) AND (([eunit] = ?) OR ([eunit] IS NULL AND ? IS NULL)) AND (([eduty] = ?) OR ([eduty] IS NULL AND ? IS NULL))" 
            InsertCommand="INSERT INTO [employee] ([eid], [ename], [esex], [eage], [eunit], [eduty]) VALUES (?, ?, ?, ?, ?, ?)" 
            OldValuesParameterFormatString="original_{0}" 
            SelectCommand="SELECT * FROM [employee]" 
            UpdateCommand="UPDATE [employee] SET [ename] = ?, [esex] = ?, [eage] = ?, [eunit] = ?, [eduty] = ? WHERE (([eid] = ?) OR ([eid] IS NULL AND ? IS NULL)) AND (([ename] = ?) OR ([ename] IS NULL AND ? IS NULL)) AND (([esex] = ?) OR ([esex] IS NULL AND ? IS NULL)) AND (([eage] = ?) OR ([eage] IS NULL AND ? IS NULL)) AND (([eunit] = ?) OR ([eunit] IS NULL AND ? IS NULL)) AND (([eduty] = ?) OR ([eduty] IS NULL AND ? IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_eid" Type="String" />
                <asp:Parameter Name="original_ename" Type="String" />
                <asp:Parameter Name="original_esex" Type="String" />
                <asp:Parameter Name="original_eage" Type="Int16" />
                <asp:Parameter Name="original_eunit" Type="String" />
                <asp:Parameter Name="original_eduty" Type="String" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="ename" Type="String" />
                <asp:Parameter Name="esex" Type="String" />
                <asp:Parameter Name="eage" Type="Int16" />
                <asp:Parameter Name="eunit" Type="String" />
                <asp:Parameter Name="eduty" Type="String" />
                <asp:Parameter Name="original_eid" Type="String" />
                <asp:Parameter Name="original_ename" Type="String" />
                <asp:Parameter Name="original_esex" Type="String" />
                <asp:Parameter Name="original_eage" Type="Int16" />
                <asp:Parameter Name="original_eunit" Type="String" />
                <asp:Parameter Name="original_eduty" Type="String" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="eid" Type="String" />
                <asp:Parameter Name="ename" Type="String" />
                <asp:Parameter Name="esex" Type="String" />
                <asp:Parameter Name="eage" Type="Int16" />
                <asp:Parameter Name="eunit" Type="String" />
                <asp:Parameter Name="eduty" Type="String" />
            </InsertParameters>
        </asp:AccessDataSource>
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" 
            AutoGenerateColumns="False" Caption="员工基本情况表" DataKeyNames="eid" 
            DataSourceID="AccessDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True">
                <ItemStyle Font-Size="Smaller" HorizontalAlign="Center" Wrap="False" />
                </asp:CommandField>
                <asp:BoundField DataField="eid" HeaderText="编号" ReadOnly="True" 
                    SortExpression="eid" >
                <HeaderStyle Font-Size="Smaller" />
                </asp:BoundField>
                <asp:BoundField DataField="ename" HeaderText="姓名" SortExpression="ename" >
                <HeaderStyle Font-Size="Smaller" />
                </asp:BoundField>
                <asp:BoundField DataField="esex" HeaderText="性别" SortExpression="esex" >
                <HeaderStyle Font-Size="Smaller" />
                </asp:BoundField>
                <asp:BoundField DataField="eage" HeaderText="年龄" SortExpression="eage" >
                <HeaderStyle Font-Size="Smaller" />
                </asp:BoundField>
                <asp:BoundField DataField="eunit" HeaderText="部门" SortExpression="eunit" >
                <HeaderStyle Font-Size="Smaller" />
                </asp:BoundField>
                <asp:BoundField DataField="eduty" HeaderText="职务" SortExpression="eduty" >
                <HeaderStyle Font-Size="Smaller" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
