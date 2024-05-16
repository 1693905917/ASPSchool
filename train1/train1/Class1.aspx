<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Class1.aspx.cs" Inherits="Class1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            font-weight: normal;
        }
        .style3
        {
            font-size: medium;
        }
        .style4
        {
            font-size: x-large;
        }
        .style5
        {
            font-size: medium;
            font-weight: normal;
        }
        .auto-style1 {
            text-decoration: none;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-weight: 700; font-size: large; text-align: center">
    
        <span class="style4">2016～2017第二学期网络一班课程表<br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" CssClass="auto-style1" PostBackUrl="~/Default.aspx">返回</asp:LinkButton>
        <br />
        </span><table border="1" 
            class="style1">
            <tr>
                <td>
                    星期一</td>
                <td>
                    星期二</td>
                <td>
                    星期三</td>
                <td>
                    星期四</td>
                <td>
                    星期五</td>
            </tr>
            <tr>
                <td class="style3">
                    <span class="style2">计算机基础</td>
                <td>
                    <span class="style2">高等数学</td>
                <td class="style2">
                    网络原理</td>
                <td class="style2">
                    电路基础</td>
                <td class="style2">
                    计算机基础</span></span></td>
            </tr>
            <tr>
                <td class="style5">
                    大学语文</td>
                <td>
                    <span class="style2">政治</td>
                <td class="style2">
                    计算机基础</td>
                <td class="style2">
                    高等数学</td>
                <td class="style2">
                    网络原理</span></span></td>
            </tr>
            <tr>
                <td class="style5">
                    体育</td>
                <td>
                    <span class="style2">网络原理</td>
                <td class="style2">
                    电路基础</td>
                <td>
                    &nbsp;</td>
                <td class="style2">
                    大学语文</span></span></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
