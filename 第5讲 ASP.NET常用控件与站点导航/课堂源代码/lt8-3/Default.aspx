<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Repeater控件使用示例</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!--声明AccessDataSource数据源控件，并设置其属性 -->
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/employee.mdb"
            SelectCommand="SELECT * FROM [employee]"></asp:AccessDataSource>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="AccessDataSource1" DataMember="DefaultView">
            <HeaderTemplate>
                <b><span style="font-size:xx-large; font-family:隶书"><center>职工基本情况表</span></b>
                <hr style="width:90">
                <table border="1" width ="400">
                <tr align ="center">
                    <td><b>编号</b></td>
                    <td><b>姓名</b></td>
                    <td><b>性别</b></td>
                    <td><b>年龄</b></td>
                    <td><b>部门</b></td>
                    <td><b>职务</b></td>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>                
                <tr align ="center" style="background-color:#CCCCCC">
                    <td><%# DataBinder.Eval(Container.DataItem,"eid") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem,"ename") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem,"esex") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem,"eage") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem,"eunit") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem,"eduty") %></td>
                </tr>
            </ItemTemplate>
            <AlternatingItemTemplate>                
                <tr align ="center" >
                    <td><%# DataBinder.Eval(Container.DataItem,"eid") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem,"ename") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem,"esex") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem,"eage") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem,"eunit") %></td>
                    <td><%# DataBinder.Eval(Container.DataItem,"eduty") %></td>
                </tr>
            </AlternatingItemTemplate>
            <FooterTemplate>                
                </table>
                <hr style="width:90">
                曙光学校人事处 2009-11-20
            </FooterTemplate>
        </asp:Repeater>
        <br />
        <br />
        
        </div>        
    </form>
</body>
</html>
