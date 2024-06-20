<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:addresslistConnectionString %>" 
            SelectCommand="SELECT * FROM [Tel]"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="uid" DataSourceID="SqlDataSource1" 
            onselectedindexchanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField SelectText="修改" ShowSelectButton="True" />
                <asp:BoundField DataField="uid" HeaderText="编号" ReadOnly="True" 
                    SortExpression="uid" />
                <asp:BoundField DataField="uname" HeaderText="姓名" SortExpression="uname" />
                <asp:BoundField DataField="uunit" HeaderText="单位" SortExpression="uunit" />
                <asp:BoundField DataField="officetel" HeaderText="办公电话" 
                    SortExpression="offictel" />
                <asp:BoundField DataField="mobil" HeaderText="移动电话" SortExpression="mobil" />
                <asp:BoundField DataField="email" HeaderText="电子邮件" SortExpression="email" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
