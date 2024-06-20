<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Exam.aspx.cs" Inherits="Exam" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width:600px;
        }
        .style2
        {
            font-size: x-large;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 636px">
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <table align="center" border="1" class="style1">
            <tr>
                <td class="style2" colspan="3" style="text-align: center">
                    限时在线模拟考试</td>
            </tr>
            <tr>
                <td style="width:200px">
                    <asp:Label ID="LabelName" runat="server" Text="Label"></asp:Label>
                </td>
                <td style="width:200px">
                    <asp:Label ID="LabelNo" runat="server" Text="Label"></asp:Label>
                </td>
                <td style="width:200px">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="False" 
                        UpdateMode="Conditional">
                        <ContentTemplate>
                            <asp:Label ID="LabelTime" runat="server" Text="Label"></asp:Label>
                            <asp:Timer ID="Timer1" runat="server" Interval="1000" ontick="Timer1_Tick">
                            </asp:Timer>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                        </Triggers>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Panel ID="Panel1" runat="server">
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center">
                    <asp:Button ID="ButtonOK" runat="server" Text="提交试卷" Width="144px" 
                        onclick="ButtonOK_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    
    </form>
</body>
</html>
