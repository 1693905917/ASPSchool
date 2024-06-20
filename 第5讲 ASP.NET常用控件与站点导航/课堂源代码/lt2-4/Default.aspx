<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>绝对定位与相对定位的比较</title>
    <style type="text/css">
        #div1
        {
           width: 257px; text-align: left; height: 179px; border: solid 1px #009999;
        }
        #div2
        {
            width: 118px;height: 34px;text-align: left;   border: solid 1px #ff66cc;
        }
        #div3
        {
            position: absolute; top: 72px; left: 248px; width: 200px; z-index: 100; height: 100px; border: solid 1px #ff0033;
        }
        #div4
        {
            top: 20px; left: 30px; position:absolute; width: 96px; height: 42px; border: solid 1px #3366ff;
        }
    </style>
</head>
<body style="text-align: center;">
<form id="form1" runat="server">
    <div id="div1">div1
        <div id="div2">div2
            <div id="div3" >div3   hvfjhffkjjglkgglgmgiokjlgklkgkl;kopbkv;lk;lk,;lb,lpol,bl,nlbvnlol
                 <div id="div4" >div4</div>
            </div>
        </div>
    </div>
</form>
</body>
</html>
