<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowStudents.aspx.cs" Inherits="ShowData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>学员信息列表</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp; &nbsp;
        <asp:GridView ID="gvStudentList" runat="server" AutoGenerateColumns="False" DataKeyNames="StudentID"
            DataSourceID="SqlDataSource1" EmptyDataText="没有可显示的数据记录。" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" AllowSorting="True">
            <Columns>
                <asp:BoundField DataField="LoginId" HeaderText="用户名" SortExpression="LoginId" />
                <asp:BoundField DataField="StudentName" HeaderText="姓名" SortExpression="StudentName" />
                <asp:BoundField DataField="Sex" HeaderText="性别" SortExpression="Sex" />
                <asp:BoundField DataField="Address" HeaderText="地址" SortExpression="Address" />
            </Columns>
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#E3EAEB" />
            <EditRowStyle BackColor="#7C6F57" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MySchoolConnectionString1 %>"
            DeleteCommand="DELETE FROM [Student] WHERE [StudentID] = @StudentID" InsertCommand="INSERT INTO [Student] ([LoginId], [LoginPwd], [UserStateId], [ClassID], [StudentNO], [StudentName], [Sex], [StudentIDNO], [StudentStateID], [DegreeID], [Major], [SchoolBefore], [Phone], [Address], [PostalCode], [CityWanted], [JobWanted], [Comment], [Email]) VALUES (@LoginId, @LoginPwd, @UserStateId, @ClassID, @StudentNO, @StudentName, @Sex, @StudentIDNO, @StudentStateID, @DegreeID, @Major, @SchoolBefore, @Phone, @Address, @PostalCode, @CityWanted, @JobWanted, @Comment, @Email)"
            ProviderName="<%$ ConnectionStrings:MySchoolConnectionString1.ProviderName %>"
            SelectCommand="SELECT [StudentID], [LoginId], [LoginPwd], [UserStateId], [ClassID], [StudentNO], [StudentName], [Sex], [StudentIDNO], [StudentStateID], [DegreeID], [Major], [SchoolBefore], [Phone], [Address], [PostalCode], [CityWanted], [JobWanted], [Comment], [Email] FROM [Student]"
            UpdateCommand="UPDATE [Student] SET [LoginId] = @LoginId, [LoginPwd] = @LoginPwd, [UserStateId] = @UserStateId, [ClassID] = @ClassID, [StudentNO] = @StudentNO, [StudentName] = @StudentName, [Sex] = @Sex, [StudentIDNO] = @StudentIDNO, [StudentStateID] = @StudentStateID, [DegreeID] = @DegreeID, [Major] = @Major, [SchoolBefore] = @SchoolBefore, [Phone] = @Phone, [Address] = @Address, [PostalCode] = @PostalCode, [CityWanted] = @CityWanted, [JobWanted] = @JobWanted, [Comment] = @Comment, [Email] = @Email WHERE [StudentID] = @StudentID">
            <InsertParameters>
                <asp:Parameter Name="LoginId" Type="String" />
                <asp:Parameter Name="LoginPwd" Type="String" />
                <asp:Parameter Name="UserStateId" Type="Int32" />
                <asp:Parameter Name="ClassID" Type="Int32" />
                <asp:Parameter Name="StudentNO" Type="String" />
                <asp:Parameter Name="StudentName" Type="String" />
                <asp:Parameter Name="Sex" Type="String" />
                <asp:Parameter Name="StudentIDNO" Type="String" />
                <asp:Parameter Name="StudentStateID" Type="Int32" />
                <asp:Parameter Name="DegreeID" Type="Int32" />
                <asp:Parameter Name="Major" Type="String" />
                <asp:Parameter Name="SchoolBefore" Type="String" />
                <asp:Parameter Name="Phone" Type="String" />
                <asp:Parameter Name="Address" Type="String" />
                <asp:Parameter Name="PostalCode" Type="Double" />
                <asp:Parameter Name="CityWanted" Type="String" />
                <asp:Parameter Name="JobWanted" Type="String" />
                <asp:Parameter Name="Comment" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="LoginId" Type="String" />
                <asp:Parameter Name="LoginPwd" Type="String" />
                <asp:Parameter Name="UserStateId" Type="Int32" />
                <asp:Parameter Name="ClassID" Type="Int32" />
                <asp:Parameter Name="StudentNO" Type="String" />
                <asp:Parameter Name="StudentName" Type="String" />
                <asp:Parameter Name="Sex" Type="String" />
                <asp:Parameter Name="StudentIDNO" Type="String" />
                <asp:Parameter Name="StudentStateID" Type="Int32" />
                <asp:Parameter Name="DegreeID" Type="Int32" />
                <asp:Parameter Name="Major" Type="String" />
                <asp:Parameter Name="SchoolBefore" Type="String" />
                <asp:Parameter Name="Phone" Type="String" />
                <asp:Parameter Name="Address" Type="String" />
                <asp:Parameter Name="PostalCode" Type="Double" />
                <asp:Parameter Name="CityWanted" Type="String" />
                <asp:Parameter Name="JobWanted" Type="String" />
                <asp:Parameter Name="Comment" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="StudentID" Type="Int32" />
            </UpdateParameters>
            <DeleteParameters>
                <asp:Parameter Name="StudentID" Type="Int32" />
            </DeleteParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
