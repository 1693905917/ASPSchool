<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
            text-align: center;
            width:15%;
            height:125px;
        }
        .style3
        {
            width:70%;
            text-align: center;
            height: 125px;
        }
       
        }
        .style4
        {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table border="1" class="style1">
            <tr>
                <td colspan="3" style="text-align: center; height: 22px;">
                    标题</td>
            </tr>
            <tr>
                <td class="style2" style="width: 15%">
                    左边</td>
                <td class="style3">
                    <table class="style1">
                        <tr>
                            <td>
                                栏目1</td>
                            <td>
                                栏目2</td>
                        </tr>
                        <tr>
                            <td style="text-align: left; height: 21px;">
                                项目11</td>
                            <td class="style4" style="height: 21px">
                                项目21</td>
                        </tr>
                        <tr>
                            <td style="text-align: left">
                                项目12</td>
                            <td class="style4">
                                项目22</td>
                        </tr>
                        <tr>
                            <td style="text-align: left">
                                项目13</td>
                            <td class="style4">
                                项目23</td>
                        </tr>
                        <tr>
                            <td style="text-align: left">
                                项目14</td>
                            <td style="text-align: left">
                                项目24</td>
                        </tr>
                    </table>
                </td>
                <td class="style2">
                    右边</td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center">
                    页脚</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
