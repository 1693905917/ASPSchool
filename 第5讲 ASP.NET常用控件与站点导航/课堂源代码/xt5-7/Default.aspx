<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 426px">
            <tr>
                <td colspan="3" style="text-align: center">
                    <strong>曙光学校课程表查询系统 </strong>&nbsp; &nbsp;&nbsp;
                    <asp:DropDownList ID="DropClass" runat="server" 
                        OnSelectedIndexChanged="DropClass_SelectedIndexChanged">
                        <asp:ListItem>-请选择班级-</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                </td>
            </tr>
        </table>
    
    </div>
        <br />
        <br />
    </form>
</body>
</html>
