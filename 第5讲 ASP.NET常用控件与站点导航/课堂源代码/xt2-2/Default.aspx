<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>使用XHTML编写网页代码</title>
    <style type="text/css" >
        td
        {
            line-height:30px; border:1px solid black;   /*为所有<td>元素设置样式*/
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center">
        <table style="width:800px; text-align: center; font-family:楷体_GB2312; border-collapse: collapse">    <!--“border-collapse: collapse”表示折叠表格边框-->
        <caption style="font-family:华文行楷; font-size:xx-large">光明学校微机0903班课程表</caption>
            <tr style="font-family:黑体">
                <td>星期一</td>
                <td>星期二</td>
                <td>星期三</td>
                <td>星期四</td>
                <td>星期五</td>
            </tr>
            <tr>
                <td>计算机基础</td>
                <td>高等数学</td>
                <td>英语</td>
                <td>计算机基础</td>
                <td>英语</td>
            </tr>
            <tr>
                <td>英语</td>
                <td>政治</td>
                <td>体育</td>
                <td>高等数学</td>
                <td>高等数学</td>
            </tr>
            <tr>
                <td>电子技术</td>
                <td></td>
                <td>计算机基础</td>
                <td>电子技术</td>
                <td>电子技术</td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
