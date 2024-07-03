
<!DOCTYPE html>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="studentData._Default" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>学生信息表</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>本班学生信息表</h2>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                CssClass="table table-bordered table-striped">
                <Columns>
                    <asp:BoundField DataField="StudentID" HeaderText="学生ID" />
                    <asp:BoundField DataField="Name" HeaderText="姓名" />
                    <asp:BoundField DataField="Age" HeaderText="年龄" />
                    <asp:BoundField DataField="Grade" HeaderText="成绩" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
