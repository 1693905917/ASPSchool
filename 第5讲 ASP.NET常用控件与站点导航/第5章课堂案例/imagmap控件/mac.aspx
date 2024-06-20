<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mac.aspx.cs" Inherits="mac" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>查看网卡MAC地址</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong><span lang="zh-cn"><span style="font-size: 16pt">&nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; <span style="font-family: 方正小标宋简体">查阅计算机网卡MAC地址的方法<br />
            </span>
            <br />
        </span>1. Windows 98环境</span> </strong>
        <p>
            <span lang="zh-cn">执行 开始—程序—MSDOS方式命令进入DOS窗口。</span><span lang="zh-cn">键入 &nbsp; ipconfig/all
                回车</span>
        </p>
        <p>
            <span lang="zh-cn"><strong>2. Windows2000/XP环境</strong></span></p>
        <p>
            <span lang="zh-cn">执行 开始—程序—附件—命令提示符。</span><span lang="zh-cn">键入&nbsp; ipconfig/all
                回车</span></p>
        <p>
            <span lang="zh-cn">如图所示,红色本分为网卡MAC地址</span></p>
        <p>
            <span lang="zh-cn">
                <asp:Image ID="Image1" runat="server" Height="292px" ImageUrl="~/images/mac.jpg"
                    Width="463px" /></span>&nbsp;</p>
    
    </div>
    </form>
</body>
</html>
