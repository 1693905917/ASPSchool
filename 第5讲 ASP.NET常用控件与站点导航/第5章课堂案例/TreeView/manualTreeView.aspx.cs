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
using System.Xml;

public partial class manualTreeView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string aa=manualTree.DataSourceID;
        manualTree.CollapseAll();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        TreeNode tn=new TreeNode();
        tn.Text="S337班";
        tn.NavigateUrl="default3.aspx";
        TreeNode mytreenode = manualTree.FindNode("北大青鸟");
        manualTree.FindNode("北大青鸟/培训中心/ACCP培训").ChildNodes.Add(tn);
    }
}
