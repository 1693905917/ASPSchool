<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type ="text/javascript">
        function Button1_onclick()
        {
            document.getElementById('ReturnVal').value = confirm('OK?');
        }
    </script>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="580px">
    <Columns>
        <asp:BoundField DataField="StudentID" HeaderText="学号" />
        <asp:BoundField DataField="StudentName" HeaderText="姓名" />
        <asp:BoundField DataField="Sex" HeaderText="性别" />
        <asp:BoundField DataField="DateOfBirth" HeaderText="出生日期"
                     DataFormatString="{0:yyyy-M-d}" HtmlEncode="False" />
        <asp:BoundField DataField="Specialty" HeaderText="专业" />
        <asp:BoundField DataField="Email" HeaderText="电子邮件" />
    </Columns>
</asp:GridView>

        <table>
            <tr>
                <td>
                    <br />
                    输入新记录各字段值：</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="92px"></asp:TextBox>
                    <asp:TextBox ID="TextBox2" runat="server"  width="81px"></asp:TextBox>
                    <asp:TextBox ID="TextBox3" runat="server" width="28px"></asp:TextBox>
                    <asp:TextBox ID="TextBox4" runat="server"  width="105px"></asp:TextBox>
                    <asp:TextBox ID="TextBox5" runat="server"  width="98px"></asp:TextBox>
                    <asp:TextBox ID="TextBox6" runat="server" width="106px"></asp:TextBox>
                </td>
            </tr>
        </table>
       
        
       
        <br />
        <asp:Button ID="AddRow" runat="server" onclick="AddRow_Click" Text="添加记录" />
        <br />
    
    </div>
      
    </form>
</body>


</html>
