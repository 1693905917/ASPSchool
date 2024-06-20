<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 80%;
        }
        .style2
        {
            text-align: center;
        }
        .style11
        {
            text-align: center;
            width: 83px;
        }
        .style12
        {
            width: 83px;
        }
        .style15
        {
            text-align: center;
            width: 94px;
        }
        .style16
        {
            width: 94px;
        }
        .style17
        {
            text-align: center;
            width: 79px;
        }
        .style18
        {
            width: 79px;
        }
        .style19
        {
            text-align: center;
            width: 54px;
        }
        .style20
        {
            width: 54px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 562px">
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="StudentID" HeaderText="学号" />
        <asp:BoundField DataField="StudentName" HeaderText="姓名" />
        <asp:BoundField DataField="Sex" HeaderText="性别" />
        <asp:BoundField DataField="DateOfBirth" HeaderText="出生日期"
                     DataFormatString="{0:yyyy-MM-dd}" HtmlEncode="False" />
        <asp:BoundField DataField="Specialty" HeaderText="专业" />
        <asp:BoundField DataField="Email" HeaderText="电子邮件" />
    </Columns>
</asp:GridView>

        <br />
        <table class="style1" border="1" cellpadding="0" cellspacing="0">
            <tr>
                <td class="style2">
                    学号</td>
                <td class="style17">
                    姓名</td>
                <td>
                    性别</td>
                <td class="style11">
                    出生日期</td>
                <td class="style19">
                    专业</td>
                <td class="style15">
                    电子邮件</td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" 
                        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="style18">
                    <asp:TextBox ID="StuName" runat="server" Height="21px" Width="65px" 
                        BorderStyle="None"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="StuSex" runat="server" Height="21px" Width="29px" BorderStyle="None" 
                        ></asp:TextBox>
                </td>
                <td class="style12">
                    <asp:TextBox ID="StuBirth" runat="server" Height="21px" Width="75px" 
                        BorderStyle="None" style="margin-left: 0px"></asp:TextBox>
                </td>
                <td class="style20">
                    <asp:TextBox ID="StuSpecialty" runat="server" Height="21px" Width="66px" 
                        BorderStyle="None"></asp:TextBox>
                </td>
                <td class="style16">
                    <asp:TextBox ID="StuEmail" runat="server" Height="21px" Width="92px" 
                        BorderStyle="None" style="margin-left: 0px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="RecUpdate" runat="server" onclick="RecUpdate_Click" 
            Text="更 新" />
    
    &nbsp;
        <asp:Button ID="RecDel" runat="server" onclick="RecDel_Click" Text="删 除" />
        <cc1:ConfirmButtonExtender ID="RecDel_ConfirmButtonExtender" runat="server" 
            ConfirmText="当前记录将被删除,请确认" Enabled="True" TargetControlID="RecDel">
        </cc1:ConfirmButtonExtender>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
    </form>
</body>
</html>
