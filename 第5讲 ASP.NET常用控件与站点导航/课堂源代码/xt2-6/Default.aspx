<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CSS+DIV页面布局</title>
    <style type="text/css">
        #left
        {
            background-image:url("images/background.jpg");       /*指定背景图片的URL*/
            height:100px; width:200px;
            float:left;                       
        }
        #right
        {
            height:100px;width: 400px;
            float:left;
            background-color:Silver;           
         }
         #main
         {
             width:600px; height:100px;margin:0 auto;           /*“margin:0 auto”使元素居中对齐*/
             border:1px solid Silver;
         }
    </style>
</head>
<body style="text-align:center">
    <form id="form1" runat="server">
        <div id="main">    
            <div id="left"></div>
            <div id="right"></div>
        </div>
    
    </form>
</body>
</html>
