<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Check.aspx.cs" Inherits="Check" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 414px" border="1">
            <tr>
                <td colspan="2" style="width: 392px; height: 69px;">
                    <asp:Label ID="LabelMsg" runat="server"></asp:Label>&nbsp;</td>
                <td style="width: 136px; height: 69px;">
                    &nbsp;
                    <asp:LinkButton ID="LinkContinue" runat="server" PostBackUrl="~/Default.aspx">继续购书</asp:LinkButton>
                    &nbsp;
                    <asp:LinkButton ID="LinkFinish" runat="server" OnClick="LinkFinish_Click">结 账</asp:LinkButton>&nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="3" style="height: 47px">
                    <asp:CheckBoxList ID="CheckSelect" runat="server">
                    </asp:CheckBoxList></td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center; height: 58px;">
                    <asp:Button ID="ButtonDel" runat="server" Text="移除选中的图书" 
                        OnClick="ButtonDel_Click" />
                    &nbsp; &nbsp;&nbsp;
                    <asp:Button ID="ButtonClear" runat="server" Text="清 空 购 物 车" 
                        OnClick="ButtonClear_Click" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
