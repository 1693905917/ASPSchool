using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string FilePaht = Server.MapPath("App_Data/tools.txt");		//取得counter.txt文件的物理路径
            StreamReader sr = new StreamReader(FilePaht, Encoding.GetEncoding("gb2312"));		//创建一个指向program.txt数据文件的读取流对象sr

            while (!sr.EndOfStream)
            {
                CheckBookName.Items.Add(sr.ReadLine());
            }
            sr.Close();		//关闭sr对象
        }
        //查找母版页中的Button1控件，并赋值给Button类型变量B1
        Button BAdd = (Button)Master.FindControl("ButtonAdd");
        //将B1的单击事件委托给内容页中B1_Click方法，
        //即母版页中Button1被单击时，由内容页BAdd_Click方法中包含的代码来处理（响应）
        BAdd.Click += new EventHandler(BAdd_Click);

        //查找母版页中的Button1控件，并赋值给Button类型变量B1
        Button BView = (Button)Master.FindControl("ButtonView");
        //将B1的单击事件委托给内容页中B1_Click方法，
        //即母版页中Button1被单击时，由内容页BAdd_Click方法中包含的代码来处理（响应）
        BView.Click += new EventHandler(BView_Click);
    }

    protected void BAdd_Click(object sender, EventArgs e)		//创建B1_Click()方法，
    {
        //处理母版页中ButtonAdd_Click事件的程序段
        for (int i = 0; i < CheckBookName.Items.Count; i++)
        {
            if (CheckBookName.Items[i].Selected)
            {
                Session["buy"] = Session["buy"] + CheckBookName.Items[i].Text + "，";
            }
        }
        if (Session["buy"] != null)
        {
            Response.Write("<script language=javascript>alert('已将所选图书添加到购物车！');</script>");
        }
        else
        { 
            Response.Write("<script language=javascript>alert('你尚未选择任何图书！');</script>");
        }        
    }

    protected void BView_Click(object sender, EventArgs e)		//创建B1_Click()方法，
    {
        //处理母版页中ButtonAdd_Click事件的程序段
        if (Session["buy"] != null)
        {
            Response.Redirect("Check.aspx");		//跳转到“查看购物车”页面
        }
        else
        {
            Response.Write("<script language=javascript>alert('你的购物车是空的！');</script>");
        }
    }
}
