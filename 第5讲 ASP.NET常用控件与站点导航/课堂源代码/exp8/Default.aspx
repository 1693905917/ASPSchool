<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 500px;
        }
        .style2
        {
            text-align: center;
            height: 36px;
            font-size: x-large;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1" border="1">
            <tr>
                <td class="style2">
                    学生成绩查询系统</td>
            </tr>
            <tr>
                <td style="text-align: center">
                    查询依据&nbsp; 
                    <asp:DropDownList ID="DropType" runat="server">
                    </asp:DropDownList>
&nbsp; 查询关键字&nbsp; 
                    <asp:TextBox ID="TextKey" runat="server" Width="116px"></asp:TextBox>
&nbsp;
                    <asp:Button ID="ButtonQuery" runat="server" Text="查 询" 
                        onclick="ButtonQuery_Click" />
                &nbsp;
                    <asp:Button ID="ButtonShowAll" runat="server" Text="显示全部" 
                        onclick="ButtonShowAll_Click" />
                </td>
            </tr>
            <tr>
                <td>
                  
            <asp:GridView ID="GridView1" runat="server" Width ="500px" 
                        OnRowDataBound= "GridView1_RowDataBound " ShowFooter="True">
                <RowStyle HorizontalAlign="Center" />
               
                <FooterStyle HorizontalAlign ="Center" />
                <Columns>
                    <asp:BoundField DataField="uid" HeaderText="学号" />
                    <asp:BoundField DataField="uname" HeaderText="姓名" />
                    <asp:BoundField DataField="usex" HeaderText="性别" />
                    <asp:BoundField DataField="class" HeaderText="班级" />
                    <asp:BoundField DataField="math" HeaderText="数学" />
                    <asp:BoundField DataField="chs" HeaderText="语文" />
                    <asp:BoundField DataField="en" HeaderText="英语" />
                    <asp:BoundField DataField="总分" HeaderText="总分" />
                </Columns>
            </asp:GridView>

                    <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
                        ConflictDetection="CompareAllValues" DataFile="~/App_Data/Student.mdb" 
                        DeleteCommand="DELETE FROM [grade] WHERE (([uid] = ?) OR ([uid] IS NULL AND ? IS NULL)) AND (([uname] = ?) OR ([uname] IS NULL AND ? IS NULL)) AND (([usex] = ?) OR ([usex] IS NULL AND ? IS NULL)) AND (([class] = ?) OR ([class] IS NULL AND ? IS NULL)) AND (([math] = ?) OR ([math] IS NULL AND ? IS NULL)) AND (([chs] = ?) OR ([chs] IS NULL AND ? IS NULL)) AND (([en] = ?) OR ([en] IS NULL AND ? IS NULL))" 
                        InsertCommand="INSERT INTO [grade] ([uid], [uname], [usex], [class], [math], [chs], [en]) VALUES (?, ?, ?, ?, ?, ?, ?)" 
                        OldValuesParameterFormatString="original_{0}" 
                        SelectCommand="SELECT uid,uname,usex,class,math,chs,en,(math+chs+en) as 总分 FROM [grade] WHERE ([uid] = ?)" 
                        
                        UpdateCommand="UPDATE [grade] SET [uname] = ?, [usex] = ?, [class] = ?, [math] = ?, [chs] = ?, [en] = ? WHERE (([uid] = ?) OR ([uid] IS NULL AND ? IS NULL)) AND (([uname] = ?) OR ([uname] IS NULL AND ? IS NULL)) AND (([usex] = ?) OR ([usex] IS NULL AND ? IS NULL)) AND (([class] = ?) OR ([class] IS NULL AND ? IS NULL)) AND (([math] = ?) OR ([math] IS NULL AND ? IS NULL)) AND (([chs] = ?) OR ([chs] IS NULL AND ? IS NULL)) AND (([en] = ?) OR ([en] IS NULL AND ? IS NULL))">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="TextKey" Name="uid" PropertyName="Text" 
                                Type="String" />
                        </SelectParameters>
                        <DeleteParameters>
                            <asp:Parameter Name="original_uid" Type="String" />
                            <asp:Parameter Name="original_uname" Type="String" />
                            <asp:Parameter Name="original_usex" Type="String" />
                            <asp:Parameter Name="original_class" Type="String" />
                            <asp:Parameter Name="original_math" Type="Int16" />
                            <asp:Parameter Name="original_chs" Type="Int16" />
                            <asp:Parameter Name="original_en" Type="Int16" />
                        </DeleteParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="uname" Type="String" />
                            <asp:Parameter Name="usex" Type="String" />
                            <asp:Parameter Name="class" Type="String" />
                            <asp:Parameter Name="math" Type="Int16" />
                            <asp:Parameter Name="chs" Type="Int16" />
                            <asp:Parameter Name="en" Type="Int16" />
                            <asp:Parameter Name="original_uid" Type="String" />
                            <asp:Parameter Name="original_uname" Type="String" />
                            <asp:Parameter Name="original_usex" Type="String" />
                            <asp:Parameter Name="original_class" Type="String" />
                            <asp:Parameter Name="original_math" Type="Int16" />
                            <asp:Parameter Name="original_chs" Type="Int16" />
                            <asp:Parameter Name="original_en" Type="Int16" />
                        </UpdateParameters>
                        <InsertParameters>
                            <asp:Parameter Name="uid" Type="String" />
                            <asp:Parameter Name="uname" Type="String" />
                            <asp:Parameter Name="usex" Type="String" />
                            <asp:Parameter Name="class" Type="String" />
                            <asp:Parameter Name="math" Type="Int16" />
                            <asp:Parameter Name="chs" Type="Int16" />
                            <asp:Parameter Name="en" Type="Int16" />
                        </InsertParameters>
                    </asp:AccessDataSource>
                    <asp:AccessDataSource ID="AccessDataSource2" runat="server" 
                        ConflictDetection="CompareAllValues" DataFile="~/App_Data/Student.mdb" 
                        DeleteCommand="DELETE FROM [grade] WHERE (([uid] = ?) OR ([uid] IS NULL AND ? IS NULL)) AND (([uname] = ?) OR ([uname] IS NULL AND ? IS NULL)) AND (([usex] = ?) OR ([usex] IS NULL AND ? IS NULL)) AND (([class] = ?) OR ([class] IS NULL AND ? IS NULL)) AND (([math] = ?) OR ([math] IS NULL AND ? IS NULL)) AND (([chs] = ?) OR ([chs] IS NULL AND ? IS NULL)) AND (([en] = ?) OR ([en] IS NULL AND ? IS NULL))" 
                        InsertCommand="INSERT INTO [grade] ([uid], [uname], [usex], [class], [math], [chs], [en]) VALUES (?, ?, ?, ?, ?, ?, ?)" 
                        OldValuesParameterFormatString="original_{0}" 
                        SelectCommand="SELECT uid,uname,usex,class,math,chs,en,(math+chs+en) as 总分 FROM [grade] WHERE ([uname] LIKE '%' + ? + '%')" 
                        
                        
                        UpdateCommand="UPDATE [grade] SET [uname] = ?, [usex] = ?, [class] = ?, [math] = ?, [chs] = ?, [en] = ? WHERE (([uid] = ?) OR ([uid] IS NULL AND ? IS NULL)) AND (([uname] = ?) OR ([uname] IS NULL AND ? IS NULL)) AND (([usex] = ?) OR ([usex] IS NULL AND ? IS NULL)) AND (([class] = ?) OR ([class] IS NULL AND ? IS NULL)) AND (([math] = ?) OR ([math] IS NULL AND ? IS NULL)) AND (([chs] = ?) OR ([chs] IS NULL AND ? IS NULL)) AND (([en] = ?) OR ([en] IS NULL AND ? IS NULL))">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="TextKey" Name="uname" PropertyName="Text" 
                                Type="String" />
                        </SelectParameters>
                        <DeleteParameters>
                            <asp:Parameter Name="original_uid" Type="String" />
                            <asp:Parameter Name="original_uname" Type="String" />
                            <asp:Parameter Name="original_usex" Type="String" />
                            <asp:Parameter Name="original_class" Type="String" />
                            <asp:Parameter Name="original_math" Type="Int16" />
                            <asp:Parameter Name="original_chs" Type="Int16" />
                            <asp:Parameter Name="original_en" Type="Int16" />
                        </DeleteParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="uname" Type="String" />
                            <asp:Parameter Name="usex" Type="String" />
                            <asp:Parameter Name="class" Type="String" />
                            <asp:Parameter Name="math" Type="Int16" />
                            <asp:Parameter Name="chs" Type="Int16" />
                            <asp:Parameter Name="en" Type="Int16" />
                            <asp:Parameter Name="original_uid" Type="String" />
                            <asp:Parameter Name="original_uname" Type="String" />
                            <asp:Parameter Name="original_usex" Type="String" />
                            <asp:Parameter Name="original_class" Type="String" />
                            <asp:Parameter Name="original_math" Type="Int16" />
                            <asp:Parameter Name="original_chs" Type="Int16" />
                            <asp:Parameter Name="original_en" Type="Int16" />
                        </UpdateParameters>
                        <InsertParameters>
                            <asp:Parameter Name="uid" Type="String" />
                            <asp:Parameter Name="uname" Type="String" />
                            <asp:Parameter Name="usex" Type="String" />
                            <asp:Parameter Name="class" Type="String" />
                            <asp:Parameter Name="math" Type="Int16" />
                            <asp:Parameter Name="chs" Type="Int16" />
                            <asp:Parameter Name="en" Type="Int16" />
                        </InsertParameters>
                    </asp:AccessDataSource>
                    <asp:AccessDataSource ID="AccessDataSource3" runat="server" 
                        ConflictDetection="CompareAllValues" DataFile="~/App_Data/Student.mdb" 
                        DeleteCommand="DELETE FROM [grade] WHERE (([uid] = ?) OR ([uid] IS NULL AND ? IS NULL)) AND (([uname] = ?) OR ([uname] IS NULL AND ? IS NULL)) AND (([usex] = ?) OR ([usex] IS NULL AND ? IS NULL)) AND (([class] = ?) OR ([class] IS NULL AND ? IS NULL)) AND (([math] = ?) OR ([math] IS NULL AND ? IS NULL)) AND (([chs] = ?) OR ([chs] IS NULL AND ? IS NULL)) AND (([en] = ?) OR ([en] IS NULL AND ? IS NULL))" 
                        InsertCommand="INSERT INTO [grade] ([uid], [uname], [usex], [class], [math], [chs], [en]) VALUES (?, ?, ?, ?, ?, ?, ?)" 
                        OldValuesParameterFormatString="original_{0}" 
                        SelectCommand="SELECT uid,uname,usex,class,math,chs,en,(math+chs+en) as 总分 FROM [grade] WHERE ([class] LIKE '%' + ? + '%')" 
                        
                        UpdateCommand="UPDATE [grade] SET [uname] = ?, [usex] = ?, [class] = ?, [math] = ?, [chs] = ?, [en] = ? WHERE (([uid] = ?) OR ([uid] IS NULL AND ? IS NULL)) AND (([uname] = ?) OR ([uname] IS NULL AND ? IS NULL)) AND (([usex] = ?) OR ([usex] IS NULL AND ? IS NULL)) AND (([class] = ?) OR ([class] IS NULL AND ? IS NULL)) AND (([math] = ?) OR ([math] IS NULL AND ? IS NULL)) AND (([chs] = ?) OR ([chs] IS NULL AND ? IS NULL)) AND (([en] = ?) OR ([en] IS NULL AND ? IS NULL))">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="TextKey" Name="class" PropertyName="Text" 
                                Type="String" />
                        </SelectParameters>
                        <DeleteParameters>
                            <asp:Parameter Name="original_uid" Type="String" />
                            <asp:Parameter Name="original_uname" Type="String" />
                            <asp:Parameter Name="original_usex" Type="String" />
                            <asp:Parameter Name="original_class" Type="String" />
                            <asp:Parameter Name="original_math" Type="Int16" />
                            <asp:Parameter Name="original_chs" Type="Int16" />
                            <asp:Parameter Name="original_en" Type="Int16" />
                        </DeleteParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="uname" Type="String" />
                            <asp:Parameter Name="usex" Type="String" />
                            <asp:Parameter Name="class" Type="String" />
                            <asp:Parameter Name="math" Type="Int16" />
                            <asp:Parameter Name="chs" Type="Int16" />
                            <asp:Parameter Name="en" Type="Int16" />
                            <asp:Parameter Name="original_uid" Type="String" />
                            <asp:Parameter Name="original_uname" Type="String" />
                            <asp:Parameter Name="original_usex" Type="String" />
                            <asp:Parameter Name="original_class" Type="String" />
                            <asp:Parameter Name="original_math" Type="Int16" />
                            <asp:Parameter Name="original_chs" Type="Int16" />
                            <asp:Parameter Name="original_en" Type="Int16" />
                        </UpdateParameters>
                        <InsertParameters>
                            <asp:Parameter Name="uid" Type="String" />
                            <asp:Parameter Name="uname" Type="String" />
                            <asp:Parameter Name="usex" Type="String" />
                            <asp:Parameter Name="class" Type="String" />
                            <asp:Parameter Name="math" Type="Int16" />
                            <asp:Parameter Name="chs" Type="Int16" />
                            <asp:Parameter Name="en" Type="Int16" />
                        </InsertParameters>
                    </asp:AccessDataSource>
                    <asp:AccessDataSource ID="AccessDataSource4" runat="server" 
                        DataFile="~/App_Data/Student.mdb" 
                        SelectCommand="SELECT uid,uname,usex,class,math,chs,en,(math+chs+en) as 总分 FROM [grade]">
                    </asp:AccessDataSource>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
