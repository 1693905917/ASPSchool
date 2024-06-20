<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <p><div style="width: 450px">
        <table style="width: 450px; height: 135px;" border="1">
            <tr>
                <td colspan="4" style="height: 15px; text-align: center">
                    <strong>
                    员工信息查询系统</strong></td>
            </tr>
            <tr>
                <td style="text-align: left" colspan="4">
                    部门<asp:DropDownList ID="DropUnit" runat="server" AutoPostBack="True" 
                        OnSelectedIndexChanged="DropUnit_SelectedIndexChanged">
                        <asp:ListItem>-选择部门-</asp:ListItem>
                        <asp:ListItem>教务处</asp:ListItem>
                        <asp:ListItem>学生处</asp:ListItem>
                        <asp:ListItem>科研处</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;&nbsp;
                    姓名<asp:DropDownList ID="DropName" runat="server" AutoPostBack="True" 
                        OnSelectedIndexChanged="Drop_SelectedIndexChanged">
                        <asp:ListItem>-选择姓名-</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td colspan="4" style="height: 30px">
                    <asp:CheckBoxList ID="CheckDisplay" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Drop_SelectedIndexChanged"
                        RepeatDirection="Horizontal">
                        <asp:ListItem>住址</asp:ListItem>
                        <asp:ListItem>电话</asp:ListItem>
                        <asp:ListItem>学历</asp:ListItem>
                    </asp:CheckBoxList></td>
            </tr>
        </table>
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
