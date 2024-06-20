<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
    
      function pageLoad() {
      }
    
    </script>
    <style type="text/css">
        .style1
        {
            width: 232px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 476px">
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <table style="width: 100%;">
            <tr>
                <td class="style1">
                    只允许大小写字母和空格</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <cc1:FilteredTextBoxExtender ID="TextBox1_FilteredTextBoxExtender" 
                        runat="server" Enabled="True" FilterType="Custom,UppercaseLetters,LowerCaseLetters" ValidChars=" "
                        TargetControlID="TextBox1">
                    </cc1:FilteredTextBoxExtender>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    只允许输入数字</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" MaxLength="6"></asp:TextBox>
                    <cc1:FilteredTextBoxExtender ID="TextBox2_FilteredTextBoxExtender" 
                        runat="server" Enabled="True" TargetControlID="TextBox2" 
                        FilterType="Numbers">
                    </cc1:FilteredTextBoxExtender>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    只允许大小写字母和数字的组合</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <cc1:FilteredTextBoxExtender ID="TextBox3_FilteredTextBoxExtender" 
                        runat="server" Enabled="True" TargetControlID="TextBox3" 
                        FilterType="UppercaseLetters,LowerCaseLetters,Numbers">
                    </cc1:FilteredTextBoxExtender>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    只允许输入四则运算符</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <cc1:FilteredTextBoxExtender ID="TextBox4_FilteredTextBoxExtender" 
                        runat="server" Enabled="True" TargetControlID="TextBox4"
                        FilterType="Custom" ValidChars ="+,-,*,/">
                    </cc1:FilteredTextBoxExtender>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
