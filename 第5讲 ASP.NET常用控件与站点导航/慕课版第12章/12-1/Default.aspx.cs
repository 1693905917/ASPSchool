using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BindDataBase();
        TreeView1.ShowLines = true;//显示连接父节点与子节点间的线条
        TreeView1.ExpandDepth = 1;//控件显示时所展开的层数
    }
    public void BindDataBase()
    {
        //实例化SqlConnection对象
        SqlConnection sqlCon = new SqlConnection();
        //实例化SqlConnection对象连接数据库的字符串
        sqlCon.ConnectionString = @"server=(local);uid=sa;pwd=;database=db_LibraryMS";
        //实例化SqlDataAdapter对象
        SqlDataAdapter da = new SqlDataAdapter("select * from tb_booktype", sqlCon);
        //实例化数据集DataSet
        DataSet ds = new DataSet();
        da.Fill(ds, "tb_booktype");
        //下面的方法动态添加了TreeView的根节点和子节点
        //设置TreeView的根节点
        TreeNode tree1 = new TreeNode("图书分类");
        this.TreeView1.Nodes.Add(tree1);
        for (int i = 0; i < ds.Tables["tb_booktype"].Rows.Count; i++)
        {
            TreeNode tree2 = new TreeNode(ds.Tables["tb_booktype"].Rows[i][1].ToString(), ds.Tables["tb_booktype"].Rows[i][1].ToString());
            tree1.ChildNodes.Add(tree2);
        }
    }
}
