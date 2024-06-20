<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 453px">
            <tr>
                <td colspan="2">
                    输入时间
        <asp:DropDownList ID="dropYear" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dropDate_SelectedIndexChanged">
        </asp:DropDownList>
                    年<asp:DropDownList ID="dropMonth" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dropDate_SelectedIndexChanged">
        </asp:DropDownList>
                    月<asp:DropDownList ID="dropDay" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dropDate_SelectedIndexChanged">
        </asp:DropDownList>
                    日</td>
                <td colspan="1" rowspan="4" style="width: 137px">
                    <asp:Label ID="lblDate" runat="server" Text="Label" Width="261px"></asp:Label><br />
                    <br />
                    <asp:TextBox ID="txtLog" runat="server" Height="204px" TextMode="MultiLine" Width="280px"></asp:TextBox><br />
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" style="height: 40px">
                    设置月历的可选择性：<asp:DropDownList ID="dropMode" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dropMode_SelectedIndexChanged">
            <asp:ListItem Value="None">只读</asp:ListItem>
            <asp:ListItem Value="Day" Selected="True">可选择 天</asp:ListItem>
            <asp:ListItem Value="DayWeek">可选择 天、周</asp:ListItem>
            <asp:ListItem Value="DayWeekMonth">可选择 天、周、月</asp:ListItem>
        </asp:DropDownList></td>
            </tr>
            <tr>
                <td colspan="2" style="height: 202px">
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White"
            BorderWidth="1px" Font-Names="Verdana" Font-Size="Small"
            ForeColor="Black" Height="190px" NextMonthText="" NextPrevFormat="FullMonth"
            OnSelectionChanged="Calendar1_SelectionChanged" PrevMonthText="" SelectMonthText="选全月"
            SelectWeekText="选全周" Width="350px" DayHeaderStyle-Font-Italic="true" OnDayRender="Calendar1_DayRender" OnVisibleMonthChanged="Calendar1_VisibleMonthChanged">
            <SelectedDayStyle BackColor="#333399" BorderStyle="Double" ForeColor="White" />
            <TodayDayStyle BackColor="#CCCCCC" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#333333" Font-Bold="True" VerticalAlign="Bottom" />
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" Font-Italic="True" />
            <TitleStyle BackColor="White" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" BorderColor="Black" BorderWidth="4px" />
        </asp:Calendar>
                </td>
            </tr>
        </table>
        <br />
        </div>
    </form>
</body>
</html>

