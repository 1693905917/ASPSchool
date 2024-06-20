using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;

public partial class film : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = "欢迎光临";
        if (Session["level"] == null)
        {
            Response.Redirect("Default.aspx");           
        }
        string SqlStr;
        if (Session["level"].ToString() == "True")
        {
            Response.Write("欢迎VIP用户 " + Request.QueryString["name"].ToString() + " 观看本站最新电影");
            SqlStr = "select * from film";
        }
        else
        { 
            Response.Write("欢迎 " + Request.QueryString["name"].ToString() + " 观看本站最新电影");
            SqlStr = "select * from film where not isvip";
        }
             
        string ConnStr = ConfigurationManager.ConnectionStrings["ConnString"].ToString();
        using (OleDbConnection conn = new OleDbConnection(ConnStr))
        {  
            conn.Open();
            OleDbCommand com = new OleDbCommand(SqlStr, conn);
            OleDbDataReader dr = com.ExecuteReader();
            Table1.Width = 450;				//设置表格的宽度
            Table1.Caption = "<b>最近更新</b>";		//设置表格的标题
            Table1.GridLines = GridLines.Both;	//设置单元格的框线
            //Table1.HorizontalAlign = HorizontalAlign.Center;		//设置表格相对页面居中
            Table1.CellPadding = 1;				//设置单元格内间距
            Table1.CellSpacing = 3;				//设置单元格之间的距离
            while (dr.Read())
            {
                TableRow TabRow = new TableRow();			//声明一个表格行对象
                for (int i = 0; i < 4; i++)	//内层循环控制每行的列数（单元格数）
                {
                    TableCell TabCell = new TableCell();			//声明一个单元格对象
                    if (i == 0)
                    {
                        HyperLink LinkFilm = new HyperLink();		//声明一个HyperLink对象
                        LinkFilm.Text = dr["filmname"].ToString();				//设置HyperLink中显示的文本
                        if ((bool)dr["isvip"])
                        {
                            LinkFilm.Text = "★ " + LinkFilm.Text;
                        }
                        LinkFilm.NavigateUrl = dr["filmurl"].ToString();			//设置HyperLink的超链接地址
                        LinkFilm.Target = "_blank";			//设置HyperLink的目标框架（在新窗口中打开网页）
                        TabCell.Controls.Add(LinkFilm);		//将HyperLink对象添加到单元格中
                        TabRow.Cells.Add(TabCell);
                    }
                    if (i == 1)
                    {
                        TabCell.Text = dr["explain"].ToString();	//将“说明”字段值显示到单元格中
                        TabRow.Cells.Add(TabCell);				//添加一个新单元格（列）
                    }
                    if (i == 2)
                    {
                        TabCell.Text = dr["filmdate"].ToString();	//将“日期”字段值显示到单元格中
                        TabRow.Cells.Add(TabCell);				//添加一个新单元格（列）
                    }
                }
                Table1.Rows.Add(TabRow);					//添加一个新行
            }
        }
       
    }
}
