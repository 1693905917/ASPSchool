<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="admin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: left">
        <asp:Panel ID="Panel1" runat="server" Width="509px">
            请输入密码<strong>：&nbsp;
            <asp:TextBox ID="TextPwd" runat="server" TextMode="Password"></asp:TextBox>
            &nbsp;
            <asp:Button ID="ButtonOK" runat="server" OnClick="ButtonOK_Click" Text="确 定" />
            &nbsp;<br />
            </strong>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Height="191px" Width="509px">
            <table style="width: 509px">
                <tr>
                    <td style="width: 521px; height: 100px;">
                        <table border="1" style="height: 185px">
                            <tr>
                                <td class="style1" colspan="6">
                                    <asp:TextBox ID="TextClass" runat="server" Width="142px"></asp:TextBox>
                                    &nbsp;&nbsp; 班课程表&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="btnSubmit" runat="server" OnClick="ButtonSubmit_Click" 
                                        Text="提 交" />
                                    <strong>&nbsp;
                                    <asp:Button ID="ButtonBack" runat="server" onclick="ButtonBack_Click" 
                                        PostBackUrl="~/Default.aspx" Text="返 回" />
                                    </strong>
                                </td>
                            </tr>
                            <tr>
                                <td class="style1" style="width: 100px">
                                    &nbsp;</td>
                                <td class="style1" style="width: 100px">
                                    <strong>星期一</strong></td>
                                <td class="style1" style="width: 100px">
                                    <strong>星期二</strong></td>
                                <td class="style1" style="width: 100px">
                                    <strong>星期三</strong></td>
                                <td class="style1" style="width: 100px">
                                    <strong>星期四</strong></td>
                                <td class="style1" style="width: 118px">
                                    <strong>星期五</strong></td>
                            </tr>
                            <tr>
                                <td style="width: 2806px" class="style1">
                                    <strong>1-2节</strong></td>
                                <td style="width: 100px" class="style1">
                                    <asp:DropDownList ID="DropDownList1" runat="server" Width="80px" 
                                        OnSelectedIndexChanged="DropDownList_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 100px" class="style1">
                                    <asp:DropDownList ID="DropDownList2" runat="server" Width="80px" 
                                        OnSelectedIndexChanged="DropDownList_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 100px" class="style1">
                                    <asp:DropDownList ID="DropDownList3" runat="server" Width="80px" 
                                        OnSelectedIndexChanged="DropDownList_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 100px" class="style1">
                                    <asp:DropDownList ID="DropDownList4" runat="server" Width="80px" 
                                        OnSelectedIndexChanged="DropDownList_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 118px" class="style1">
                                    <asp:DropDownList ID="DropDownList5" runat="server" Width="80px" 
                                        OnSelectedIndexChanged="DropDownList_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 2806px" class="style1">
                                    <strong>3-4节</strong></td>
                                <td style="width: 100px" class="style1">
                                    <asp:DropDownList ID="DropDownList6" runat="server" Width="80px" 
                                        OnSelectedIndexChanged="DropDownList_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 100px" class="style1">
                                    <asp:DropDownList ID="DropDownList7" runat="server" Width="80px" 
                                        OnSelectedIndexChanged="DropDownList_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 100px" class="style1">
                                    <asp:DropDownList ID="DropDownList8" runat="server" Width="80px" 
                                        OnSelectedIndexChanged="DropDownList_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 100px" class="style1">
                                    <asp:DropDownList ID="DropDownList9" runat="server" Width="80px" 
                                        OnSelectedIndexChanged="DropDownList_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 118px" class="style1">
                                    <asp:DropDownList ID="DropDownList10" runat="server" Width="80px" 
                                        OnSelectedIndexChanged="DropDownList_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 2806px" class="style1">
                                    <strong>5-6节</strong></td>
                                <td style="width: 100px" class="style1">
                                    <asp:DropDownList ID="DropDownList11" runat="server" Width="80px" 
                                        OnSelectedIndexChanged="DropDownList_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 100px" class="style1">
                                    <asp:DropDownList ID="DropDownList12" runat="server" Width="80px" 
                                        OnSelectedIndexChanged="DropDownList_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 100px" class="style1">
                                    <asp:DropDownList ID="DropDownList13" runat="server" Width="80px" 
                                        OnSelectedIndexChanged="DropDownList_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 100px" class="style1">
                                    <asp:DropDownList ID="DropDownList14" runat="server" Width="80px" 
                                        OnSelectedIndexChanged="DropDownList_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 118px" class="style1">
                                    <asp:DropDownList ID="DropDownList15" runat="server" Width="80px" 
                                        OnSelectedIndexChanged="DropDownList_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                        </table></table>
        </asp:Panel>
                
    </div>
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
