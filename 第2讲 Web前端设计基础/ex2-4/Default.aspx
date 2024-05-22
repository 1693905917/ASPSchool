<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>绝对定位与相对定位的比较</title>
      <style type="text/css">
         
                      
        #div1
        {
           margin: 0 auto;width: 257px; text-align: left; height: 185px; border: solid 1px #009999;
        }
        #div2
        {
            width: 118px; height: 34px; text-align: left; border: solid 1px #ff66cc;
        }
        #div3
        {
            position:absolute; top:76px; left: 48px; width: 200px;
            z-index: 100; height: 100px; border: solid 1px #ff0033;
        }
        #div4
        {
            top: 20px; left: 30px; position: relative; width: 96px; height: 42px;
            border: solid 1px #3366ff;
        }
    </style>
</head>
<body style="text-align:center">
    <form id="form1" runat="server">   
        <div id="div1">div1
            <div id="div2">div2
                <div id="div3" >div3
                    <div id="div4">div4</div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
