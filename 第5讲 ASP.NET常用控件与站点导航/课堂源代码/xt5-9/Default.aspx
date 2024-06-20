<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:LinkButton ID="Input" runat="server" OnClick="LinkButton1_Click">输入你的生日</asp:LinkButton>
        &nbsp;&nbsp;
        <asp:DropDownList ID="DropYear" runat="server" 
            OnSelectedIndexChanged="drop_SelectedIndexChanged">
            <asp:ListItem>-选择年份-</asp:ListItem>
        </asp:DropDownList>
        年&nbsp;
        <asp:DropDownList ID="DropMonth" runat="server" 
            OnSelectedIndexChanged="drop_SelectedIndexChanged">
            <asp:ListItem>-选择月份-</asp:ListItem>
        </asp:DropDownList>
        月<br />
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="50px" Width="125px">
            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black"
                BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black"
                Height="210px" NextPrevFormat="ShortMonth" Width="330px" OnSelectionChanged="Calendar1_SelectionChanged">
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TodayDayStyle BackColor="#999999" ForeColor="White" />
                <DayStyle BackColor="#CCCCCC" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt"
                    ForeColor="White" Height="12pt" />
            </asp:Calendar>
        </asp:Panel>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
